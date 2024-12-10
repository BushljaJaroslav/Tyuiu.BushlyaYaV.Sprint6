
using Tyuiu.BushlyaYaV.Sprint6.Task6.V8.Lib;

namespace Tyuiu.BushlyaYaV.Sprint6.Task6.V8;

public partial class FormMain : Form
{
    public FormMain()
    {
        InitializeComponent();
    }
    string openFilePath;
    DataService ds = new DataService();

    private void buttonFileExpress_BYV_Click(object sender, EventArgs e)
    {
        openFileDialogTask_BYV.ShowDialog();
        openFilePath = openFileDialogTask_BYV.FileName;
        textBoxInputData_BYV.Text = File.ReadAllText(openFilePath);
        groupBoxInput_BYV.Text = groupBoxInput_BYV.Text + " " + openFileDialogTask_BYV.FileName;
        buttonFile_BYV.Enabled = true;
    }

    private void buttonFile_BYV_Click(object sender, EventArgs e)
    {
        textBoxOutputData_BYV.Text = ds.CollectTextFromFile(openFilePath);
    }

    private void buttonHelp_BYV_Click(object sender, EventArgs e)
    {
        FormAbout formAbout = new FormAbout();
        formAbout.ShowDialog();
    }
}

