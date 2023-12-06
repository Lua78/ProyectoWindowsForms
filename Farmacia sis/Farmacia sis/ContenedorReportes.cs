using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Farmacia_sis
{
    public partial class ContenedorReportes : Form
    {
        SQLConexion con;
        ReportesFacturacion re;
        public ContenedorReportes(SQLConexion con)
        {
            this.con = con;
            re = new ReportesFacturacion(con);
            InitializeComponent();
        }

        private void ContenedorReportes_Load(object sender, EventArgs e)
        {
            if (this.panelContenedor.Controls.Count > 0)
            {
                this.panelContenedor.Controls.RemoveAt(0);
            }
            re.TopLevel = false;
            re.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(re);
            this.panelContenedor.Tag = re;
            re.Show();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            if (!comboBox1.SelectedItem.Equals(""))
            {
                if (comboBox1.SelectedItem.Equals("Clientes Registrados"))
                {
                    MessageBox.Show("Cargando...");
                    re.ReporteClientes();

                }else if (comboBox1.SelectedItem.Equals("Productos sin existencias"))
                {
                    MessageBox.Show("Cargando...");
                    re.ReporteProductosNoExistentes();
                }
                else if(comboBox1.SelectedItem.Equals("Productos con existencias"))
                {
                    MessageBox.Show("Cargando...");
                    re.ReporteProductosExistentes();
                }
                else if (comboBox1.SelectedItem.Equals("Productos mas Vendidos"))
                {
                    MessageBox.Show("Cargando...");
                    re.ReporteProductosVendidos();
                }
                else if (comboBox1.SelectedItem.Equals("Proveedores"))
                {
                    MessageBox.Show("Cargando...");
                    re.ReportProveedores();
                }
                else if (comboBox1.SelectedItem.Equals("Monto total Facturado"))
                {
                    MessageBox.Show("Cargando...");
                    re.ReporteFacturas();
                }
                else if (comboBox1.SelectedItem.Equals("Todas las Facturas"))
                {

                }
            }
            else
            {
                MessageBox.Show("Seleccione el tipo de reporte.","Error");
            }
            






        }
        private void CargarReporte(ReportesFacturacion re)
        {
            if (this.panelContenedor.Controls.Count > 0)
            {
                this.panelContenedor.Controls.RemoveAt(0);
            }
            re.TopLevel = false;
            re.Dock = DockStyle.Fill;
            this.panelContenedor.Controls.Add(re);
            this.panelContenedor.Tag = re;
            re.Show();
        }
    }
}
