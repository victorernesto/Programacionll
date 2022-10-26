using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using tiendaRopa.Data;

namespace tiendaRopa.view
{
    public partial class fmTablaProd : Form
    {
        public fmTablaProd()
        {
            InitializeComponent();
        }

        private void fmTablaProd_Load(object sender, EventArgs e)
        {
            mostrarProducto();
        } 

        public void mostrarProducto()
        {
            conexionBdd cbd = new conexionBdd();

            cbd.conexion();    
            string selectPro = "SELECT * FROM tb_Stock";
            SqlDataAdapter select = new SqlDataAdapter(selectPro,cbd.conexion());
            DataTable productos = new DataTable();
            select.Fill(productos);
            dataGridView1.DataSource = productos;
                
        }
    }
}
