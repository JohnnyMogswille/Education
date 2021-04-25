using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using OfficeOpenXml;
using OfficeOpenXml.Style;

namespace Heat_Equation
{
    
    public partial class Form_Heat : Form
    {
        
        public Form_Heat()
        {
            InitializeComponent();

        }
        /// <summary>
        /// Метод для возвращения коллекции точек. Нужен для листвивера
        /// </summary>
        /// <returns></returns>
        private List<Heat_point> GetHeat_Points()
        {
            var listPoint = new List<Heat_point>();
            int N=1;
            bool success = int.TryParse(textBox_count.Text, out N);
            if(success)
                N = Convert.ToInt32(textBox_count.Text);
            else
                MessageBox.Show("Ошибка. Введите число", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);

            if (N <= 0)
            {
                MessageBox.Show("Ошибка. Введите значение больше 0", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox_count.Clear();
            }

            else
            {
                for (int i = 1; i <= N; i++)
                {
                    listPoint.Add(new Heat_point() { X = i * 0.1, Y = 3*(i*0.1*i*0.1*i*0.1) + 7/(i*0.1*i*0.1) - 5*i*0.1*i*0.1 });
                }
            }
            return listPoint;
        }

        private void button_solve_Click(object sender, EventArgs e)
        {
            this.listView_points.Items.Clear(); //Очищаем листвивер
            chart_points.Series[0].Points.Clear();
            var points = GetHeat_Points(); //Получаем лист (матрицу) точек
            foreach (var point in points) //пробегаемся по точкам и добавляем их в лист
            {
                //т.к. лист-коллекция строк, создаем массив строк, где параметры - это столбцы, в которые помещаем элементы массива строк
                // то есть первая строка - первая строка массива строк (в нашем случае точек) и так по каждой строке
                var row = new string[] { Convert.ToString(point.X), Convert.ToString(point.Y) };
                //теперь создаем лист, который будет содержать в себе строки, передаем туда наш массив строк
                var listitempoints = new ListViewItem(row);
                //в целом тег нам не нужен
                //listitempoints.Tag = point;
                //добавляем в наш листвивер элементы и в качестве параметра передаем наш лист точек
                listView_points.Items.Add(listitempoints);
                //рисуем
                chart_points.Series[0].Points.AddXY(point.X, point.Y);
            }
            //ExcelPackage.LicenseContext = OfficeOpenXml.LicenseContext.NonCommercial;
        }

        private void button_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form_Heat_Load(object sender, EventArgs e)
        {
            
        }

        private void button_export_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog saveFileDialog = new SaveFileDialog() { Filter = "Excel Workbook|*.xlsx" })
            {
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        FileInfo fileinfo = new FileInfo(saveFileDialog.FileName);
                        using (ExcelPackage excel = new ExcelPackage(fileinfo))
                        {
                            ExcelWorksheet excelWorksheet = excel.Workbook.Worksheets.Add("Data");
                            //Создаем шапку для нашей таблицы
                            var headerRow = new List<string[]>()
                            {
                                new string[] { "Координата X", "Координата Y"}
                            };

                            string headerRange = "A1:" + Char.ConvertFromUtf32(headerRow[0].Length + 64) + "1";
                            excelWorksheet.Cells[headerRange].LoadFromArrays(headerRow);
                            excelWorksheet.Cells[headerRange].Style.Font.Bold = true;

                            int columns_count = excelWorksheet.Cells[headerRange].Columns;
                            
                            excelWorksheet.Cells[headerRange].Style.Border.Top.Style = ExcelBorderStyle.Thin;
                            excelWorksheet.Cells[headerRange].Style.Border.Left.Style = ExcelBorderStyle.Thin;
                            excelWorksheet.Cells[headerRange].Style.Border.Right.Style = ExcelBorderStyle.Thin;
                            excelWorksheet.Cells[headerRange].Style.Border.Bottom.Style = ExcelBorderStyle.Thin;

                            double minimumSize = 100;
                            double maximumSize = 200;
                            excelWorksheet.Cells[excelWorksheet.Dimension.Address].AutoFitColumns(minimumSize, maximumSize);
                            excelWorksheet.Cells[excelWorksheet.Dimension.Address].AutoFilter = true;

                            for (int i = 1; i <= columns_count; i++)
                            {
                                excelWorksheet.Column(i).Style.VerticalAlignment = ExcelVerticalAlignment.Center;
                                excelWorksheet.Column(i).Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;
                            }
                            
                            //создаем лист точек
                            List<Heat_point> heat_Points = new List<Heat_point>();
                            //задаем количество точек
                            for (int i = 1; i <= Convert.ToInt32(textBox_count.Text); i++)
                            {
                                //создаем конкретную точку и передаем координаты, после чего передаем эту точку в лист точек
                                Heat_point p = new Heat_point();
                                p.X = i * 0.1;
                                p.Y = 3 * (p.X * p.X * p.X) + (7 / (p.X * p.X)) - 5 * (p.X * p.X);
                                heat_Points.Add(p);

                                for (int j = 1; j <= columns_count; j++)
                                {
                                    excelWorksheet.Cells[i + 1, j].Style.Numberformat.Format = "0.00";
                                    excelWorksheet.Cells[i + 1, j].Style.Border.Top.Style = ExcelBorderStyle.Thin;
                                    excelWorksheet.Cells[i + 1, j].Style.Border.Left.Style = ExcelBorderStyle.Thin;
                                    excelWorksheet.Cells[i + 1, j].Style.Border.Right.Style = ExcelBorderStyle.Thin;
                                    excelWorksheet.Cells[i + 1, j].Style.Border.Bottom.Style = ExcelBorderStyle.Thin;
                                }
                            }
                            //Начиная с ячейки А2 загружаем из коллекции (лист точек) наши точки
                            excelWorksheet.Cells["A2"].LoadFromCollection(heat_Points);
                            //сохраняем
                            excel.SaveAs(fileinfo);
                            MessageBox.Show("Файл успешно сохранен!", "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message, "Внимание", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}
