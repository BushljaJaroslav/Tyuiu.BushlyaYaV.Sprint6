namespace Tyuiu.BushlyaYaV.Sprint6.Task0.V28
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            groupBoxTask_BYV = new GroupBox();
            textBoxTask_BYV = new TextBox();
            pictureBoxFormula_BYV = new PictureBox();
            groupBoxInput_BYV = new GroupBox();
            labelVarX_BYV = new Label();
            textBoxInput_BYV = new TextBox();
            groupBoxOutput_BYV = new GroupBox();
            groupBoxOutputRes_BYV = new GroupBox();
            textBoxOutputRes_BYV = new TextBox();
            buttonHelp_BYV = new Button();
            buttonDoRes_BYV = new Button();
            groupBoxTask_BYV.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula_BYV).BeginInit();
            groupBoxInput_BYV.SuspendLayout();
            groupBoxOutput_BYV.SuspendLayout();
            groupBoxOutputRes_BYV.SuspendLayout();
            SuspendLayout();
            // 
            // groupBoxTask_BYV
            // 
            groupBoxTask_BYV.Controls.Add(pictureBoxFormula_BYV);
            groupBoxTask_BYV.Controls.Add(textBoxTask_BYV);
            groupBoxTask_BYV.Location = new Point(12, 12);
            groupBoxTask_BYV.Name = "groupBoxTask_BYV";
            groupBoxTask_BYV.Size = new Size(547, 182);
            groupBoxTask_BYV.TabIndex = 0;
            groupBoxTask_BYV.TabStop = false;
            groupBoxTask_BYV.Text = "Условие";
            // 
            // textBoxTask_BYV
            // 
            textBoxTask_BYV.BackColor = SystemColors.ButtonFace;
            textBoxTask_BYV.BorderStyle = BorderStyle.None;
            textBoxTask_BYV.ForeColor = SystemColors.ActiveCaptionText;
            textBoxTask_BYV.Location = new Point(6, 22);
            textBoxTask_BYV.Multiline = true;
            textBoxTask_BYV.Name = "textBoxTask_BYV";
            textBoxTask_BYV.Size = new Size(295, 79);
            textBoxTask_BYV.TabIndex = 0;
            textBoxTask_BYV.Text = "Вычислить значение выражения при x = 3.\r\nОкруглить значение до трех знаков после запятой\r\n";
            // 
            // pictureBoxFormula_BYV
            // 
            pictureBoxFormula_BYV.Image = (Image)resources.GetObject("pictureBoxFormula_BYV.Image");
            pictureBoxFormula_BYV.Location = new Point(6, 118);
            pictureBoxFormula_BYV.Name = "pictureBoxFormula_BYV";
            pictureBoxFormula_BYV.Size = new Size(295, 33);
            pictureBoxFormula_BYV.TabIndex = 1;
            pictureBoxFormula_BYV.TabStop = false;
            // 
            // groupBoxInput_BYV
            // 
            groupBoxInput_BYV.Controls.Add(textBoxInput_BYV);
            groupBoxInput_BYV.Controls.Add(labelVarX_BYV);
            groupBoxInput_BYV.Location = new Point(12, 207);
            groupBoxInput_BYV.Name = "groupBoxInput_BYV";
            groupBoxInput_BYV.Size = new Size(354, 117);
            groupBoxInput_BYV.TabIndex = 1;
            groupBoxInput_BYV.TabStop = false;
            groupBoxInput_BYV.Text = "Ввод данных";
            // 
            // labelVarX_BYV
            // 
            labelVarX_BYV.AutoSize = true;
            labelVarX_BYV.Location = new Point(116, 38);
            labelVarX_BYV.Name = "labelVarX_BYV";
            labelVarX_BYV.Size = new Size(89, 15);
            labelVarX_BYV.TabIndex = 0;
            labelVarX_BYV.Text = "Переменная X:";
            // 
            // textBoxInput_BYV
            // 
            textBoxInput_BYV.Location = new Point(100, 56);
            textBoxInput_BYV.Name = "textBoxInput_BYV";
            textBoxInput_BYV.Size = new Size(122, 23);
            textBoxInput_BYV.TabIndex = 1;
            textBoxInput_BYV.KeyPress += textBoxInput_BYV_KeyPress;
            // 
            // groupBoxOutput_BYV
            // 
            groupBoxOutput_BYV.Controls.Add(groupBoxOutputRes_BYV);
            groupBoxOutput_BYV.Location = new Point(387, 207);
            groupBoxOutput_BYV.Name = "groupBoxOutput_BYV";
            groupBoxOutput_BYV.Size = new Size(193, 118);
            groupBoxOutput_BYV.TabIndex = 2;
            groupBoxOutput_BYV.TabStop = false;
            groupBoxOutput_BYV.Text = "Вывод данных";
            // 
            // groupBoxOutputRes_BYV
            // 
            groupBoxOutputRes_BYV.Controls.Add(textBoxOutputRes_BYV);
            groupBoxOutputRes_BYV.Location = new Point(9, 36);
            groupBoxOutputRes_BYV.Name = "groupBoxOutputRes_BYV";
            groupBoxOutputRes_BYV.Size = new Size(176, 58);
            groupBoxOutputRes_BYV.TabIndex = 0;
            groupBoxOutputRes_BYV.TabStop = false;
            groupBoxOutputRes_BYV.Text = "Результат";
            // 
            // textBoxOutputRes_BYV
            // 
            textBoxOutputRes_BYV.Location = new Point(41, 21);
            textBoxOutputRes_BYV.Name = "textBoxOutputRes_BYV";
            textBoxOutputRes_BYV.ReadOnly = true;
            textBoxOutputRes_BYV.Size = new Size(87, 23);
            textBoxOutputRes_BYV.TabIndex = 0;
            textBoxOutputRes_BYV.TextChanged += buttonDone_CLick;
            // 
            // buttonHelp_BYV
            // 
            buttonHelp_BYV.Location = new Point(437, 331);
            buttonHelp_BYV.Name = "buttonHelp_BYV";
            buttonHelp_BYV.Size = new Size(30, 27);
            buttonHelp_BYV.TabIndex = 3;
            buttonHelp_BYV.Text = "?";
            buttonHelp_BYV.UseVisualStyleBackColor = true;
            buttonHelp_BYV.Click += buttonHelp_Click;
            // 
            // buttonDoRes_BYV
            // 
            buttonDoRes_BYV.Location = new Point(487, 331);
            buttonDoRes_BYV.Name = "buttonDoRes_BYV";
            buttonDoRes_BYV.Size = new Size(93, 27);
            buttonDoRes_BYV.TabIndex = 4;
            buttonDoRes_BYV.Text = "Выполнить";
            buttonDoRes_BYV.UseVisualStyleBackColor = true;
            buttonDoRes_BYV.Click += buttonDone_CLick;
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(599, 363);
            Controls.Add(buttonDoRes_BYV);
            Controls.Add(buttonHelp_BYV);
            Controls.Add(groupBoxOutput_BYV);
            Controls.Add(groupBoxInput_BYV);
            Controls.Add(groupBoxTask_BYV);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 0 | Вариант 28 | Бушля Я. В.";
            groupBoxTask_BYV.ResumeLayout(false);
            groupBoxTask_BYV.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBoxFormula_BYV).EndInit();
            groupBoxInput_BYV.ResumeLayout(false);
            groupBoxInput_BYV.PerformLayout();
            groupBoxOutput_BYV.ResumeLayout(false);
            groupBoxOutputRes_BYV.ResumeLayout(false);
            groupBoxOutputRes_BYV.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private GroupBox groupBoxTask_BYV;
        private TextBox textBoxTask_BYV;
        private PictureBox pictureBoxFormula_BYV;
        private GroupBox groupBoxInput_BYV;
        private TextBox textBoxInput_BYV;
        private Label labelVarX_BYV;
        private GroupBox groupBoxOutput_BYV;
        private GroupBox groupBoxOutputRes_BYV;
        private TextBox textBoxOutputRes_BYV;
        private Button buttonHelp_BYV;
        private Button buttonDoRes_BYV;
    }
}
