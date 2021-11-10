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
    public partial class EstadisticaMedicoPorTurno : Form
    {
        Medicos oMedico = new Medicos();
        public EstadisticaMedicoPorTurno()
        {
            InitializeComponent();
        }

        private void EstadisticaMedicoPorTurno_Load(object sender, EventArgs e)
        {

            this.reportViewer8.RefreshReport();
        }

        private void reportViewer8_Load(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();

            tabla = oMedico.RecuperarEstadistica();


            ReportDataSource ds = new ReportDataSource("DatosEstadisticos", tabla);


            reportViewer8.LocalReport.DataSources.Clear();
            reportViewer8.LocalReport.DataSources.Add(ds);
            reportViewer8.LocalReport.Refresh();

        }
    }
}
