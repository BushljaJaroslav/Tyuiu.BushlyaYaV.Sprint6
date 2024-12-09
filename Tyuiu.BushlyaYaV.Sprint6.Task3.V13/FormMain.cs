
using Tyuiu.BushlyaYaV.Sprint6.Task3.V13.Lib;

namespace Tyuiu.BushlyaYaV.Sprint6.Task3.V13
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }
        DataService ds = new DataService();

        int[,] matrix = new int[5, 5] { { -7, 34, -2, 25, 5 },
                                        { -16, -12, 30, -3, 17 },
                                        { 3, -15, 12, 5, -5 },
                                        { 17, 22, -3, 32, -11 },
                                        { 9, 28, 1, -9, -2 } };


        private void FormMain_Load(object sender, EventArgs e)
        {
            int rows = matrix.GetUpperBound(0) + 1;
            int columns = matrix.Length / rows;

            dataGridViewMatrix_BYV.ColumnCount = columns;
            dataGridViewMatrix_BYV.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewMatrix_BYV.Columns[i].Width = 25;
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewMatrix_BYV.Rows[i].Cells[j].Value = Convert.ToString(matrix[i, j]);
                }
            }
        }

        private void buttonDone_BYV_Click(object sender, EventArgs e)
        {
            int[,] newMatrix = ds.Calculate(matrix);
            int rows = newMatrix.GetUpperBound(0) + 1;
            int columns = newMatrix.Length / rows;

            dataGridViewRes_BYV.ColumnCount = columns;
            dataGridViewRes_BYV.RowCount = rows;

            for (int i = 0; i < columns; i++)
            {
                dataGridViewRes_BYV.Columns[i].Width = 25;
            }

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    dataGridViewRes_BYV.Rows[i].Cells[j].Value = Convert.ToString(newMatrix[i, j]);
                }
            }
        }

        private void buttonHelp_BYV_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Таск 3 выполнил студент группы ИСТНб-24-1 Бушля Ярослав Владимирович", "Сообщение", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

    }
}
