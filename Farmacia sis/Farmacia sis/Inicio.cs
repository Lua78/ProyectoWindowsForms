using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Xml.Serialization;

namespace Farmacia_sis
{
    public partial class Inicio : Form
    {
       private SQLConexion con;
        public Inicio(SQLConexion con)
        {
            this.con = con;
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AbrirForm(new Facturacion(con));
        }

        private void Inicio_Load(object sender, EventArgs e)
        {
            btnDown.Visible = false;
            btnDown.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            AbrirForm(new ContenedorReportes(con));

        }

        void AbrirForm(Form f)
        {

            if(this.Contenedor.Controls.Count > 0) 
            { 
                this.Contenedor.Controls.RemoveAt(0);
            }
            f.TopLevel = false;
            f.Dock = DockStyle.Fill;
            this.Contenedor.Controls.Add(f);
            this.Contenedor.Tag = f;
            f.Show();

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            con.Desconectar();
            Application.Exit();
        }

        private void btnClose_MouseHover(object sender, EventArgs e)
        {
            btnClose.BackColor = Color.Green;
        }

        private void btnClose_MouseLeave(object sender, EventArgs e)
        {
            btnClose.BackColor = Color.Transparent;
        }

        private void btnDown_Click(object sender, EventArgs e)
        {

            btnUp.Enabled = true;
            btnUp.Visible = true;
            btnDown.Enabled = false;
            btnDown.Visible = false;
            this.WindowState = FormWindowState.Normal;
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            btnDown.Enabled = true;
            btnDown.Visible = true;
            btnUp.Enabled = false;
            btnUp.Visible = false;

            this.WindowState = FormWindowState.Maximized;
        }

        private void btnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btnDown_MouseHover(object sender, EventArgs e)
        {
            btnDown.BackColor = Color.Green;
        }

        private void btnDown_MouseLeave(object sender, EventArgs e)
        {
            btnDown.BackColor = Color.Transparent;
        }

        private void btnMinimize_MouseHover(object sender, EventArgs e)
        {
            btnMinimize.BackColor = Color.Green;
        }

        private void btnMinimize_MouseLeave(object sender, EventArgs e)
        {
            btnMinimize.BackColor = Color.Transparent;
        }

        private void btnUp_MouseHover(object sender, EventArgs e)
        {
            btnUp.BackColor = Color.Green;
        }

        private void btnUp_MouseLeave(object sender, EventArgs e)
        {
            btnUp.BackColor = Color.Transparent;
        }

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
            btnUp.Enabled = true;
            btnUp.Visible = true;
            btnDown.Enabled = false;
            btnDown.Visible = false;

        }

        private void btnProductos_Click(object sender, EventArgs e)
        {
            AbrirForm(new Inventario(con));
        }

        private void Contenedor_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnInicio_Click(object sender, EventArgs e)
        {
            if (this.Contenedor.Controls.Count > 0)
            {
                this.Contenedor.Controls.RemoveAt(0);
            }
        }

        private void BarraTitulo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnFacturas_Click(object sender, EventArgs e)
        {
            AbrirForm(new Facturas(con));
        }

        private void MenuIzquierdo_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnProveedores_Click(object sender, EventArgs e)
        {
            AbrirForm(new Proveedores(con));
        }

        private void btnClientes_Click(object sender, EventArgs e)
        {
            AbrirForm(new Clientes(con));
        }
    }
}
