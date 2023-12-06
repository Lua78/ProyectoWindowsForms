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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Farmacia_sis.CRUDs
{
    public partial class AgregarProveedor : Form
    {
        private SQLConexion con;
        
        public AgregarProveedor(SQLConexion con )
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



        private void button1_Click(object sender, EventArgs e)
        {

            if (txtNombre.Text != "" && txtDireccion.Text != "" && txtTelefono.Text!="")
            {
                con.InsertarProveedor(txtNombre.Text,txtDireccion.Text,txtTelefono.Text);
                this.Close();
            }
            else
            {
                MessageBox.Show("Todos los campos deben estar llenos");
            }
        }



        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void EditarCliente_Load(object sender, EventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
