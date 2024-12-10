
using Tyuiu.BushlyaYaV.Sprint6.Task5.V16.Lib;

namespace Tyuiu.BushlyaYaV.Sprint6.Task5.V16
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        private void buttonHelp_BYV_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 5 выполнил студент группы ИСТНб-24-1 Бушля Ярослав Владимирович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        DataService ds = new DataService();
        string path = @"C:\DataSprint5\InPutDataFileTask5V16.txt";

        private void buttonDone_BYV_Click(object sender, EventArgs e)
        {
            dataGridViewResult_BYV.ColumnCount = 2;
            dataGridViewResult_BYV.Columns[0].Width = 20;
            dataGridViewResult_BYV.Columns[1].Width = 50;

            this.chartFunction_BYV.ChartAreas[0].AxisX.Title = "Ось X";
            this.chartFunction_BYV.ChartAreas[0].AxisY.Title = "Ось Y";

            chartFunction_BYV.Series[0].Points.Clear();

            double[] numsMass = new double[ds.len];

            numsMass = ds.LoadFromDataFile(path);

            for (int i = 0; i < numsMass.Length; i++)
            {
                dataGridViewResult_BYV.Rows.Add(Convert.ToString(i), Convert.ToString(numsMass[i]));
                chartFunction_BYV.Series[0].Points.AddXY(i, numsMass[i]);
            }
        }

        private void buttonOpenFile_BYV_Click(object sender, EventArgs e)
        {
            System.Diagnostics.Process txt = new System.Diagnostics.Process();
            txt.StartInfo.FileName = "notepad.exe";
            txt.StartInfo.Arguments = path;
            txt.Start();
        }
    }
}
