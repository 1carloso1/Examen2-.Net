namespace Introduccion;

public partial class Form1 : Form
{
    Label? lblMoneda;
    ComboBox? cmbMonedas;
    Label? lblMonto;
    TextBox? txtMonto;
    Button? btnCalcular;
    public string valorEscogido = "";
    Label? lblConversiones;
    Label? lblMXM;
    Label? lblUSD;
    Label? lblCAD;
    Label? lblEUR;
    Label? lblJPY;
    TextBox? txtMXM;
    TextBox? txtUSD;
    TextBox? txtCAD;
    TextBox? txtEUR;
    TextBox? txtJPY;
    public Boolean MXMestatus;
    public Boolean USDestatus;
    public Boolean CADestatus;
    public Boolean EURestatus;
    public Boolean JPYestatus;



    public Form1()
    {

        InitializeComponent();
        InicializarComponentes();

    }
    private void InicializarComponentes()
    {
        this.Size = new Size(300, 350);
        //Etiqueta "Moneda"
        lblMoneda = new Label();
        lblMoneda.Text = "Moneda";
        lblMoneda.AutoSize = true;
        lblMoneda.Location = new Point(10, 10);
        //Combobox Tipos de monedas
        cmbMonedas = new ComboBox();
        cmbMonedas.Size = new Size(160, 20);
        cmbMonedas.Items.Add("USD - Dólar estadounidense");
        cmbMonedas.Items.Add("MXN - Peso mexicano");
        cmbMonedas.Items.Add("CAD - Dólar canadiense");
        cmbMonedas.Items.Add("EUR - Euro");
        cmbMonedas.Items.Add("JPY - Yen japonés");
        cmbMonedas.SelectedValueChanged += new EventHandler(cmbMonedas_ValueChanged);
        cmbMonedas.Location = new Point(10, 40);
        //Etiqueta "Monto"
        lblMonto = new Label();
        lblMonto.Text = "Monto";
        lblMonto.AutoSize = true;
        lblMonto.Location = new Point(175, 10);
        //TextBox Monto
        txtMonto = new TextBox();
        txtMonto.Text = "";
        txtMonto.Size = new Size(100, 20);
        txtMonto.Location = new Point(175, 40);
        //Boton Calcular
        btnCalcular = new Button();
        btnCalcular.Text = "Calcular";
        btnCalcular.Size = new Size(100, 25);
        btnCalcular.Location = new Point(175, 77);
        btnCalcular.Click += new EventHandler(btnVentana_Click);
        //Etiqueta "Conversiones"
        lblConversiones = new Label();
        lblConversiones.Text = "Conversiones";
        lblConversiones.AutoSize = true;
        lblConversiones.Location = new Point(10, 110);
        //MXM
        lblMXM = new Label();
        lblMXM.Text = "MXN - Peso mexicano";
        lblMXM.AutoSize = true;
        lblMXM.Location = new Point(10, 140);
        lblMXM.Visible = false;
        txtMXM = new TextBox();
        txtMXM.Size = new Size(100, 20);
        txtMXM.Location = new Point(175, 135);
        txtMXM.Visible = false;
        //USD
        lblUSD = new Label();
        lblUSD.Text = "USD - Dólar estadounidense";
        lblUSD.AutoSize = true;
        lblUSD.Location = new Point(10, 170);
        lblUSD.Visible = false;
        txtUSD = new TextBox();
        txtUSD.Size = new Size(100, 20);
        txtUSD.Location = new Point(175, 165);
        txtUSD.Visible = false;
        //CAD
        lblCAD = new Label();
        lblCAD.Text = "CAD - Dólar canadiense";
        lblCAD.AutoSize = true;
        lblCAD.Location = new Point(10, 200);
        lblCAD.Visible = false;
        txtCAD = new TextBox();
        txtCAD.Size = new Size(100, 20);
        txtCAD.Location = new Point(175, 195);
        txtCAD.Visible = false;
        //EUR
        lblEUR = new Label();
        lblEUR.Text = "EUR - Euro";
        lblEUR.AutoSize = true;
        lblEUR.Location = new Point(10, 230);
        lblEUR.Visible = false;
        txtEUR = new TextBox();
        txtEUR.Size = new Size(100, 20);
        txtEUR.Location = new Point(175, 225);
        txtEUR.Visible = false;
        //JPY
        lblJPY = new Label();
        lblJPY.Text = "JPY - Yen japonés";
        lblJPY.AutoSize = true;
        lblJPY.Location = new Point(10, 260);
        lblJPY.Visible = false;
        txtJPY = new TextBox();
        txtJPY.Size = new Size(100, 20);
        txtJPY.Location = new Point(175, 255);
        txtJPY.Visible = false;

        this.Controls.Add(lblMoneda);
        this.Controls.Add(cmbMonedas);
        this.Controls.Add(lblMonto);
        this.Controls.Add(txtMonto);
        this.Controls.Add(btnCalcular);
        this.Controls.Add(lblConversiones);
        this.Controls.Add(lblMXM);
        this.Controls.Add(lblUSD);
        this.Controls.Add(lblCAD);
        this.Controls.Add(lblEUR);
        this.Controls.Add(lblJPY);
        this.Controls.Add(txtMXM);
        this.Controls.Add(txtUSD);
        this.Controls.Add(txtCAD);
        this.Controls.Add(txtEUR);
        this.Controls.Add(txtJPY);

    }

    private void btnVentana_Click(Object sender, EventArgs e)
    {
        Form2 frmVentana = new Form2(valorEscogido);

        if (frmVentana.ShowDialog() == DialogResult.OK)
        {
            txtMXM.Visible = false;
            lblMXM.Visible = false;
            txtUSD.Visible = false;
            lblUSD.Visible = false;
            txtCAD.Visible = false;
            lblCAD.Visible = false;
            txtEUR.Visible = false;
            lblEUR.Visible = false;
            txtJPY.Visible = false;
            lblJPY.Visible = false;
            Label lblAgregado = new Label();
            lblAgregado.Text = frmVentana.lblMensaje.Text;
            lblAgregado.AutoSize = true;
            lblAgregado.Location = new Point(10, 30);
            lblAgregado.Visible = false;
            if (txtMonto.Text != null && double.Parse(txtMonto.Text) > 0)
            {
                if (frmVentana.MXM.Checked == true)
                {
                    txtMXM.Visible = true;
                    lblMXM.Visible = true;
                    if (valorEscogido == "USD")
                    {
                        txtMXM.Text = "$" + (double.Parse(txtMonto.Text) * 21.23).ToString();
                    }
                    if (valorEscogido == "CAD")
                    {
                        txtMXM.Text = "$" + (double.Parse(txtMonto.Text) * 16.55).ToString();
                    }
                    if (valorEscogido == "EUR")
                    {
                        txtMXM.Text = "$" + (double.Parse(txtMonto.Text) * 23.96).ToString();
                    }
                    if (valorEscogido == "JPY")
                    {
                        txtMXM.Text = "$" + (double.Parse(txtMonto.Text) * 0.1878).ToString();
                    }
                }
                if (frmVentana.USD.Checked == true)
                {
                    txtUSD.Visible = true;
                    lblUSD.Visible = true;
                    if (valorEscogido == "MXM")
                    {
                        txtUSD.Text = "$" + (double.Parse(txtMonto.Text) * 0.05).ToString();
                    }
                    if (valorEscogido == "CAD")
                    {
                        txtUSD.Text = "$" + (double.Parse(txtMonto.Text) * 0.78).ToString();
                    }
                    if (valorEscogido == "EUR")
                    {
                        txtUSD.Text = "$" + (double.Parse(txtMonto.Text) * 1.13).ToString();
                    }
                    if (valorEscogido == "JPY")
                    {
                        txtUSD.Text = "$" + (double.Parse(txtMonto.Text) * 0.0088).ToString();
                    }
                }
                if (frmVentana.CAD.Checked == true)
                {
                    txtCAD.Visible = true;
                    lblCAD.Visible = true;
                    if (valorEscogido == "USD")
                    {
                        txtCAD.Text = "$" + (double.Parse(txtMonto.Text) * 1.28).ToString();
                    }
                    if (valorEscogido == "MXM")
                    {
                        txtCAD.Text = "$" + (double.Parse(txtMonto.Text) * 0.06).ToString();
                    }
                    if (valorEscogido == "EUR")
                    {
                        txtCAD.Text = "$" + (double.Parse(txtMonto.Text) * 1.45).ToString();
                    }
                    if (valorEscogido == "JPY")
                    {
                        txtCAD.Text = "$" + (double.Parse(txtMonto.Text) * 0.0113).ToString();
                    }
                }
                if (frmVentana.EUR.Checked == true)
                {
                    txtEUR.Visible = true;
                    lblEUR.Visible = true;
                    if (valorEscogido == "USD")
                    {
                        txtEUR.Text = "€" + (double.Parse(txtMonto.Text) * 0.89).ToString();
                    }
                    if (valorEscogido == "CAD")
                    {
                        txtEUR.Text = "€" + (double.Parse(txtMonto.Text) * 0.69).ToString();
                    }
                    if (valorEscogido == "MXM")
                    {
                        txtEUR.Text = "€" + (double.Parse(txtMonto.Text) * 0.04).ToString();
                    }
                    if (valorEscogido == "JPY")
                    {
                        txtEUR.Text = "€" + (double.Parse(txtMonto.Text) * 0.0078).ToString();
                    }
                }
                if (frmVentana.JPY.Checked == true)
                {
                    txtJPY.Visible = true;
                    lblJPY.Visible = true;
                    if (valorEscogido == "USD")
                    {
                        txtJPY.Text = "¥" + (double.Parse(txtMonto.Text) * 113.05).ToString();
                    }
                    if (valorEscogido == "CAD")
                    {
                        txtJPY.Text = "¥" + (double.Parse(txtMonto.Text) * 88.12).ToString();
                    }
                    if (valorEscogido == "EUR")
                    {
                        txtJPY.Text = "¥" + (double.Parse(txtMonto.Text) * 127.56).ToString();
                    }
                    if (valorEscogido == "MXM")
                    {
                        txtJPY.Text = "¥" + (double.Parse(txtMonto.Text) * 5.32).ToString();
                    }

                }
               
            }
            

            this.Controls.Add(lblAgregado);

        }

    }
    private void cmbMonedas_ValueChanged(object sender, EventArgs e)
    {
        if (cmbMonedas.SelectedItem != null && txtMonto != null)
        {
            if (cmbMonedas.SelectedItem.ToString() == "USD - Dólar estadounidense")
            {
                btnCalcular.Visible = true;
                valorEscogido = "USD";
            }
            else if (cmbMonedas.SelectedItem.ToString() == "MXN - Peso mexicano")
            {
                btnCalcular.Visible = true;
                valorEscogido = "MXM";
            }
            else if (cmbMonedas.SelectedItem.ToString() == "CAD - Dólar canadiense")
            {
                btnCalcular.Visible = true;
                valorEscogido = "CAD";
            }
            else if (cmbMonedas.SelectedItem.ToString() == "EUR - Euro")
            {
                btnCalcular.Visible = true;
                valorEscogido = "EUR";
            }
            else if (cmbMonedas.SelectedItem.ToString() == "JPY - Yen japonés")
            {
                btnCalcular.Visible = true;
                valorEscogido = "JPY";
            }
        }
    }
}

