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

namespace Farmacia_sis
{
    public partial class Facturacion : Form
    {
        private SQLConexion con;
        private int cantidadProducto = 0;        private float total = 0;
        private DataTable ProductosAFacturar = new DataTable();
        public Facturacion(SQLConexion con)
        {
            this.con = con;
            ProductosAFacturar.Columns.Add("ID");
            ProductosAFacturar.Columns.Add("Nombre");
            ProductosAFacturar.Columns.Add("Descripcion");
            ProductosAFacturar.Columns.Add("Precio");
            ProductosAFacturar.Columns.Add("Cantidad");
            ProductosAFacturar.Columns.Add("Sub");
            
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void maskedTextBox3_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (ProductosAFacturar.Rows.Count >= 1)
            {
                if (cbCliente.SelectedValue.ToString() != "")
                {
                    DateTime.Today.ToString();
                    con.NuevaFactura(cbCliente.SelectedValue.ToString(), total,float.Parse(txtTotal.Text), DateTime.UtcNow.ToString("dd-MM-yy"));
                    foreach(DataRow t in ProductosAFacturar.Rows)
                    {
                        con.NuevoDetalle(t["ID"].ToString(), t["Cantidad"].ToString());
                    }
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Debe seleccionar el cliente.");
                }
            }
            else
            {
                MessageBox.Show("Debe agregar al menos un producto");
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void Facturacion_Load(object sender, EventArgs e)
        {
            CargarProductos();
            CargarClientes();
            txtSubtotal.Enabled = false;
            txtNombreCliente.Visible = false;
            txtpresentacion.Enabled = false;
            txtTotal.Enabled = false;
            txtCaducidad.Enabled = false;
            txtPrecio.Enabled = false;
            txtdescripcion.Enabled = false;
            txtproveedor.Enabled = false;
            btnAgregarCliente.Enabled = false;
            txtCedula.Enabled = false;
            TxtTelefono.Enabled = false;
        }



        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked)
            {
                txtNombreCliente.Text = "";
                txtCedula.Text = "";
                TxtTelefono.Text = "";
                cbCliente.Visible = false;
                txtNombreCliente.Visible = true;
                btnAgregarCliente.Enabled = true;
                txtCedula.Enabled= true;
                TxtTelefono.Enabled= true;
            }
            else
            {
                cbCliente.Visible = true;
                txtNombreCliente.Visible = false;
                btnAgregarCliente.Enabled = false;
                txtCedula.Enabled = false;
                TxtTelefono.Enabled = false;
                txtCedula.Text = "";
                TxtTelefono.Text = "";
            }
        }

        private void btnAgregarCliente_Click(object sender, EventArgs e)
        {
            if(txtCedula.Text != ""&& txtNombreCliente.Text != ""&& TxtTelefono.Text != "")
            {
                con.Insertarcliente(txtNombreCliente.Text, txtCedula.Text, TxtTelefono.Text);
                txtNombreCliente.Text = txtCedula.Text = TxtTelefono.Text = "";
                MessageBox.Show("Cliente ageragado.");
                CargarClientes();
                checkBox1.Checked = false;

            }
            else
            {
                MessageBox.Show("Campos Vacios!.");
            }
        }


        private void CargarProductos()
        {
            SqlCommand com = new SqlCommand("select idp,PNombrePr from producto", con.con);
            SqlDataAdapter da = new SqlDataAdapter(com);

            DataTable dt = new DataTable();
            da.Fill(dt);
            DataRow dr = dt.NewRow();
            dr["idp"] = 0;
            dr["PNombrePr"] = "";
            dt.Rows.InsertAt(dr,0);
            cbProductos.ValueMember = "idp";
            cbProductos.DisplayMember = "PNombrePr";
            cbProductos.DataSource = dt;
            cbProductos.AutoCompleteCustomSource = AutoComProd();
            cbProductos.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbProductos.AutoCompleteSource = AutoCompleteSource.CustomSource;
            
            
        }
        private void CargarClientes()
        {
            SqlCommand com = new SqlCommand("select idcliente,PNombre from cliente", con.con);
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            DataRow dr = dt.NewRow();
            dr["idcliente"] = 0;
            dr["PNombre"] = "";
            dt.Rows.InsertAt(dr, 0);
            cbCliente.ValueMember = "idcliente";
            cbCliente.DisplayMember = "PNombre";
            cbCliente.DataSource = dt;
            cbCliente.AutoCompleteCustomSource = AutoComCliente();
            cbCliente.AutoCompleteMode = AutoCompleteMode.Suggest;
            cbCliente.AutoCompleteSource = AutoCompleteSource.CustomSource;

        }

        private void cbCliente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cbProductos_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbProductos.SelectedValue==null)
            {
                return;
            }
            SqlDataReader lector = con.GetProductoID(int.Parse(cbProductos.SelectedValue.ToString()));
            if (lector.Read()) {

                cantidadProducto = lector.GetInt32(5);
                txtdescripcion.Text = lector.GetString(2);
                txtPrecio.Text = lector.GetDouble(4).ToString();
                txtCaducidad.Text = lector.GetDateTime(6).ToString();
                txtproveedor.Text = lector.GetString(7);
                txtpresentacion.Text = lector.GetString(3);
                lector.Close();


            }
            else {
                lector.Close();
            }
          

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if(txtPrecio.Text!="" && txtCantidad.Text != "")
            {
                if (cantidadProducto < int.Parse(txtCantidad.Text))
                {
                    MessageBox.Show("La cantidad disponible es insuficiente.");
                    return;
                }
                float subtotal = float.Parse(txtCantidad.Text) * float.Parse(txtPrecio.Text);
                DataRow dr = ProductosAFacturar.NewRow();
                dr["ID"] = cbProductos.SelectedValue.ToString();
                dr["Nombre"] = cbProductos.GetItemText(cbProductos.SelectedItem);
                dr["Descripcion"] = txtdescripcion.Text;
                dr["Precio"] = txtPrecio.Text;
                dr["Cantidad"] = txtCantidad.Text;
                dr["Sub"] = subtotal ;
                total += subtotal;
                txtSubtotal.Text = total.ToString();
                txtTotal.Text = total.ToString();
                ProductosAFacturar.Rows.Add(dr);
                dataGridView1.DataSource = ProductosAFacturar;


            }

            
        }

        private AutoCompleteStringCollection AutoComProd()
        {
            AutoCompleteStringCollection ComC = new AutoCompleteStringCollection();
            


            try
            {
                SqlCommand com = new SqlCommand("select PNombrePr from producto", con.con);
                

                SqlDataReader  dr = com.ExecuteReader();
                while (dr.Read())
                {
                    ComC.Add(dr.GetString(0));
                }
                dr.Close();
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return ComC;
        }
        private AutoCompleteStringCollection AutoComCliente()
        {
            AutoCompleteStringCollection ComC = new AutoCompleteStringCollection();



            try
            {
                SqlCommand com = new SqlCommand("select PNombre from cliente", con.con);
                SqlDataReader dr = com.ExecuteReader();
                while (dr.Read())
                {
                    ComC.Add(dr.GetString(0));
                }
                dr.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            return ComC;
        }

        private void cbCliente_SelectedValueChanged(object sender, EventArgs e)
        {
            if (cbCliente.SelectedValue == null)
            {
                return;
            }

            try
            {
                
                string sentencia = "select cedula, telefono from cliente where idcliente =" + cbCliente.SelectedValue.ToString();
                SqlCommand com = new SqlCommand(sentencia, con.con);
                SqlDataReader lector = com.ExecuteReader();
            if (lector.Read())
                {

                    txtCedula.Text = lector.GetString(0);
                    TxtTelefono.Text = lector.GetString(1);
                    lector.Close();
                }
                else
                {
                    lector.Close();
                }


            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }




        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }



        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
       
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
