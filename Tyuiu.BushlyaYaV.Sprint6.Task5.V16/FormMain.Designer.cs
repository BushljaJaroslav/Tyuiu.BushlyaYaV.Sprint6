namespace Tyuiu.BushlyaYaV.Sprint6.Task5.V16
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
            panelTask_BYV = new Panel();
            buttonHelp_BYV = new Button();
            buttonOpenFile_BYV = new Button();
            buttonDone_BYV = new Button();
            groupBoxTask_BYV = new GroupBox();
            textBoxTask_BYV = new TextBox();
            panelOutPutData_BYV = new Panel();
            groupBoxOutPutData_BYV = new GroupBox();
            dataGridViewResult_BYV = new DataGridView();
            s = new DataGridViewTextBoxColumn();
            Column1 = new DataGridViewTextBoxColumn();
            splitter1 = new Splitter();
            panelResult_BYV = new Panel();
            chartFunction_BYV = new System.Windows.Forms.DataVisualization.Charting.Chart();
            panelTask_BYV.SuspendLayout();
            groupBoxTask_BYV.SuspendLayout();
            panelOutPutData_BYV.SuspendLayout();
            groupBoxOutPutData_BYV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_BYV).BeginInit();
            panelResult_BYV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)chartFunction_BYV).BeginInit();
            SuspendLayout();
            // 
            // panelTask_BYV
            // 
            panelTask_BYV.BackColor = SystemColors.ButtonFace;
            panelTask_BYV.Controls.Add(buttonHelp_BYV);
            panelTask_BYV.Controls.Add(buttonOpenFile_BYV);
            panelTask_BYV.Controls.Add(buttonDone_BYV);
            panelTask_BYV.Controls.Add(groupBoxTask_BYV);
            panelTask_BYV.Dock = DockStyle.Top;
            panelTask_BYV.Location = new Point(0, 0);
            panelTask_BYV.Name = "panelTask_BYV";
            panelTask_BYV.Size = new Size(656, 65);
            panelTask_BYV.TabIndex = 1;
            // 
            // buttonHelp_BYV
            // 
            buttonHelp_BYV.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonHelp_BYV.BackColor = Color.Blue;
            buttonHelp_BYV.ForeColor = SystemColors.ButtonHighlight;
            buttonHelp_BYV.Location = new Point(578, 9);
            buttonHelp_BYV.Name = "buttonHelp_BYV";
            buttonHelp_BYV.Size = new Size(75, 50);
            buttonHelp_BYV.TabIndex = 3;
            buttonHelp_BYV.Text = "Справка";
            buttonHelp_BYV.UseVisualStyleBackColor = false;
            buttonHelp_BYV.Click += buttonHelp_BYV_Click;
            // 
            // buttonOpenFile_BYV
            // 
            buttonOpenFile_BYV.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonOpenFile_BYV.BackColor = Color.Yellow;
            buttonOpenFile_BYV.Location = new Point(495, 9);
            buttonOpenFile_BYV.Name = "buttonOpenFile_BYV";
            buttonOpenFile_BYV.Size = new Size(75, 50);
            buttonOpenFile_BYV.TabIndex = 2;
            buttonOpenFile_BYV.Text = "Открыть файл";
            buttonOpenFile_BYV.UseVisualStyleBackColor = false;
            buttonOpenFile_BYV.Click += buttonOpenFile_BYV_Click;
            // 
            // buttonDone_BYV
            // 
            buttonDone_BYV.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            buttonDone_BYV.BackColor = Color.FromArgb(0, 192, 0);
            buttonDone_BYV.Location = new Point(410, 9);
            buttonDone_BYV.Name = "buttonDone_BYV";
            buttonDone_BYV.Size = new Size(79, 50);
            buttonDone_BYV.TabIndex = 1;
            buttonDone_BYV.Text = "Выполнить";
            buttonDone_BYV.UseVisualStyleBackColor = false;
            buttonDone_BYV.Click += buttonDone_BYV_Click;
            // 
            // groupBoxTask_BYV
            // 
            groupBoxTask_BYV.BackColor = SystemColors.ButtonFace;
            groupBoxTask_BYV.Controls.Add(textBoxTask_BYV);
            groupBoxTask_BYV.Location = new Point(2, 0);
            groupBoxTask_BYV.Name = "groupBoxTask_BYV";
            groupBoxTask_BYV.Size = new Size(402, 65);
            groupBoxTask_BYV.TabIndex = 0;
            groupBoxTask_BYV.TabStop = false;
            groupBoxTask_BYV.Text = "Условие:";
            // 
            // textBoxTask_BYV
            // 
            textBoxTask_BYV.BackColor = SystemColors.ButtonFace;
            textBoxTask_BYV.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            textBoxTask_BYV.Location = new Point(6, 15);
            textBoxTask_BYV.Multiline = true;
            textBoxTask_BYV.Name = "textBoxTask_BYV";
            textBoxTask_BYV.Size = new Size(390, 47);
            textBoxTask_BYV.TabIndex = 0;
            textBoxTask_BYV.Text = "Прочитать данные из файла InPutTask5V16.txt. Вывести в dataGridView положительные значения и построить диаграмму по этим значениям.";
            // 
            // panelOutPutData_BYV
            // 
            panelOutPutData_BYV.BackColor = SystemColors.ButtonFace;
            panelOutPutData_BYV.Controls.Add(groupBoxOutPutData_BYV);
            panelOutPutData_BYV.Dock = DockStyle.Left;
            panelOutPutData_BYV.Location = new Point(0, 65);
            panelOutPutData_BYV.Name = "panelOutPutData_BYV";
            panelOutPutData_BYV.Size = new Size(138, 397);
            panelOutPutData_BYV.TabIndex = 2;
            // 
            // groupBoxOutPutData_BYV
            // 
            groupBoxOutPutData_BYV.Controls.Add(dataGridViewResult_BYV);
            groupBoxOutPutData_BYV.Dock = DockStyle.Fill;
            groupBoxOutPutData_BYV.Location = new Point(0, 0);
            groupBoxOutPutData_BYV.Name = "groupBoxOutPutData_BYV";
            groupBoxOutPutData_BYV.Size = new Size(138, 397);
            groupBoxOutPutData_BYV.TabIndex = 0;
            groupBoxOutPutData_BYV.TabStop = false;
            groupBoxOutPutData_BYV.Text = "Вывод данных:";
            // 
            // dataGridViewResult_BYV
            // 
            dataGridViewResult_BYV.BackgroundColor = SystemColors.AppWorkspace;
            dataGridViewResult_BYV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewResult_BYV.Columns.AddRange(new DataGridViewColumn[] { s, Column1 });
            dataGridViewResult_BYV.Dock = DockStyle.Fill;
            dataGridViewResult_BYV.Location = new Point(3, 19);
            dataGridViewResult_BYV.Name = "dataGridViewResult_BYV";
            dataGridViewResult_BYV.RowHeadersVisible = false;
            dataGridViewResult_BYV.ScrollBars = ScrollBars.Horizontal;
            dataGridViewResult_BYV.Size = new Size(132, 375);
            dataGridViewResult_BYV.TabIndex = 0;
            // 
            // s
            // 
            s.HeaderText = "";
            s.MinimumWidth = 8;
            s.Name = "s";
            s.Width = 50;
            // 
            // Column1
            // 
            Column1.HeaderText = "";
            Column1.MinimumWidth = 8;
            Column1.Name = "Column1";
            Column1.Width = 80;
            // 
            // splitter1
            // 
            splitter1.Location = new Point(138, 65);
            splitter1.Name = "splitter1";
            splitter1.Size = new Size(3, 397);
            splitter1.TabIndex = 3;
            splitter1.TabStop = false;
            // 
            // panelResult_BYV
            // 
            panelResult_BYV.Controls.Add(chartFunction_BYV);
            panelResult_BYV.Dock = DockStyle.Fill;
            panelResult_BYV.Location = new Point(141, 65);
            panelResult_BYV.Name = "panelResult_BYV";
            panelResult_BYV.Size = new Size(515, 397);
            panelResult_BYV.TabIndex = 4;
            // 
            // chartFunction_BYV
            // 
            chartArea1.Name = "ChartArea1";
            chartFunction_BYV.ChartAreas.Add(chartArea1);
            chartFunction_BYV.Dock = DockStyle.Fill;
            legend1.Enabled = false;
            legend1.Name = "Legend1";
            chartFunction_BYV.Legends.Add(legend1);
            chartFunction_BYV.Location = new Point(0, 0);
            chartFunction_BYV.Name = "chartFunction_BYV";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            chartFunction_BYV.Series.Add(series1);
            chartFunction_BYV.Size = new Size(515, 397);
            chartFunction_BYV.TabIndex = 0;
            chartFunction_BYV.Text = "-";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(656, 462);
            Controls.Add(panelResult_BYV);
            Controls.Add(splitter1);
            Controls.Add(panelOutPutData_BYV);
            Controls.Add(panelTask_BYV);
            MinimumSize = new Size(672, 501);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 5 | Вариант 16 | Бушля Я. В.";
            panelTask_BYV.ResumeLayout(false);
            groupBoxTask_BYV.ResumeLayout(false);
            groupBoxTask_BYV.PerformLayout();
            panelOutPutData_BYV.ResumeLayout(false);
            groupBoxOutPutData_BYV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_BYV).EndInit();
            panelResult_BYV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)chartFunction_BYV).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panelTask_BYV;
        private Panel panelOutPutData_BYV;
        private Splitter splitter1;
        private Panel panelResult_BYV;
        private GroupBox groupBoxOutPutData_BYV;
        private DataGridView dataGridViewResult_BYV;
        private GroupBox groupBoxTask_BYV;
        private TextBox textBoxTask_BYV;
        private System.Windows.Forms.DataVisualization.Charting.Chart chartFunction_BYV;
        private Button buttonHelp_BYV;
        private Button buttonOpenFile_BYV;
        private Button buttonDone_BYV;
        private DataGridViewTextBoxColumn s;
        private DataGridViewTextBoxColumn Column1;
    }
}
