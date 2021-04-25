
namespace Heat_Equation
{
    partial class Form_Heat
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart_points = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.listView_points = new System.Windows.Forms.ListView();
            this.columnHeader_X = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader_Y = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button_solve = new System.Windows.Forms.Button();
            this.label_Count = new System.Windows.Forms.Label();
            this.textBox_count = new System.Windows.Forms.TextBox();
            this.button_exit = new System.Windows.Forms.Button();
            this.button_export = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.chart_points)).BeginInit();
            this.SuspendLayout();
            // 
            // chart_points
            // 
            this.chart_points.BackColor = System.Drawing.Color.PaleGreen;
            chartArea4.Name = "ChartArea1";
            this.chart_points.ChartAreas.Add(chartArea4);
            legend4.Name = "Legend1";
            this.chart_points.Legends.Add(legend4);
            this.chart_points.Location = new System.Drawing.Point(234, 3);
            this.chart_points.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.chart_points.Name = "chart_points";
            series4.BorderWidth = 2;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series4.Color = System.Drawing.Color.RoyalBlue;
            series4.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            series4.LabelBackColor = System.Drawing.Color.White;
            series4.LabelBorderColor = System.Drawing.Color.White;
            series4.Legend = "Legend1";
            series4.MarkerBorderColor = System.Drawing.Color.White;
            series4.MarkerColor = System.Drawing.Color.White;
            series4.Name = "Решение";
            this.chart_points.Series.Add(series4);
            this.chart_points.Size = new System.Drawing.Size(478, 368);
            this.chart_points.TabIndex = 0;
            this.chart_points.Text = "График";
            // 
            // listView_points
            // 
            this.listView_points.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader_X,
            this.columnHeader_Y});
            this.listView_points.GridLines = true;
            this.listView_points.HideSelection = false;
            this.listView_points.Location = new System.Drawing.Point(12, 44);
            this.listView_points.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.listView_points.Name = "listView_points";
            this.listView_points.Size = new System.Drawing.Size(225, 275);
            this.listView_points.TabIndex = 1;
            this.listView_points.UseCompatibleStateImageBehavior = false;
            this.listView_points.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader_X
            // 
            this.columnHeader_X.Text = "Координата X";
            this.columnHeader_X.Width = 112;
            // 
            // columnHeader_Y
            // 
            this.columnHeader_Y.Text = "Координата Y";
            this.columnHeader_Y.Width = 112;
            // 
            // button_solve
            // 
            this.button_solve.Location = new System.Drawing.Point(12, 327);
            this.button_solve.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_solve.Name = "button_solve";
            this.button_solve.Size = new System.Drawing.Size(71, 28);
            this.button_solve.TabIndex = 2;
            this.button_solve.Text = "Решить";
            this.button_solve.UseVisualStyleBackColor = true;
            this.button_solve.Click += new System.EventHandler(this.button_solve_Click);
            // 
            // label_Count
            // 
            this.label_Count.AutoSize = true;
            this.label_Count.Location = new System.Drawing.Point(9, 16);
            this.label_Count.Name = "label_Count";
            this.label_Count.Size = new System.Drawing.Size(191, 16);
            this.label_Count.TabIndex = 3;
            this.label_Count.Text = "Введите количество точек (Х):";
            // 
            // textBox_count
            // 
            this.textBox_count.Location = new System.Drawing.Point(206, 13);
            this.textBox_count.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBox_count.Name = "textBox_count";
            this.textBox_count.Size = new System.Drawing.Size(31, 23);
            this.textBox_count.TabIndex = 4;
            // 
            // button_exit
            // 
            this.button_exit.Location = new System.Drawing.Point(89, 327);
            this.button_exit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_exit.Name = "button_exit";
            this.button_exit.Size = new System.Drawing.Size(71, 28);
            this.button_exit.TabIndex = 5;
            this.button_exit.Text = "Закрыть";
            this.button_exit.UseVisualStyleBackColor = true;
            this.button_exit.Click += new System.EventHandler(this.button_exit_Click);
            // 
            // button_export
            // 
            this.button_export.Location = new System.Drawing.Point(166, 327);
            this.button_export.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button_export.Name = "button_export";
            this.button_export.Size = new System.Drawing.Size(71, 28);
            this.button_export.TabIndex = 6;
            this.button_export.Text = "Excel";
            this.button_export.UseVisualStyleBackColor = true;
            this.button_export.Click += new System.EventHandler(this.button_export_Click);
            // 
            // Form_Heat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGreen;
            this.ClientSize = new System.Drawing.Size(703, 394);
            this.Controls.Add(this.button_export);
            this.Controls.Add(this.button_exit);
            this.Controls.Add(this.textBox_count);
            this.Controls.Add(this.label_Count);
            this.Controls.Add(this.button_solve);
            this.Controls.Add(this.listView_points);
            this.Controls.Add(this.chart_points);
            this.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "Form_Heat";
            this.Text = "Уравнение теплопроводности";
            this.Load += new System.EventHandler(this.Form_Heat_Load);
            ((System.ComponentModel.ISupportInitialize)(this.chart_points)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart_points;
        private System.Windows.Forms.ListView listView_points;
        private System.Windows.Forms.ColumnHeader columnHeader_X;
        private System.Windows.Forms.ColumnHeader columnHeader_Y;
        private System.Windows.Forms.Button button_solve;
        private System.Windows.Forms.Label label_Count;
        private System.Windows.Forms.TextBox textBox_count;
        private System.Windows.Forms.Button button_exit;
        private System.Windows.Forms.Button button_export;
    }
}

