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
    public partial class frmReporteObraSocial : Form
    {
        Paciente oPaciente = new Paciente();
        public frmReporteObraSocial()
        {
            InitializeComponent();
        }

        private void frmReporteObraSocial_Load(object sender, EventArgs e)
        {

            this.reportViewer3.RefreshReport();
        }

        private void reportViewer1_Load(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();

            tabla = oPaciente.RecuperarEstadistica();


            ReportDataSource ds = new ReportDataSource("DatosEstadisticos", tabla);


            reportViewer3.LocalReport.DataSources.Clear();
            reportViewer3.LocalReport.DataSources.Add(ds);
            reportViewer3.LocalReport.Refresh();

        }
    }
}
