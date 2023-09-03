namespace ERP;

public partial class Main : Form
{
    public Main()
    {
        InitializeComponent();
        btnUrun.Click += btnUrun_Click;
        btnPersonel.Click += btnPersonel_Clik;
        btnClose.Click += bbtnClose_Clik;
    }

    private void btnPersonel_Clik(object? sender, EventArgs e)
    {
        Personel personelform = new Personel();
        personelform.Show();
        this.Hide();
        // MessageBox.Show(" Personel islemleri Butonuna Tiklandi");

    }

    private void btnUrun_Click(object? sender, EventArgs e)
    {
        Urun urunForm = new Urun();
        urunForm.Show();
        this.Hide();
        // MessageBox.Show(" Urun islemleri Butonuna Tiklandi");
    }
    private void bbtnClose_Clik(object? sender, EventArgs e)
    {

        this.Close();
        // MessageBox.Show(" Personel islemleri Butonuna Tiklandi");

    }
}
