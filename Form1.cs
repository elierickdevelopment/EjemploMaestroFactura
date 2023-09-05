using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EjemploMaestroFactura
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bD_PruebaDataSet6.Producto' Puede moverla o quitarla según sea necesario.
            this.productoTableAdapter1.Fill(this.bD_PruebaDataSet6.Producto);
            // TODO: esta línea de código carga datos en la tabla 'bD_PruebaDataSet5.Clientes' Puede moverla o quitarla según sea necesario.
            this.clientesTableAdapter1.Fill(this.bD_PruebaDataSet5.Clientes);


        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox_PRODUCTO_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button_guardar_Click(object sender, EventArgs e)
        {
            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = "Data Source=.;Initial Catalog=BD_Prueba;Integrated Security=True";

            string query = "dbo.sp_guardar_factura "+ textBox_NoFactura.Text +", " + comboBox_cliente.SelectedValue ;
            SqlCommand comando = new SqlCommand(query, sqlConnection);
            sqlConnection.Open();
            comando.ExecuteNonQuery();
            MessageBox.Show("Se agrego correctamente");
            sqlConnection.Close();

        }

        private void button_agregar_Click(object sender, EventArgs e)
        {

            string query = "dbo.sp_guardar_Detalle " + textBox_NoFactura.Text + ", " + comboBox_PRODUCTO.SelectedValue + ", " + textBox_CANTIDAD.Text + "";

            SqlConnection sqlConnection = new SqlConnection();
            sqlConnection.ConnectionString = "Data Source=.;Initial Catalog=BD_Prueba;Integrated Security=True";

            SqlCommand comando = new SqlCommand(query, sqlConnection);
            sqlConnection.Open();
            comando.ExecuteNonQuery();
            CargarDetalle();
            MessageBox.Show("Se agrego el producto correctamente");
            sqlConnection.Close();


        }

        private void CargarDetalle()
        {
            DataSet ds = new DataSet();
            string query = "SELECT * FROM View_detalle_factura where no_factura = " + textBox_NoFactura.Text;
            ObtenerDatos(query, ref ds);
            dataGridView1.DataSource = ds.Tables[0].DefaultView;
            dataGridView1.Refresh();

        }



        public bool ObtenerDatos(string consulta, ref DataSet ds)
        {
            bool ok = false;
            using (SqlConnection conX = new SqlConnection("Data Source=.;Initial Catalog=BD_Prueba;Integrated Security=True"))
            {
                try
                {
                    SqlDataAdapter daConsulta = new SqlDataAdapter(consulta, conX);
                    ds = new DataSet();
                    daConsulta.Fill(ds, "0");
                    if (ds.Tables["0"].Rows.Count > 0)
                        ok = true;
                    else
                        ok = false;
                }
                catch (SqlException ex)
                {
                    ok = false;
                }
            }
            return ok;
        }


    }
}
