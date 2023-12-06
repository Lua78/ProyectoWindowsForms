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
    public partial class FacturaDe : Form
    {
        private SQLConexion con;
        private int id;
        public FacturaDe(SQLConexion con, int id)
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
            con.GetFacturas(dataGridView1, id);
            SqlDataReader lector = con.GetFacturas(id);
            lector.Read();
            txtId.Text = lector.GetInt32(0).ToString();
            txtFecha.Text = lector.GetDateTime(6).ToString();
            txtNombre.Text = lector.GetString(1);
            txtCedula.Text = lector.GetString(2);
            txtSub.Text = lector.GetDouble(4).ToString();
            txtTotal.Text = lector.GetDouble(5).ToString();
            lector.Close();

            txtId.Enabled = false;
            txtFecha.Enabled = false;
            txtNombre.Enabled = false;
            txtCedula.Enabled = false;
            txtSub.Enabled = false;
            txtTotal.Enabled = false;


        }

        private void button1_Click(object sender, EventArgs e)
        {

        }


        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
