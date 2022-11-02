using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolTip;

namespace WinFormsApp5
{
    public partial class Form1 : Form


    {
        public Form1()
        {
            InitializeComponent();
        }

        private void labBebidas_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void pCoca_Click(object sender, EventArgs e)
        {

        }

        private void bCoca_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void tbCambio_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void bCoca_Click_1(object sender, EventArgs e)
        {
            double moneda = (double)numMoneda.Value;
            double precioCoca = 1.5;//double.Parse(lPrecioCoca.Text);
            double cambio;            

            if (moneda >= precioCoca)
            {
                cambio = moneda - precioCoca;
                tbCambio.Text = cambio+"";
                //pConsumo.Visible = true;
                //picConsumoCoca.Visible = true;
                pictureBoxCoca2.Visible=true;

            }
            else
            {
                tbCambio.Text = "Mas dinero";
            }
        }

        private void pictureBox6_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void picConsumoAqua_Click(object sender, EventArgs e)
        {

        }

        private void picConsumoNestea_Click(object sender, EventArgs e)
        {

        }

        private void picConsumoSprite_Click(object sender, EventArgs e)
        {

        }

        private void picConsumoFanta_Click(object sender, EventArgs e)
        {

        }

        private void pConsumo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bFanta_Click(object sender, EventArgs e)
        {
            double moneda = (double)numMoneda.Value;
            double precioFanta = 1.5;//double.Parse(lPrecioFanta.Text);
            double cambio;

            if (moneda >= precioFanta)
            {
                cambio = moneda - precioFanta;
                tbCambio.Text = cambio + "";
                //pConsumo.Visible = true;
                //picConsumoCoca.Visible = true;
                pictureBoxFanta2.Visible = true;

            }
            else
            {
                tbCambio.Text = "Mas dinero";
            }
        }

        private void bSprite_Click(object sender, EventArgs e)
        {
            double moneda = (double)numMoneda.Value;
            double precioSprite = 1.5;//double.Parse(lPrecioSprite.Text);
            double cambio;

            if (moneda >= precioSprite)
            {
                cambio = moneda - precioSprite;
                tbCambio.Text = cambio + "";
                //pConsumo.Visible = true;
                //picConsumoCoca.Visible = true;
                pictureBoxSprite2.Visible = true;

            }
            else
            {
                tbCambio.Text = "Mas dinero";
            }
        }

        private void bNestea_Click(object sender, EventArgs e)
        {
            double moneda = (double)numMoneda.Value;
            double precioNestea = 2.0;//double.Parse(lPrecioNestea.Text);
            double cambio;

            if (moneda >= precioNestea)
            {
                cambio = moneda - precioNestea;
                tbCambio.Text = cambio + "";
                //pConsumo.Visible = true;
                //picConsumoCoca.Visible = true;
                pictureBoxNestea2.Visible = true;

            }
            else
            {
                tbCambio.Text = "Mas dinero";
            }
        }

        private void bAqua_Click(object sender, EventArgs e)
        {
            double moneda = (double)numMoneda.Value;
            double precioAqua = 2.5;//double.Parse(lPrecioAqua.Text);
            double cambio;

            if (moneda >= precioAqua)
            {
                cambio = moneda - precioAqua;
                tbCambio.Text = cambio + "";
                //pConsumo.Visible = true;
                //picConsumoCoca.Visible = true;
                pictureBoxAqua2.Visible = true;

            }
            else
            {
                tbCambio.Text = "Mas dinero";
            }
        }

        private void numMoneda_ValueChanged(object sender, EventArgs e)
        {
            pictureBoxCoca2.Visible = false;
            pictureBoxFanta2.Visible = false;
            pictureBoxSprite2.Visible = false;
            pictureBoxNestea2.Visible = false;
            pictureBoxAqua2.Visible = false;

        }

        private void lPrecioNestea_Click(object sender, EventArgs e)
        {

        }

        private void lPrecioCoca_Click(object sender, EventArgs e)
        {

        }
    }
}

/*
    int coste = 0;
            if (rb1.Checked == true)
            {
               
                coste = coste+pcn;
                //rb1.Checked = false;
                //checkBox3.Checked = false;
            }
            if (rb2.Checked == true)
            {
                coste = coste + 4;
                //checkBox1.Checked = false;
                //checkBox3.Checked = false;
            }
            if (rb3.Checked == true)
            {
                coste = coste + 10;
                //checkBox1.Checked = false;
                //checkBox2.Checked = false;
            }

            if (checkBox4.Checked == true)
            {
                checkBox4.ThreeState = true;
                coste = coste + pemail;
            }
            if (checkBox5.Checked == true)
            {
                coste = coste + ptel;
            }
            if (checkBox6.Checked == true)
            {
                coste = coste + pfax;
            }
            //string select = (string)checkedListBox1.SelectedItem;
            tbCoste.Text = "Test: "+coste;
        
 */