namespace Tyuiu.BushlyaYaV.Sprint6.Task6.V8
{
    partial class FormAbout
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelInfo_BYV = new Label();
            buttonOK_BYV = new Button();
            SuspendLayout();
            // 
            // labelInfo_BYV
            // 
            labelInfo_BYV.AutoSize = true;
            labelInfo_BYV.Location = new Point(12, 9);
            labelInfo_BYV.Name = "labelInfo_BYV";
            labelInfo_BYV.Size = new Size(436, 90);
            labelInfo_BYV.TabIndex = 0;
            labelInfo_BYV.Text = "Программа для выполнения задачи Спринт 6 | Таск 6 | Вариант 8 | Бушля Я. В.\r\n\r\nВерсия: 1.0\r\n\r\nАвтор: Бушля Я. В.\r\n\r\n";
            labelInfo_BYV.Click += labelInfo_BYV_Click;
            // 
            // buttonOK_BYV
            // 
            buttonOK_BYV.Location = new Point(469, 126);
            buttonOK_BYV.Name = "buttonOK_BYV";
            buttonOK_BYV.Size = new Size(67, 31);
            buttonOK_BYV.TabIndex = 1;
            buttonOK_BYV.Text = "OK";
            buttonOK_BYV.UseVisualStyleBackColor = true;
            buttonOK_BYV.Click += buttonOK_BYV_Click;
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(565, 169);
            Controls.Add(buttonOK_BYV);
            Controls.Add(labelInfo_BYV);
            Name = "FormAbout";
            Text = "FormAbout";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label labelInfo_BYV;
        private Button buttonOK_BYV;
    }
}