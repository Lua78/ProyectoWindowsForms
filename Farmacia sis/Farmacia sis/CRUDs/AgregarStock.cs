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
    public partial class AgregarStock : Form
    {
        private SQLConexion con;
        private int id;
        public AgregarStock(SQLConexion con, int id)
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
            SqlDataReader lector = con.GetProductoID(id);
            lector.Read();
            txtId.Text = lector.GetInt32(0).ToString();
            txtNombre.Text = lector.GetString(1);
            txtDescripcion.Text = lector.GetString(2);
            txtPrecio.Text = lector.GetDouble(4).ToString();
            txtCaducidad.Text = lector.GetDateTime(6).ToString();
            txtproveedor.Text = lector.GetString(7);
            txtproveedor.Enabled = false;
            txtNombre.Enabled = false;
            txtCaducidad.Enabled = false;
            txtId.Enabled = false;
            txtDescripcion.Enabled = false;
            txtPrecio.Enabled = false;
            txtPresentacion.Text = lector.GetString(3);
            txtPresentacion.Enabled = false;
            lector.Close();

        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (int.Parse(txtCantidad.Text)>0)
            {
                con.ActStock(id, int.Parse(txtCantidad.Text) );
                this.Close();
            }
            else
            {
                MessageBox.Show("Cantidad no valida.","Error");
            }
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
