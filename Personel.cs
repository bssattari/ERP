namespace ERP;

public partial class Personel : Form
{
    public Personel()
    {
    
        InitializeComponent();
        btnMain.Click+=btnMain_Click;
    }

    private void btnMain_Click(object? sender, EventArgs e)
    {
        Main mainform=new Main();
        mainform.Show();
        this.Close();
    }
}
