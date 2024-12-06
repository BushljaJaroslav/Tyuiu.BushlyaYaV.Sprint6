
using Tyuiu.BushlyaYaV.Sprint6.Task1.V7.Lib;
namespace Tyuiu.BushlyaYaV.Sprint6.Task1.V7
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
                int startStep = Convert.ToInt32(textBoxStartStep_BYV.Text);
                int stopStep = Convert.ToInt32(textBoxStopStep_BYV.Text);

                string strLine;

                int len = ds.GetMassFunction(startStep, stopStep).Length;

                double[] valueArray;
                valueArray = new double[len];

                valueArray = ds.GetMassFunction(startStep, stopStep);
                textBoxResult_BYV.Text = "";
                textBoxResult_BYV.AppendText("+----------+----------+" + Environment.NewLine);
                textBoxResult_BYV.AppendText("|    X     |    f(x)  |" + Environment.NewLine);
                textBoxResult_BYV.AppendText("+----------+----------+" + Environment.NewLine);

                for (int i = 0; i <= len - 1; i++)
                {
                    strLine = String.Format("|{0,5:d}      |   {1, 5:f2}   |", startStep, valueArray[i]);
                    textBoxResult_BYV.AppendText(strLine + Environment.NewLine);
                    startStep++;
                }

                textBoxResult_BYV.AppendText("+----------+----------+" + Environment.NewLine);

            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
            private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 0 выполнил студент ИСТНб-24-1 Бушля Ярослав Владимирович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }



    }
    
}
