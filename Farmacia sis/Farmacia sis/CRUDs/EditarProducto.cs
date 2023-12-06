using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Farmacia_sis.CRUDs
{
    public partial class EditarProducto : Form
    {
        private SQLConexion con;
        private int id;
        public EditarProducto(SQLConexion con, int id)
        {
            this.con = con;
            this.id = id;
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void EditarProducto_Load(object sender, EventArgs e)
        {
            CargarProveedores();
            SqlDataReader lector = con.GetProductoID(id);
            lector.Read();
            txtId.Text = lector.GetInt32(0).ToString();
            txtCantidad.Text = lector.GetInt32(5).ToString();
            txtNombre.Text = lector.GetString(1);
            txtDescripcion.Text = lector.GetString(2);
            txtPrecio.Text = lector.GetDouble(4).ToString();
            txtCaducidad.Text = lector.GetDateTime(6).ToString();
            comboBoxProveedores.SelectedItem = lector.GetString(7);
            txtCaducidad.Enabled = false;
            txtId.Enabled = false;
            txtCantidad.Enabled = false;
            comboBox1.SelectedItem = lector.GetString(3);
            lector.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(comboBox1.SelectedItem==null || comboBoxProveedores.SelectedItem == null)
            {
                MessageBox.Show("Selecciona el proveedor y presentacion del producto.");
                return;
            }
            if (txtCantidad.Text != "" && txtNombre.Text !="" && txtPrecio.Text !="" && txtDescripcion.Text!="")
            {
                con.ActProducto(id, txtNombre.Text, txtPrecio.Text, txtDescripcion.Text, comboBox1.SelectedItem.ToString(),comboBoxProveedores.SelectedItem.ToString() );
                this.Close();
            }
            else
            {
                MessageBox.Show("Todos los campos deben estar llenos");
            }
        }


        private void CargarProveedores()
        {
            SqlCommand com = new SqlCommand("Select PnombreP from PROVEEDOR", con.con);
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            comboBoxProveedores.ValueMember = "PNombreP";
            comboBoxProveedores.DisplayMember = "PNombreP";
            comboBoxProveedores.DataSource = dt;

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
