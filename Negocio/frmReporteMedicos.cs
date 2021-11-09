using Microsoft.Reporting.WinForms;
using ProyectoGrupo9.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoGrupo9.Negocio
{
    public partial class frmReporteMedicos : Form
    {
        Medicos oMedicos = new Medicos();
        public frmReporteMedicos()
        {
            InitializeComponent();
        }

        private void frmReporteMedicos_Load(object sender, EventArgs e)
        {

            this.reportViewer5.RefreshReport();
            DataTable tabla = new DataTable();

            tabla = oMedicos.RecuperarTodos();


            ReportDataSource ds = new ReportDataSource("DatosPacientes", tabla);


            reportViewer5.LocalReport.DataSources.Clear();
            reportViewer5.LocalReport.DataSources.Add(ds);
            reportViewer5.LocalReport.Refresh();
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            this.reportViewer5.RefreshReport();
        }
    }
}
