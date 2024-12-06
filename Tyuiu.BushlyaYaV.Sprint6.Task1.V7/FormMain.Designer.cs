namespace Tyuiu.BushlyaYaV.Sprint6.Task1.V7
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
            textBoxStart_BYV = new TextBox();
            textBoxStop_BYV = new TextBox();
            textBoxStartStep_BYV = new TextBox();
            textBoxStopStep_BYV = new TextBox();
            buttonHelp_BYV = new Button();
            buttonDone_BYV = new Button();
            groupBoxResult_BYV = new GroupBox();
            textBoxDone_BYV = new TextBox();
            textBoxResult_BYV = new TextBox();
            groupBoxUslovie_BYV.SuspendLayout();
            groupBoxZnach_BYV.SuspendLayout();
            groupBoxResult_BYV.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxUslovie_BYV
            // 
            groupBoxUslovie_BYV.Controls.Add(textBoxUslovie_BYV);
            groupBoxUslovie_BYV.Location = new Point(12, 12);
            groupBoxUslovie_BYV.Name = "groupBoxUslovie_BYV";
            groupBoxUslovie_BYV.Size = new Size(526, 287);
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
            textBoxUslovie_BYV.Size = new Size(488, 107);
            textBoxUslovie_BYV.TabIndex = 0;
            textBoxUslovie_BYV.Text = "Протабулировать функцию на заданном диапозоне.\r\nРезультат вывести в виде таблицы.\r\n";
            // 
            // groupBoxZnach_BYV
            // 
            groupBoxZnach_BYV.Controls.Add(textBoxStopStep_BYV);
            groupBoxZnach_BYV.Controls.Add(textBoxStartStep_BYV);
            groupBoxZnach_BYV.Controls.Add(textBoxStop_BYV);
            groupBoxZnach_BYV.Controls.Add(textBoxStart_BYV);
            groupBoxZnach_BYV.Location = new Point(12, 335);
            groupBoxZnach_BYV.Name = "groupBoxZnach_BYV";
            groupBoxZnach_BYV.Size = new Size(310, 103);
            groupBoxZnach_BYV.TabIndex = 1;
            groupBoxZnach_BYV.TabStop = false;
            groupBoxZnach_BYV.Text = "Ввод данных";
            // 
            // textBoxStart_BYV
            // 
            textBoxStart_BYV.BackColor = Color.Gainsboro;
            textBoxStart_BYV.Location = new Point(33, 33);
            textBoxStart_BYV.Name = "textBoxStart_BYV";
            textBoxStart_BYV.Size = new Size(100, 23);
            textBoxStart_BYV.TabIndex = 2;
            textBoxStart_BYV.Text = "Старт шага:";
            // 
            // textBoxStop_BYV
            // 
            textBoxStop_BYV.BackColor = Color.Gainsboro;
            textBoxStop_BYV.Location = new Point(170, 33);
            textBoxStop_BYV.Name = "textBoxStop_BYV";
            textBoxStop_BYV.Size = new Size(100, 23);
            textBoxStop_BYV.TabIndex = 3;
            textBoxStop_BYV.Text = "Конец шага:";
            // 
            // textBoxStartStep_BYV
            // 
            textBoxStartStep_BYV.Location = new Point(33, 62);
            textBoxStartStep_BYV.Name = "textBoxStartStep_BYV";
            textBoxStartStep_BYV.Size = new Size(100, 23);
            textBoxStartStep_BYV.TabIndex = 2;
            // 
            // textBoxStopStep_BYV
            // 
            textBoxStopStep_BYV.Location = new Point(170, 62);
            textBoxStopStep_BYV.Name = "textBoxStopStep_BYV";
            textBoxStopStep_BYV.Size = new Size(100, 23);
            textBoxStopStep_BYV.TabIndex = 4;
            // 
            // buttonHelp_BYV
            // 
            buttonHelp_BYV.BackColor = SystemColors.ActiveCaption;
            buttonHelp_BYV.Location = new Point(339, 368);
            buttonHelp_BYV.Name = "buttonHelp_BYV";
            buttonHelp_BYV.Size = new Size(90, 52);
            buttonHelp_BYV.TabIndex = 2;
            buttonHelp_BYV.Text = "Справка";
            buttonHelp_BYV.UseVisualStyleBackColor = false;
            // 
            // buttonDone_BYV
            // 
            buttonDone_BYV.BackColor = Color.Green;
            buttonDone_BYV.Location = new Point(444, 368);
            buttonDone_BYV.Name = "buttonDone_BYV";
            buttonDone_BYV.Size = new Size(94, 52);
            buttonDone_BYV.TabIndex = 3;
            buttonDone_BYV.Text = "Выполнить";
            buttonDone_BYV.UseVisualStyleBackColor = false;
            buttonDone_BYV.Click += new System.EventHandler(this.buttonDone_Click);
            // 
            // groupBoxResult_BYV
            // 
            groupBoxResult_BYV.Controls.Add(textBoxResult_BYV);
            groupBoxResult_BYV.Controls.Add(textBoxDone_BYV);
            groupBoxResult_BYV.Location = new Point(558, 12);
            groupBoxResult_BYV.Name = "groupBoxResult_BYV";
            groupBoxResult_BYV.Size = new Size(230, 426);
            groupBoxResult_BYV.TabIndex = 4;
            groupBoxResult_BYV.TabStop = false;
            groupBoxResult_BYV.Text = "Вывод данных";
            // 
            // textBoxDone_BYV
            // 
            textBoxDone_BYV.Location = new Point(6, 22);
            textBoxDone_BYV.Name = "textBoxDone_BYV";
            textBoxDone_BYV.Size = new Size(103, 23);
            textBoxDone_BYV.TabIndex = 0;
            textBoxDone_BYV.Text = "Результат:";
            // 
            // textBoxResult_BYV
            // 
            textBoxResult_BYV.BackColor = SystemColors.MenuBar;
            textBoxResult_BYV.Location = new Point(0, 56);
            textBoxResult_BYV.Multiline = true;
            textBoxResult_BYV.Name = "textBoxResult_BYV";
            textBoxResult_BYV.ScrollBars = ScrollBars.Vertical;
            textBoxResult_BYV.Size = new Size(230, 341);
            textBoxResult_BYV.TabIndex = 1;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(groupBoxResult_BYV);
            Controls.Add(buttonDone_BYV);
            Controls.Add(buttonHelp_BYV);
            Controls.Add(groupBoxZnach_BYV);
            Controls.Add(groupBoxUslovie_BYV);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 1 | Вариант 7 | Бушля Я. В.";
            groupBoxUslovie_BYV.ResumeLayout(false);
            groupBoxUslovie_BYV.PerformLayout();
            groupBoxZnach_BYV.ResumeLayout(false);
            groupBoxZnach_BYV.PerformLayout();
            groupBoxResult_BYV.ResumeLayout(false);
            groupBoxResult_BYV.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxUslovie_BYV;
        private TextBox textBoxUslovie_BYV;
        private GroupBox groupBoxZnach_BYV;
        private TextBox textBoxStop_BYV;
        private TextBox textBoxStart_BYV;
        private TextBox textBoxStopStep_BYV;
        private TextBox textBoxStartStep_BYV;
        private Button buttonHelp_BYV;
        private Button buttonDone_BYV;
        private GroupBox groupBoxResult_BYV;
        private TextBox textBoxDone_BYV;
        private TextBox textBoxResult_BYV;
    }
}
