using Microsoft.Reporting.WinForms;
using ProyectoGrupo9.Clases;
using ProyectoGrupo9.ConjuntoDeDatos;
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
            // TODO: esta línea de código carga datos en la tabla 'proyecto_PAVDataSet.Medico' Puede moverla o quitarla según sea necesario.
            this.medicoTableAdapter.Fill(this.proyecto_PAVDataSet.Medico);

            this.reportViewer5.RefreshReport();
            
        }

        private void btnGenerar_Click(object sender, EventArgs e)
        {
            string _matricula, _apellido;
            _matricula = _apellido = string.Empty;

            if (txtMatricula.TextLength != -1)
                _matricula = txtMatricula.TextLength.ToString();
            if (txtApellido.TextLength != -1)
                _apellido = txtApellido.TextLength.ToString();

            this.medicoBindingSource.DataSource = oMedicos.RecuperarFiltrados2(_matricula, _apellido);

            this.reportViewer5.RefreshReport();
        }

        private void reportViewer5_Load(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();

            tabla = oMedicos.RecuperarTodos();


            ReportDataSource ds = new ReportDataSource("DatosMedicos", tabla);


            reportViewer5.LocalReport.DataSources.Clear();
            reportViewer5.LocalReport.DataSources.Add(ds);
            reportViewer5.LocalReport.Refresh();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
