namespace ERP;

partial class Main
{
    /// <summary>
    ///  Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    ///  Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if (disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    ///  Required method for Designer support - do not modify
    ///  the contents of this method with the code editor.
    /// </summary>
    Button btnPersonel = new Button();
    Button btnUrun = new Button();
    Button btnClose = new Button();
    Panel panelButtons = new Panel();
    Panel sizedBox = new Panel();
    Panel verticalSeparter = new Panel();

    private void InitializeComponent()
    {
        this.components = new System.ComponentModel.Container();
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.ClientSize = new System.Drawing.Size(450, 450);
        this.MaximizeBox = false;
        this.Text = "ERP -. Ana sayfa";
        this.Controls.Add(panelButtons);
        this.Controls.Add(btnPersonel);
        this.Controls.Add(btnUrun);
        this.Controls.Add(btnClose);
        this.Dock = DockStyle.Top;
        this.Padding = new Padding(10);


        //panelButtons.BackColor = Color.Aqua;
        panelButtons.Dock = DockStyle.Fill;
        panelButtons.Padding = new Padding(10);
        panelButtons.Controls.Add(btnPersonel);
        panelButtons.Controls.Add(verticalSeparter);
        panelButtons.Controls.Add(btnUrun);
        panelButtons.Controls.Add(btnClose);
        panelButtons.Controls.Add(verticalSeparter);
        panelButtons.Controls.Add(sizedBox);


        sizedBox.Height = 100;
        //sizedBox.Height=panelButtons.Height/3;
        sizedBox.Dock = DockStyle.Top;
        verticalSeparter.Height = 5;
        verticalSeparter.Dock = DockStyle.Top;

        btnPersonel.Text = " Personel islemleri";
        btnPersonel.Font = new Font("Arial", 12);
        btnPersonel.Dock = DockStyle.Top;
        btnPersonel.Height = 50;
        // btnPersonel.Padding=new Padding(0);

        btnUrun.Text = " Urun islemleri";
        btnUrun.Font = new Font("Arial", 12);
        btnUrun.Dock = DockStyle.Top;
        btnUrun.Height = 50;

        btnClose.Text = " Cikis";
        btnClose.Font = new Font("Arial", 12);
        btnClose.Dock = DockStyle.Top;
        btnClose.Height = 50;


    }

    #endregion
}
