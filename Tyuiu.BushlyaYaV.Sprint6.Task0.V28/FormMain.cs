using Tyuiu.BushlyaYaV.Sprint6.Task0.V28.Lib;
namespace Tyuiu.BushlyaYaV.Sprint6.Task0.V28
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        private void buttonDone_CLick(object sender, EventArgs e)
        {
            DataService ds = new DataService();
            try
            {
                textBoxOutputRes_BYV.Text = Convert.ToString(ds.Calculate(Convert.ToInt32(textBoxInput_BYV.Text)));
            }
            catch
            {
                MessageBox.Show("Введены неверные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void textBoxInput_BYV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar <= 47 || e.KeyChar >= 58) && (e.KeyChar != '.') && (e.KeyChar != 8))
            {
                e.Handled = true;
            }
        }
        private void buttonHelp_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 0 выполнил студент ИСТНб-24-1 Бушля Ярослав Владимирович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


    }   
}
