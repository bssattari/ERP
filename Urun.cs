namespace ERP;

public partial class Urun : Form
{
    public Urun()
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
