using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using tiendaRopa.view;



namespace tiendaRopa
{
    public partial class Form1 : Form
    {
       

        public Form1()
        {
            InitializeComponent();
        }

        private void pnlCentral_Paint(object sender, PaintEventArgs e)
        {



        }

        private void button1_Click(object sender, EventArgs e)
        {
            login lg = new login();
            lg.TopLevel = false;
            pnlCentral.Controls.Add(lg);
            lg.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            nuevoProducto.Visible = true;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            nuevoUsuario.Visible = true;

            pnlBotones.Controls.Add(nuevoUsuario);
        }

        private void pnlIsquierdo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            noMostrar();
            nuevoUsuario.Visible = true;

            pnlBotones.Controls.Add(nuevoUsuario);

        }

        private void button14_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click_1(object sender, EventArgs e)
        {
            noMostrar();
            nuevoProducto.Visible = true;
            pnlBotones.Controls.Add(nuevoProducto);
        }

        //metodo para  que los grupos no sean visibles
        public void noMostrar()
        {
            if (nuevoUsuario.Visible==true||nuevoProducto.Visible==true)
            {
                nuevoUsuario.Visible = false;
                nuevoProducto.Visible = false;
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lbHora.Text = DateTime.Now.ToLongTimeString();
            lbFecha.Text = DateTime.Now.ToLongDateString();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            fmTablaProd ftp = new fmTablaProd();
            ftp.TopLevel = false;

            pnlCentral.Controls.Add(ftp);
            ftp.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            fmTablaProd fmPro = new fmTablaProd();
            fmPro.TopLevel = false;
            pnlCentral.Controls.Add(fmPro);
            fmPro.Show();
        }
    }
}
