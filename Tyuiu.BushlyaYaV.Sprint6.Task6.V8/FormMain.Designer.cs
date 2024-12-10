namespace Tyuiu.BushlyaYaV.Sprint6.Task6.V8
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            panelTools_BYV = new Panel();
            buttonFormAbaut_BYV = new Button();
            buttonOutput_BYV = new Button();
            buttonFindFile_BYV = new Button();
            panelTask_BYV = new Panel();
            groupBoxTask_BYV = new GroupBox();
            textBoxTask_BYV = new TextBox();
            panelInfo_BYV = new Panel();
            groupBoxInfoExit_BYV = new GroupBox();
            textBoxOut_BYV = new TextBox();
            groupBoxInfoEnter_BYV = new GroupBox();
            textBoxIn_BYV = new TextBox();
            openFileDialogTask_BYV = new OpenFileDialog();
            toolTip1 = new ToolTip(components);
            panelTools_BYV.SuspendLayout();
            panelTask_BYV.SuspendLayout();
            groupBoxTask_BYV.SuspendLayout();
            panelInfo_BYV.SuspendLayout();
            groupBoxInfoExit_BYV.SuspendLayout();
            groupBoxInfoEnter_BYV.SuspendLayout();
            SuspendLayout();
            // 
            // panelTools_BYV
            // 
            panelTools_BYV.BackColor = SystemColors.Control;
            panelTools_BYV.Controls.Add(buttonFormAbaut_BYV);
            panelTools_BYV.Controls.Add(buttonOutput_BYV);
            panelTools_BYV.Controls.Add(buttonFindFile_BYV);
            panelTools_BYV.Dock = DockStyle.Top;
            panelTools_BYV.Location = new Point(0, 0);
            panelTools_BYV.Name = "panelTools_BYV";
            panelTools_BYV.Size = new Size(830, 66);
            panelTools_BYV.TabIndex = 0;
            // 
            // buttonFormAbaut_BYV
            // 
            buttonFormAbaut_BYV.Location = new Point(729, 6);
            buttonFormAbaut_BYV.Name = "buttonFormAbaut_BYV";
            buttonFormAbaut_BYV.Size = new Size(75, 54);
            buttonFormAbaut_BYV.TabIndex = 2;
            buttonFormAbaut_BYV.Text = "button1";
            buttonFormAbaut_BYV.UseVisualStyleBackColor = true;
            // 
            // buttonOutput_BYV
            // 
            buttonOutput_BYV.Location = new Point(117, 6);
            buttonOutput_BYV.Name = "buttonOutput_BYV";
            buttonOutput_BYV.Size = new Size(75, 54);
            buttonOutput_BYV.TabIndex = 1;
            buttonOutput_BYV.Text = "buttonOutput_BYV";
            buttonOutput_BYV.UseVisualStyleBackColor = true;
            // 
            // buttonFindFile_BYV
            // 
            buttonFindFile_BYV.Location = new Point(12, 6);
            buttonFindFile_BYV.Name = "buttonFindFile_BYV";
            buttonFindFile_BYV.Size = new Size(75, 54);
            buttonFindFile_BYV.TabIndex = 0;
            buttonFindFile_BYV.Text = "button1";
            buttonFindFile_BYV.UseVisualStyleBackColor = true;
            // 
            // panelTask_BYV
            // 
            panelTask_BYV.Controls.Add(groupBoxTask_BYV);
            panelTask_BYV.Location = new Point(0, 66);
            panelTask_BYV.Name = "panelTask_BYV";
            panelTask_BYV.Size = new Size(830, 79);
            panelTask_BYV.TabIndex = 1;
            // 
            // groupBoxTask_BYV
            // 
            groupBoxTask_BYV.BackColor = SystemColors.Control;
            groupBoxTask_BYV.Controls.Add(textBoxTask_BYV);
            groupBoxTask_BYV.Dock = DockStyle.Fill;
            groupBoxTask_BYV.Location = new Point(0, 0);
            groupBoxTask_BYV.Name = "groupBoxTask_BYV";
            groupBoxTask_BYV.Size = new Size(830, 79);
            groupBoxTask_BYV.TabIndex = 0;
            groupBoxTask_BYV.TabStop = false;
            groupBoxTask_BYV.Text = "Условие";
            // 
            // textBoxTask_BYV
            // 
            textBoxTask_BYV.BackColor = SystemColors.Control;
            textBoxTask_BYV.BorderStyle = BorderStyle.None;
            textBoxTask_BYV.Dock = DockStyle.Fill;
            textBoxTask_BYV.Location = new Point(3, 19);
            textBoxTask_BYV.Multiline = true;
            textBoxTask_BYV.Name = "textBoxTask_BYV";
            textBoxTask_BYV.ReadOnly = true;
            textBoxTask_BYV.Size = new Size(824, 57);
            textBoxTask_BYV.TabIndex = 0;
            textBoxTask_BYV.Text = resources.GetString("textBoxTask_BYV.Text");
            // 
            // panelInfo_BYV
            // 
            panelInfo_BYV.Controls.Add(groupBoxInfoExit_BYV);
            panelInfo_BYV.Controls.Add(groupBoxInfoEnter_BYV);
            panelInfo_BYV.Location = new Point(0, 145);
            panelInfo_BYV.Name = "panelInfo_BYV";
            panelInfo_BYV.Size = new Size(830, 288);
            panelInfo_BYV.TabIndex = 2;
            // 
            // groupBoxInfoExit_BYV
            // 
            groupBoxInfoExit_BYV.Controls.Add(textBoxOut_BYV);
            groupBoxInfoExit_BYV.Dock = DockStyle.Right;
            groupBoxInfoExit_BYV.Location = new Point(411, 0);
            groupBoxInfoExit_BYV.Name = "groupBoxInfoExit_BYV";
            groupBoxInfoExit_BYV.Size = new Size(419, 288);
            groupBoxInfoExit_BYV.TabIndex = 1;
            groupBoxInfoExit_BYV.TabStop = false;
            groupBoxInfoExit_BYV.Text = "Вывод";
            // 
            // textBoxOut_BYV
            // 
            textBoxOut_BYV.Dock = DockStyle.Fill;
            textBoxOut_BYV.Location = new Point(3, 19);
            textBoxOut_BYV.Multiline = true;
            textBoxOut_BYV.Name = "textBoxOut_BYV";
            textBoxOut_BYV.ScrollBars = ScrollBars.Vertical;
            textBoxOut_BYV.Size = new Size(413, 266);
            textBoxOut_BYV.TabIndex = 0;
            // 
            // groupBoxInfoEnter_BYV
            // 
            groupBoxInfoEnter_BYV.Controls.Add(textBoxIn_BYV);
            groupBoxInfoEnter_BYV.Dock = DockStyle.Left;
            groupBoxInfoEnter_BYV.Location = new Point(0, 0);
            groupBoxInfoEnter_BYV.Name = "groupBoxInfoEnter_BYV";
            groupBoxInfoEnter_BYV.Size = new Size(399, 288);
            groupBoxInfoEnter_BYV.TabIndex = 0;
            groupBoxInfoEnter_BYV.TabStop = false;
            groupBoxInfoEnter_BYV.Text = "Ввод";
            // 
            // textBoxIn_BYV
            // 
            textBoxIn_BYV.Dock = DockStyle.Fill;
            textBoxIn_BYV.Location = new Point(3, 19);
            textBoxIn_BYV.Multiline = true;
            textBoxIn_BYV.Name = "textBoxIn_BYV";
            textBoxIn_BYV.ScrollBars = ScrollBars.Vertical;
            textBoxIn_BYV.Size = new Size(393, 266);
            textBoxIn_BYV.TabIndex = 0;
            // 
            // openFileDialogTask_BYV
            // 
            openFileDialogTask_BYV.FileName = "openFileDialog1";
            // 
            // FormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(830, 432);
            Controls.Add(panelInfo_BYV);
            Controls.Add(panelTask_BYV);
            Controls.Add(panelTools_BYV);
            MinimumSize = new Size(846, 471);
            Name = "FormMain";
            Text = "Спринт 6 | Таск 6 | Вариант 8 | Бушля Я. В.";
            panelTools_BYV.ResumeLayout(false);
            panelTask_BYV.ResumeLayout(false);
            groupBoxTask_BYV.ResumeLayout(false);
            groupBoxTask_BYV.PerformLayout();
            panelInfo_BYV.ResumeLayout(false);
            groupBoxInfoExit_BYV.ResumeLayout(false);
            groupBoxInfoExit_BYV.PerformLayout();
            groupBoxInfoEnter_BYV.ResumeLayout(false);
            groupBoxInfoEnter_BYV.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelTools_BYV;
        private Panel panelTask_BYV;
        private GroupBox groupBoxTask_BYV;
        private TextBox textBoxTask_BYV;
        private Panel panelInfo_BYV;
        private GroupBox groupBoxInfoEnter_BYV;
        private GroupBox groupBoxInfoExit_BYV;
        private TextBox textBoxOut_BYV;
        private TextBox textBoxIn_BYV;
        private Button buttonFindFile_BYV;
        private Button buttonFormAbaut_BYV;
        private Button buttonOutput_BYV;
        private OpenFileDialog openFileDialogTask_BYV;
        private ToolTip toolTip1;
    }
}
