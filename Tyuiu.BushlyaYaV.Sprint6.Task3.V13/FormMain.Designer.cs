namespace Tyuiu.BushlyaYaV.Sprint6.Task3.V13
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
            groupBoxCon_BYV = new GroupBox();
            textBoxCon_BYV = new TextBox();
            dataGridViewMatrix_BYV = new DataGridView();
            groupBoxResult_BYV = new GroupBox();
            dataGridViewRes_BYV = new DataGridView();
            buttonHelp_BYV = new Button();
            buttonDone_BYV = new Button();
            groupBoxCon_BYV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatrix_BYV).BeginInit();
            groupBoxResult_BYV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewRes_BYV).BeginInit();
            SuspendLayout();
            // 
            // groupBoxCon_BYV
            // 
            groupBoxCon_BYV.Controls.Add(dataGridViewMatrix_BYV);
            groupBoxCon_BYV.Controls.Add(textBoxCon_BYV);
            groupBoxCon_BYV.Location = new Point(12, 4);
            groupBoxCon_BYV.Name = "groupBoxCon_BYV";
            groupBoxCon_BYV.Size = new Size(374, 293);
            groupBoxCon_BYV.TabIndex = 0;
            groupBoxCon_BYV.TabStop = false;
            groupBoxCon_BYV.Text = "Условие";
            // 
            // textBoxCon_BYV
            // 
            textBoxCon_BYV.BackColor = SystemColors.ButtonFace;
            textBoxCon_BYV.Location = new Point(6, 22);
            textBoxCon_BYV.Multiline = true;
            textBoxCon_BYV.Name = "textBoxCon_BYV";
            textBoxCon_BYV.Size = new Size(198, 265);
            textBoxCon_BYV.TabIndex = 0;
            textBoxCon_BYV.Text = "Дана матрица 5 на 5\r\n-7     34  -2    25  5\r\n-16 -12   30  -3   17\r\n  3  -15    30  -3   17\r\n 17   22  -3    32 -11\r\n  9    28   1    -9  -2\r\nВыполнить сортировку по возрастанию во втором столбце.\r\n";
            // 
            // dataGridViewMatrix_BYV
            // 
            dataGridViewMatrix_BYV.BackgroundColor = SystemColors.Info;
            dataGridViewMatrix_BYV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMatrix_BYV.Location = new Point(210, 22);
            dataGridViewMatrix_BYV.Name = "dataGridViewMatrix_BYV";
            dataGridViewMatrix_BYV.Size = new Size(158, 150);
            dataGridViewMatrix_BYV.TabIndex = 1;
            // 
            // groupBoxResult_BYV
            // 
            groupBoxResult_BYV.Controls.Add(dataGridViewRes_BYV);
            groupBoxResult_BYV.Location = new Point(395, 4);
            groupBoxResult_BYV.Name = "groupBoxResult_BYV";
            groupBoxResult_BYV.Size = new Size(174, 205);
            groupBoxResult_BYV.TabIndex = 1;
            groupBoxResult_BYV.TabStop = false;
            groupBoxResult_BYV.Text = "Вывод";
            // 
            // dataGridViewRes_BYV
            // 
            dataGridViewRes_BYV.BackgroundColor = SystemColors.InactiveCaption;
            dataGridViewRes_BYV.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewRes_BYV.Location = new Point(6, 22);
            dataGridViewRes_BYV.Name = "dataGridViewRes_BYV";
            dataGridViewRes_BYV.Size = new Size(162, 150);
            dataGridViewRes_BYV.TabIndex = 0;
            // 
            // buttonHelp_BYV
            // 
            buttonHelp_BYV.Location = new Point(419, 274);
            buttonHelp_BYV.Name = "buttonHelp_BYV";
            buttonHelp_BYV.Size = new Size(48, 23);
            buttonHelp_BYV.TabIndex = 2;
            buttonHelp_BYV.Text = "?";
            buttonHelp_BYV.UseVisualStyleBackColor = true;
            buttonHelp_BYV.Click += new System.EventHandler(this.buttonHelp_BYV_Click);
            // 
            // buttonDone_BYV
            // 
            buttonDone_BYV.Location = new Point(473, 274);
            buttonDone_BYV.Name = "buttonDone_BYV";
            buttonDone_BYV.Size = new Size(90, 23);
            buttonDone_BYV.TabIndex = 3;
            buttonDone_BYV.Text = "Выполнить";
            buttonDone_BYV.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(577, 309);
            Controls.Add(buttonDone_BYV);
            Controls.Add(buttonHelp_BYV);
            Controls.Add(groupBoxResult_BYV);
            Controls.Add(groupBoxCon_BYV);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 3 | Вариант 13 | Бушля Я. В. ";
            groupBoxCon_BYV.ResumeLayout(false);
            groupBoxCon_BYV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMatrix_BYV).EndInit();
            groupBoxResult_BYV.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewRes_BYV).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxCon_BYV;
        private DataGridView dataGridViewMatrix_BYV;
        private TextBox textBoxCon_BYV;
        private GroupBox groupBoxResult_BYV;
        private DataGridView dataGridViewRes_BYV;
        private Button buttonHelp_BYV;
        private Button buttonDone_BYV;
    }
}
