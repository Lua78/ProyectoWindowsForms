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
namespace Farmacia_sis
{
    public partial class Login : Form
    {
        int intentos = 0;
        public Login()
        {
            InitializeComponent();
        }
        
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SQLConexion con = new SQLConexion("Server = UNPLAPTOP; Database = farmacia; UID = " + textBox1.Text +"; PWD = "+textBox2.Text);
            if (con.Conectar())
            {
                Inicio ini = new Inicio(con);
                ini.Show();
                this.Visible = false;
                
            }
            else
            {
                textBox2.Text = "";
                intentos++;
                MessageBox.Show("Error de inicio de sesion.");
                if (intentos > 2)
                {
                    MessageBox.Show("Error al intentar acceder al sistema... ", "Saliendo");
                    this.Close();
                
                }
            }
        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
