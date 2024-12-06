namespace Tyuiu.BushlyaYaV.Sprint6.Task2.V13
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
            groupBoxUslovie_BYV = new GroupBox();
            textBoxUslovie_BYV = new TextBox();
            groupBoxZnach_BYV = new GroupBox();
            textBoxStopStep_BYV = new TextBox();
            textBoxStartStep_BYV = new TextBox();
            textBoxStop_BYV = new TextBox();
            textBoxStart_BYV = new TextBox();
            buttonHelp_BYV = new Button();
            buttonDone_BYV = new Button();
            groupBoxResult_BYV = new GroupBox();
            dataGridViewResult_BYV = new DataGridView();
            ColunmnX_BYV = new DataGridViewTextBoxColumn();
            ColumnFx_BYV = new DataGridViewTextBoxColumn();
            groupBoxUslovie_BYV.SuspendLayout();
            groupBoxZnach_BYV.SuspendLayout();
            groupBoxResult_BYV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_BYV).BeginInit();
            SuspendLayout();
            // 
            // groupBoxUslovie_BYV
            // 
            groupBoxUslovie_BYV.Controls.Add(textBoxUslovie_BYV);
            groupBoxUslovie_BYV.Location = new Point(12, 12);
            groupBoxUslovie_BYV.Name = "groupBoxUslovie_BYV";
            groupBoxUslovie_BYV.Size = new Size(462, 205);
            groupBoxUslovie_BYV.TabIndex = 0;
            groupBoxUslovie_BYV.TabStop = false;
            groupBoxUslovie_BYV.Text = "Условие";
            // 
            // textBoxUslovie_BYV
            // 
            textBoxUslovie_BYV.BackColor = SystemColors.ButtonFace;
            textBoxUslovie_BYV.Location = new Point(6, 22);
            textBoxUslovie_BYV.Multiline = true;
            textBoxUslovie_BYV.Name = "textBoxUslovie_BYV";
            textBoxUslovie_BYV.Size = new Size(450, 177);
            textBoxUslovie_BYV.TabIndex = 0;
            textBoxUslovie_BYV.Text = "Протабулировать функцию на заданном диапазоне. Ответ вывести в DataGridView и построить график функции.";
            // 
            // groupBoxZnach_BYV
            // 
            groupBoxZnach_BYV.Controls.Add(textBoxStopStep_BYV);
            groupBoxZnach_BYV.Controls.Add(textBoxStartStep_BYV);
            groupBoxZnach_BYV.Controls.Add(textBoxStop_BYV);
            groupBoxZnach_BYV.Controls.Add(textBoxStart_BYV);
            groupBoxZnach_BYV.Location = new Point(18, 239);
            groupBoxZnach_BYV.Name = "groupBoxZnach_BYV";
            groupBoxZnach_BYV.Size = new Size(229, 94);
            groupBoxZnach_BYV.TabIndex = 1;
            groupBoxZnach_BYV.TabStop = false;
            groupBoxZnach_BYV.Text = "Ввод данных";
            // 
            // textBoxStopStep_BYV
            // 
            textBoxStopStep_BYV.Location = new Point(134, 56);
            textBoxStopStep_BYV.Name = "textBoxStopStep_BYV";
            textBoxStopStep_BYV.Size = new Size(67, 23);
            textBoxStopStep_BYV.TabIndex = 3;
            // 
            // textBoxStartStep_BYV
            // 
            textBoxStartStep_BYV.Location = new Point(17, 56);
            textBoxStartStep_BYV.Name = "textBoxStartStep_BYV";
            textBoxStartStep_BYV.Size = new Size(67, 23);
            textBoxStartStep_BYV.TabIndex = 2;
            // 
            // textBoxStop_BYV
            // 
            textBoxStop_BYV.BackColor = SystemColors.ButtonFace;
            textBoxStop_BYV.BorderStyle = BorderStyle.None;
            textBoxStop_BYV.Location = new Point(131, 38);
            textBoxStop_BYV.Name = "textBoxStop_BYV";
            textBoxStop_BYV.Size = new Size(78, 16);
            textBoxStop_BYV.TabIndex = 1;
            textBoxStop_BYV.Text = "Конец шага:";
            // 
            // textBoxStart_BYV
            // 
            textBoxStart_BYV.BackColor = SystemColors.ButtonFace;
            textBoxStart_BYV.BorderStyle = BorderStyle.None;
            textBoxStart_BYV.Location = new Point(16, 38);
            textBoxStart_BYV.Name = "textBoxStart_BYV";
            textBoxStart_BYV.Size = new Size(78, 16);
            textBoxStart_BYV.TabIndex = 0;
            textBoxStart_BYV.Text = "Старт шага:";
            // 
            // buttonHelp_BYV
            // 
            buttonHelp_BYV.BackColor = Color.FromArgb(128, 128, 255);
            buttonHelp_BYV.Location = new Point(264, 246);
            buttonHelp_BYV.Name = "buttonHelp_BYV";
            buttonHelp_BYV.Size = new Size(83, 87);
            buttonHelp_BYV.TabIndex = 2;
            buttonHelp_BYV.Text = "Справка";
            buttonHelp_BYV.UseVisualStyleBackColor = false;
            // 
            // buttonDone_BYV
            // 
            buttonDone_BYV.BackColor = Color.Green;
            buttonDone_BYV.Location = new Point(365, 246);
            buttonDone_BYV.Name = "buttonDone_BYV";
            buttonDone_BYV.Size = new Size(109, 87);
            buttonDone_BYV.TabIndex = 3;
            buttonDone_BYV.Text = "Выполнить";
            buttonDone_BYV.UseVisualStyleBackColor = false;
            // 
            // groupBoxResult_BYV
            // 
            groupBoxResult_BYV.Controls.Add(dataGridViewResult_BYV);
            groupBoxResult_BYV.Location = new Point(480, 12);
            groupBoxResult_BYV.Name = "groupBoxResult_BYV";
            groupBoxResult_BYV.Size = new Size(515, 321);
            groupBoxResult_BYV.TabIndex = 4;
            groupBoxResult_BYV.TabStop = false;
            groupBoxResult_BYV.Text = "Вывод данных";
            // 
            // dataGridViewResult_BYV
            // 
            dataGridViewResult_BYV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewResult_BYV.Columns.AddRange(new DataGridViewColumn[] { ColunmnX_BYV, ColumnFx_BYV });
            dataGridViewResult_BYV.Location = new Point(6, 22);
            dataGridViewResult_BYV.Name = "dataGridViewResult_BYV";
            dataGridViewResult_BYV.RowHeadersVisible = false;
            dataGridViewResult_BYV.Size = new Size(136, 293);
            dataGridViewResult_BYV.TabIndex = 0;
            // 
            // ColunmnX_BYV
            // 
            ColunmnX_BYV.HeaderText = "X";
            ColunmnX_BYV.Name = "ColunmnX_BYV";
            ColunmnX_BYV.Width = 50;
            // 
            // ColumnFx_BYV
            // 
            ColumnFx_BYV.HeaderText = "F(X)";
            ColumnFx_BYV.Name = "ColumnFx_BYV";
            ColumnFx_BYV.Width = 50;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1007, 345);
            Controls.Add(groupBoxResult_BYV);
            Controls.Add(buttonDone_BYV);
            Controls.Add(buttonHelp_BYV);
            Controls.Add(groupBoxZnach_BYV);
            Controls.Add(groupBoxUslovie_BYV);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 2 | Вариант 13 | Бушля Я. В. ";
            groupBoxUslovie_BYV.ResumeLayout(false);
            groupBoxUslovie_BYV.PerformLayout();
            groupBoxZnach_BYV.ResumeLayout(false);
            groupBoxZnach_BYV.PerformLayout();
            groupBoxResult_BYV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewResult_BYV).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxUslovie_BYV;
        private TextBox textBoxUslovie_BYV;
        private GroupBox groupBoxZnach_BYV;
        private TextBox textBoxStop_BYV;
        private TextBox textBoxStart_BYV;
        private TextBox textBoxStartStep_BYV;
        private TextBox textBoxStopStep_BYV;
        private Button buttonHelp_BYV;
        private Button buttonDone_BYV;
        private GroupBox groupBoxResult_BYV;
        private DataGridView dataGridViewResult_BYV;
        private DataGridViewTextBoxColumn ColunmnX_BYV;
        private DataGridViewTextBoxColumn ColumnFx_BYV;
    }
}
