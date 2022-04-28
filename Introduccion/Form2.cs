using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Introduccion;

public partial class Form2 : Form
{
    public Label lblMensaje;
    public CheckBox MXM;
    public CheckBox USD;
    public CheckBox CAD;
    public CheckBox EUR;
    public CheckBox JPY;
    public Boolean MXMestatus = false;
    public Boolean USDestatus = false;
    public Boolean CADestatus = false;
    public Boolean EURestatus = false;
    public Boolean JPYestatus = false;
    public string _valorEscogido;

    private Button btnCerrar;
    public Form2(string valorEscogido)
    {
        this._valorEscogido = valorEscogido;
        lblMensaje = new Label();
        btnCerrar = new Button();
        InitializeComponent();
        inicializarComponentes();  
    }

    private void inicializarComponentes()
    {
        this.Size = new Size(300, 230);
        lblMensaje.Text = "";
        lblMensaje.AutoSize = true;
        lblMensaje.Location = new Point(80, 80);
        //Boton Cerrar
        btnCerrar.Text = "Cerrar";
        btnCerrar.AutoSize = true;
        btnCerrar.Location = new Point(100, 160);
        btnCerrar.Click += new EventHandler(btnCerrarVentana_Click);
        //MXM
        MXM = new CheckBox();
        MXM.AutoSize = true;
        MXM.Location = new Point(10, 10);
        MXM.Text = ("MXN - Peso mexicano");
        
        if (_valorEscogido != "MXM") 
        {
            this.Controls.Add(MXM);
        }
        //USD
        USD = new CheckBox();
        USD.AutoSize = true;
        USD.Location = new Point(10, 40);
        USD.Text = ("USD - Dólar estadounidense");
        
        if (_valorEscogido != "USD")
        {
            this.Controls.Add(USD);
        }

        //CAD
        CAD = new CheckBox();
        CAD.AutoSize = true;
        CAD.Location = new Point(10, 70);
        CAD.Text = ("CAD - Dólar canadiense");
        
        if (_valorEscogido != "CAD")
        {
            this.Controls.Add(CAD);
        }
        //EUR
        EUR = new CheckBox();
        EUR.AutoSize = true;
        EUR.Location = new Point(10, 100);
        EUR.Text = ("EUR - Euro");
        
        if (_valorEscogido != "EUR")
        {
            this.Controls.Add(EUR);
        }

        //JPY
        JPY = new CheckBox();
        JPY.AutoSize = true;
        JPY.Location = new Point(10, 130);
        JPY.Text = ("JPY - Yen japonés");
        
        if (_valorEscogido != "JPY")
        {
            this.Controls.Add(JPY);
        }
        
        this.Controls.Add(lblMensaje);
        this.Controls.Add(btnCerrar);
        
        
        
    }

    private void btnCerrarVentana_Click(Object sender, EventArgs e)
    {
        
        this.DialogResult = DialogResult.OK;
        this.Close();
    }

    

}
