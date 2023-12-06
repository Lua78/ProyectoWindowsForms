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
    public partial class AgregarProducto : Form
    {
        private SQLConexion con;
        public AgregarProducto(SQLConexion con)
        {
            this.con = con;
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

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(comboBox1.SelectedItem==null || comboBoxProveedores.SelectedItem == null)
            {
                MessageBox.Show("Selecciona el proveedor y presentacion del producto.");
                return;
            }
            if (txtCantidad.Text != "" && txtNombre.Text !="" && txtPrecio.Text !="" && txtDescripcion.Text!="" && txtFecha.Text!="")
            {
                con.InsertarProducto(txtNombre.Text, txtDescripcion.Text,comboBox1.SelectedItem.ToString(),float.Parse(txtPrecio.Text),
                     int.Parse(txtCantidad.Text),txtFecha.Text, comboBoxProveedores.SelectedValue.ToString() );
                this.Close();
            }
            else
            {
                MessageBox.Show("Todos los campos deben estar llenos");
            }
        }


        private void CargarProveedores()
        {
            SqlCommand com = new SqlCommand("Select idPr,PnombreP from PROVEEDOR", con.con);
            SqlDataAdapter da = new SqlDataAdapter(com);
            DataTable dt = new DataTable();
            da.Fill(dt);
            comboBoxProveedores.ValueMember = "idPr";
            comboBoxProveedores.DisplayMember = "PNombreP";
            comboBoxProveedores.DataSource = dt;

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
