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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAbout));
            buttonOK_BYV = new Button();
            label1 = new Label();
            SuspendLayout();
            // 
            // buttonOK_BYV
            // 
            buttonOK_BYV.Location = new Point(401, 131);
            buttonOK_BYV.Name = "buttonOK_BYV";
            buttonOK_BYV.Size = new Size(75, 23);
            buttonOK_BYV.TabIndex = 0;
            buttonOK_BYV.Text = "ОК";
            buttonOK_BYV.UseVisualStyleBackColor = true;
            buttonOK_BYV.Click += buttonOK_BYV_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(43, 9);
            label1.Name = "label1";
            label1.Size = new Size(293, 165);
            label1.TabIndex = 1;
            label1.Text = resources.GetString("label1.Text");
            label1.Click += label1_Click;
            // 
            // FormAbout
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(488, 166);
            Controls.Add(label1);
            Controls.Add(buttonOK_BYV);
            Name = "FormAbout";
            Text = "FormAbout";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonOK_BYV;
        private Label label1;
    }
}