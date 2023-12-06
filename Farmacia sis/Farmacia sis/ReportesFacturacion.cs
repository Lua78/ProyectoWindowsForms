using Microsoft.Reporting.WinForms;
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
    public partial class ReportesFacturacion : Form
    {
        SQLConexion con;
        public ReportesFacturacion(SQLConexion con)
        {
            this.con = con;
            InitializeComponent();
        }

        private void ReportesFacturacion_Load(object sender, EventArgs e)
        {
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Farmacia_sis.Reportes.ReportePortada.rdlc";
            this.reportViewer1.RefreshReport();
        }
        public void ReporteClientes()
        {
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Farmacia_sis.Reportes.Clientes.rdlc";
            DataSet1 ds = con.ReportCliente();
            ReportDataSource datasour = new ReportDataSource("DataSet1", ds.Tables["ListarClientes"]);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(datasour);
            this.reportViewer1.RefreshReport();

        }
        public void ReporteProductosVendidos ()
        {
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Farmacia_sis.Reportes.ProductosVendidos.rdlc";
            DataSet1 ds = con.ProductosMasVendidos();
            ReportDataSource datasour = new ReportDataSource("DataSet1", ds.Tables["ProductosMasVendidos"]);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(datasour);
            this.reportViewer1.RefreshReport();

        }
        public void ReporteProductosExistentes()
        {
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Farmacia_sis.Reportes.ProductosExistentes.rdlc";
            DataSet1 ds = con.ProductosConExistencias();
            ReportDataSource datasour = new ReportDataSource("DataSet1", ds.Tables["listarProductosExistentes"]);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(datasour);
            this.reportViewer1.RefreshReport();

        }
        public void ReporteProductosNoExistentes()
        {
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Farmacia_sis.Reportes.ProductosSinExistencias.rdlc";
            DataSet1 ds = con.ProductosSinExistencias();
            ReportDataSource datasour = new ReportDataSource("DataSet1", ds.Tables["listarProductosNOExistentes"]);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(datasour);
            this.reportViewer1.RefreshReport();

        }
        public void ReporteFacturas()
        {
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Farmacia_sis.Reportes.ReporteFacturas.rdlc";
            DataSet1 ds = con.RFacturas();
            ReportDataSource datasour = new ReportDataSource("DataSet1", ds.Tables["listarFacturas"]);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(datasour);
            this.reportViewer1.RefreshReport();

        }
        public void ReportProveedores()
        {
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Farmacia_sis.Reportes.Proveedores.rdlc";
            DataSet1 ds = con.ReportProveedor();
            ReportDataSource datasour = new ReportDataSource("DataSet1", ds.Tables["listarProveedores"]);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(datasour);
            this.reportViewer1.RefreshReport();

        }
    }
}
