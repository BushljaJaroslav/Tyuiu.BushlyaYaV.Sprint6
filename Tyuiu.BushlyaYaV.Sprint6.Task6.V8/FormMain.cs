


namespace Tyuiu.BushlyaYaV.Sprint6.Task6.V8;

public partial class FormMain : Form
{
    public FormMain()
    {
        InitializeComponent();
    }

    private void buttonFileExpress_BYV_Click(object sender, EventArgs e)
    {
        openFileDialogTask.ShowDialog();
        openFilePath = openFileDialogTask.FileName;
        textBoxInputData_BYV.Text = File.ReadAllText(openFilePath);
        groupBoxInput_ZAR.Text = groupBoxInput_BYV.Text + " " + openFileDialogTask.FileName;
        buttonFile_BYV.Enabled = true;
    }

    private void buttonFile_BYV_Click(object sender, EventArgs e)
    {
        textBoxOut.Text = ds.CollectTextFromFile(openFilePath);
    }

    private void buttonHelp_BYV_Click(object sender, EventArgs e)
    {
        FormAbout formAbout = new FormAbout();
        formAbout.ShowDialog();
    }
}

