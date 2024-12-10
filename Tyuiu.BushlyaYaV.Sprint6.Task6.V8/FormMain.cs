
using Tyuiu.BushlyaYaV.Sprint6.Task6.V8.Lib;

namespace Tyuiu.BushlyaYaV.Sprint6.Task6.V8
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();

        private void buttonOutput_BYV_Click(object sender, EventArgs e)
        {
            string path = @"C:\Users\User\source\repos\Tyuiu.KhvorykhVA.Sprint6\Tyuiu.KhvorykhVA.Sprint6.Task6.V8\bin\Debug\net8.0-windows\InPutDataFileTask6V8.txt";
            textBoxOut_BYV.Text = ds.CollectTextFromFile(path);
        }

        private void buttonFormAbout_BYV_Click(object sender, EventArgs e)
        {
            FormAbout formAbout = new FormAbout();
            formAbout.ShowDialog();
        }

        private void buttonFindFile_BYV_Click(object sender, EventArgs e)
        {
            try
            {
                openFileDialogTask_BYV.ShowDialog();
                string openFilePath = openFileDialogTask_BYV.FileName;
                foreach (string line in File.ReadLines(openFilePath))
                {
                    textBoxIn_BYV.AppendText(line + Environment.NewLine);
                }
                groupBoxInfoEnter_BYV.Text += " " + openFilePath;
                buttonOutput_V8.Enabled = true;
            }
            catch
            {
                MessageBox.Show("Ошибка при открытии файла", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }
}
