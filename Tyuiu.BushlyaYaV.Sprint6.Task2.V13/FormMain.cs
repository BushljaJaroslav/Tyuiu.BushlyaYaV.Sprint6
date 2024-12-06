
using System.Windows.Forms.VisualStyles;
using Tyuiu.BushlyaYaV.Sprint6.Task2.V13.Lib;

namespace Tyuiu.BushlyaYaV.Sprint6.Task2.V13
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();
        private void buttonDone_Click(object sender, EventArgs e)
        {
            try
            {
                int startStep = Convert.ToInt32(textBoxStart_BYV.Text);
                int stopStep = Convert.ToInt32(textBoxStop_BYV.Text);

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startStep, stopStep);
                this.chartFunction.Titles.Add("График функции");

                this.chartFunction.ChartAreas[0].AxisX.Title = "Ось X";
                this.chartFunction.ChartAreas[0].AxisX.Title = "Ось Y";
                for (int i = 0; i <= len - 1; i++)
                {
                    this.dataGridViewResult_BYV.Rows.Add(Convert.ToString(startStep), Convert.ToString(valueArray[i]));
                    this.chartFunction.Series[0].Points.AddXY(startStep, valueArray[i]);
                    startStep++;
                }
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDone_BYV_MouseEnter(object sender, EventArgs e)
        {
            buttonDone_BYV.BackColor = Color.Red;
        }

        private void buttonDone_BYV_MouseLeave(object sender, EventArgs e)
        {
            buttonDone_BYV.BackColor = Color.Green;
        }

        private void buttonDone_BYV_MouseDown(object sender, MouseEventArgs e)
        {
            buttonDone_BYV.BackColor = Color.Blue;
        }

        private void buttonHelp_BYV_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 2 выполнил студент группы ПКТб-24-1 Осадец Александр Александрович", "Сообщение");
        }
    }
}
