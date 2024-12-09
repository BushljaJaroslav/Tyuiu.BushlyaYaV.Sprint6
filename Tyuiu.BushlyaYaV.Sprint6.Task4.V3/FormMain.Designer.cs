namespace Tyuiu.BushlyaYaV.Sprint6.Task4.V3
{
    partial class FormMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Title title1 = new System.Windows.Forms.DataVisualization.Charting.Title();
            groupBoxTask_BYV = new GroupBox();
            groupBoxData_BYV = new GroupBox();
            groupBoxRes_BYV = new GroupBox();
            textBoxUslovie_BYV = new TextBox();
            labelNamedOne_BYV = new Label();
            labelNamedTwo_BYV = new Label();
            textBoxStart_BYV = new TextBox();
            textBoxEnd_BYV = new TextBox();
            textBoxRes_BYV = new TextBox();
            buttonDone_BYV = new Button();
            buttonSave_BYV = new Button();
            buttonHelp_BYV = new Button();
            chartFunction_BYV = new System.Windows.Forms.DataVisualization.Charting.Chart();
            groupBoxTask_BYV.SuspendLayout();
            groupBoxData_BYV.SuspendLayout();
            groupBoxRes_BYV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunction_BYV).BeginInit();
            SuspendLayout();
            // 
            // groupBoxTask_BYV
            // 
            groupBoxTask_BYV.Controls.Add(textBoxUslovie_BYV);
            groupBoxTask_BYV.Location = new Point(20, 24);
            groupBoxTask_BYV.Name = "groupBoxTask_BYV";
            groupBoxTask_BYV.Size = new Size(382, 95);
            groupBoxTask_BYV.TabIndex = 0;
            groupBoxTask_BYV.TabStop = false;
            groupBoxTask_BYV.Text = "Условие:";
            // 
            // groupBoxData_BYV
            // 
            groupBoxData_BYV.Controls.Add(textBoxEnd_BYV);
            groupBoxData_BYV.Controls.Add(textBoxStart_BYV);
            groupBoxData_BYV.Controls.Add(labelNamedTwo_BYV);
            groupBoxData_BYV.Controls.Add(labelNamedOne_BYV);
            groupBoxData_BYV.Location = new Point(422, 24);
            groupBoxData_BYV.Name = "groupBoxData_BYV";
            groupBoxData_BYV.Size = new Size(298, 95);
            groupBoxData_BYV.TabIndex = 1;
            groupBoxData_BYV.TabStop = false;
            groupBoxData_BYV.Text = "Ввод данных:";
            // 
            // groupBoxRes_BYV
            // 
            groupBoxRes_BYV.Controls.Add(textBoxRes_BYV);
            groupBoxRes_BYV.Location = new Point(20, 168);
            groupBoxRes_BYV.Name = "groupBoxRes_BYV";
            groupBoxRes_BYV.Size = new Size(242, 420);
            groupBoxRes_BYV.TabIndex = 2;
            groupBoxRes_BYV.TabStop = false;
            groupBoxRes_BYV.Text = "Вывод данных:";
            // 
            // textBoxUslovie_BYV
            // 
            textBoxUslovie_BYV.BackColor = SystemColors.ButtonFace;
            textBoxUslovie_BYV.Location = new Point(6, 18);
            textBoxUslovie_BYV.Multiline = true;
            textBoxUslovie_BYV.Name = "textBoxUslovie_BYV";
            textBoxUslovie_BYV.Size = new Size(370, 67);
            textBoxUslovie_BYV.TabIndex = 0;
            textBoxUslovie_BYV.Text = "Протабулировать функцию на заданном диапазоне.\r\nРезультат выести в textBox, построить график функции и сохранить в файл OutPutFileTask4V3.txt по нажатию кнопки.\r\n";
            // 
            // labelNamedOne_BYV
            // 
            labelNamedOne_BYV.AutoSize = true;
            labelNamedOne_BYV.Location = new Point(24, 31);
            labelNamedOne_BYV.Name = "labelNamedOne_BYV";
            labelNamedOne_BYV.Size = new Size(72, 15);
            labelNamedOne_BYV.TabIndex = 0;
            labelNamedOne_BYV.Text = "Старт шага:";
            // 
            // labelNamedTwo_BYV
            // 
            labelNamedTwo_BYV.AutoSize = true;
            labelNamedTwo_BYV.Location = new Point(181, 31);
            labelNamedTwo_BYV.Name = "labelNamedTwo_BYV";
            labelNamedTwo_BYV.Size = new Size(75, 15);
            labelNamedTwo_BYV.TabIndex = 1;
            labelNamedTwo_BYV.Text = "Конец шага:";
            // 
            // textBoxStart_BYV
            // 
            textBoxStart_BYV.Location = new Point(21, 48);
            textBoxStart_BYV.Name = "textBoxStart_BYV";
            textBoxStart_BYV.Size = new Size(100, 23);
            textBoxStart_BYV.TabIndex = 2;
            // 
            // textBoxEnd_BYV
            // 
            textBoxEnd_BYV.Location = new Point(178, 48);
            textBoxEnd_BYV.Name = "textBoxEnd_BYV";
            textBoxEnd_BYV.Size = new Size(100, 23);
            textBoxEnd_BYV.TabIndex = 3;
            // 
            // textBoxRes_BYV
            // 
            textBoxRes_BYV.Location = new Point(6, 22);
            textBoxRes_BYV.Multiline = true;
            textBoxRes_BYV.Name = "textBoxRes_BYV";
            textBoxRes_BYV.ScrollBars = ScrollBars.Vertical;
            textBoxRes_BYV.Size = new Size(230, 392);
            textBoxRes_BYV.TabIndex = 0;
            // 
            // buttonDone_BYV
            // 
            buttonDone_BYV.BackColor = Color.Green;
            buttonDone_BYV.Location = new Point(737, 42);
            buttonDone_BYV.Name = "buttonDone_BYV";
            buttonDone_BYV.Size = new Size(90, 53);
            buttonDone_BYV.TabIndex = 3;
            buttonDone_BYV.Text = "Выполнить";
            buttonDone_BYV.UseVisualStyleBackColor = false;
            // 
            // buttonSave_BYV
            // 
            buttonSave_BYV.BackColor = Color.FromArgb(192, 64, 0);
            buttonSave_BYV.Location = new Point(833, 42);
            buttonSave_BYV.Name = "buttonSave_BYV";
            buttonSave_BYV.Size = new Size(90, 53);
            buttonSave_BYV.TabIndex = 4;
            buttonSave_BYV.Text = "Сохранить";
            buttonSave_BYV.UseVisualStyleBackColor = false;
            // 
            // buttonHelp_BYV
            // 
            buttonHelp_BYV.BackColor = Color.SteelBlue;
            buttonHelp_BYV.Location = new Point(930, 42);
            buttonHelp_BYV.Name = "buttonHelp_BYV";
            buttonHelp_BYV.Size = new Size(90, 53);
            buttonHelp_BYV.TabIndex = 5;
            buttonHelp_BYV.Text = "Справка";
            buttonHelp_BYV.UseVisualStyleBackColor = false;
            // 
            // chartFunction_BYV
            // 
            chartArea1.Name = "ChartArea1";
            chartFunction_BYV.ChartAreas.Add(chartArea1);
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            chartFunction_BYV.Legends.Add(legend1);
            chartFunction_BYV.Location = new Point(278, 190);
            chartFunction_BYV.Name = "chartFunction_BYV";
            series1.ChartArea = "ChartArea1";
            series1.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series1.IsVisibleInLegend = false;
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartFunction_BYV.Series.Add(series1);
            chartFunction_BYV.Size = new Size(706, 392);
            chartFunction_BYV.TabIndex = 6;
            chartFunction_BYV.Text = "chart1";
            title1.Font = new Font("Microsoft Sans Serif", 12F, FontStyle.Bold, GraphicsUnit.Point, 204);
            title1.ForeColor = Color.FromArgb(128, 128, 255);
            title1.Name = "Title1";
            title1.Text = "График функции sin(x)";
            chartFunction_BYV.Titles.Add(title1);
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1026, 600);
            Controls.Add(chartFunction_BYV);
            Controls.Add(buttonHelp_BYV);
            Controls.Add(buttonSave_BYV);
            Controls.Add(buttonDone_BYV);
            Controls.Add(groupBoxRes_BYV);
            Controls.Add(groupBoxData_BYV);
            Controls.Add(groupBoxTask_BYV);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 4 | Вариант 3 | Бушля Я. В. ";
            groupBoxTask_BYV.ResumeLayout(false);
            groupBoxTask_BYV.PerformLayout();
            groupBoxData_BYV.ResumeLayout(false);
            groupBoxData_BYV.PerformLayout();
            groupBoxRes_BYV.ResumeLayout(false);
            groupBoxRes_BYV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunction_BYV).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTask_BYV;
        private TextBox textBoxUslovie_BYV;
        private GroupBox groupBoxData_BYV;
        private GroupBox groupBoxRes_BYV;
        private TextBox textBoxEnd_BYV;
        private TextBox textBoxStart_BYV;
        private Label labelNamedTwo_BYV;
        private Label labelNamedOne_BYV;
        private TextBox textBoxRes_BYV;
        private Button buttonDone_BYV;
        private Button buttonSave_BYV;
        private Button buttonHelp_BYV;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_BYV;
    }
}
