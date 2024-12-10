using Tyuiu.BushlyaYaV.Sprint6.Task7.V29.Lib;
namespace Tyuiu.BushlyaYaV.Sprint6.Task7.V29
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
            openFileDialog1.Filter = "Значения, разделённые запятыми (*csv)|*.csv|Все файлы(*.*)|*.*";
            openFileDialog1.Filter = "Значения, разделённые запятыми (*csv)|*.csv|Все файлы(*.*)|*.*";
        }
        static int rows;
        static int colums;
        static string openFilePath;

        DataService ds = new DataService();

        public static int[,] LoadFromFileData(string filePath)
        {
            string filedata = File.ReadAllText(filePath);
            filedata = filedata.Replace('\n', '\r');
            string[] lines = filedata.Split(new char[] { '\r' }, StringSplitOptions.RemoveEmptyEntries);

            rows = lines.Length;
            colums = lines[0].Split(';').Length;

            int[,] arrayValues = new int[rows, colums];
            for (int r = 0; r < rows; r++)
            {
                string[] line_r = lines[r].Split(';');
                for (int c = 0; c < colums; c++)
                {
                    arrayValues[r, c] = Convert.ToInt32(line_r[c]);
                }
            }
            return arrayValues;

        }

        private void buttonLoad_PNE_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            openFilePath = openFileDialog1.FileName;

            int[,] arrayValues = new int[rows, colums];

            arrayValues = LoadFromFileData(openFilePath);

            dataGridView1.ColumnCount = colums;
            dataGridView1.RowCount = rows;

            dataGridView2.ColumnCount = colums;
            dataGridView2.RowCount = rows;

            for (int i = 0; i < colums; i++)
            {
                dataGridView1.Columns[i].Width = 25;
                dataGridView2.Columns[i].Width = 25;
            }

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < colums; c++)
                {
                    dataGridView1.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
                arrayValues = ds.GetMatrix(LoadFromFileData(openFilePath));
                button2.Enabled = true;
            }
        }
            private void button2_Click(object sender, EventArgs e)
        {
            int[,] arrayValues = new int[rows, colums];
            arrayValues = ds.GetMatrix(LoadFromFileData(openFilePath));

            for (int r = 0; r < rows; r++)
            {
                for (int c = 0; c < colums; c++)
                {
                    dataGridView2.Rows[r].Cells[c].Value = arrayValues[r, c];
                }
            }
            button3.Enabled = true;
        }


        private void button3_Click(object sender, EventArgs e)
        {
            saveFileDialog1.FileName = "OutPutFileTask7V29.csv";
            saveFileDialog1.InitialDirectory = Directory.GetCurrentDirectory();
            saveFileDialog1.ShowDialog();

            string path = saveFileDialog1.FileName;

            FileInfo fileinfo = new FileInfo(path);
            bool fileExists = fileinfo.Exists;

            if (fileExists)
            {
                File.Delete(path);
            }

            int rows = dataGridView2.RowCount;
            int columns = dataGridView2.ColumnCount;

            string str = "";
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (j != columns - 1)
                    {
                        str = str + dataGridView2.Rows[i].Cells[j].Value + ";";
                    }
                    else
                    {
                        str = str + dataGridView2.Rows[i].Cells[j].Value;
                    }
                }
                File.AppendAllText(path, str + Environment.NewLine);
                str = "";
            }
        }


        private void button4_Click(object sender, EventArgs e)
        {
            FormAbout fa = new FormAbout();
            fa.ShowDialog();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = 50;
            dataGridView2.ColumnCount = 50;

            dataGridView2.RowCount = 50;
            dataGridView1.RowCount = 50;
            panel3.Width = this.Width / 2;
            panel4.Width = this.Width / 2;
        }


























    }












}
