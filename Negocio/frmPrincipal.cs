using ProyectoGrupo9.Negocio;
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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void modificarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void registroPacienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegistrarPaciente cb;
            cb = new frmRegistrarPaciente();
            cb.ShowDialog();

            cb.Dispose();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void frmPrincipal_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("¿Esta seguro de abandonar la aplicacion?",
                "SALIR",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                e.Cancel = false;
            else
                e.Cancel = true;
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {


            this.reportViewer1.RefreshReport();
        }

        private void registroMedicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegistrarMedico frm = new frmRegistrarMedico();
            frm.ShowDialog();
        }

        private void datosMedicoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBusquedaMedico fam = new frmBusquedaMedico();
            fam.ShowDialog();
        }

        private void datosPacienteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBusquedaPaciente cb;
            cb = new frmBusquedaPaciente();
            cb.ShowDialog();

            cb.Dispose();
        }

        private void empleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmBuscarEmpleado cb;
            cb = new frmBuscarEmpleado();
            cb.ShowDialog();

            cb.Dispose();

        }

        private void registroEmpleadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegistrarEmpleado cb;
            cb = new frmRegistrarEmpleado();
            cb.ShowDialog();

            cb.Dispose();

              
        }

        private void registroEquipoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRegistrarEquipo cb;
            cb = new frmRegistrarEquipo();
            cb.ShowDialog();

            cb.Dispose();
        }

        private void turneroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Turnero cb;
            cb = new Turnero();
            cb.ShowDialog();

            cb.Dispose();
        }

        private void registroToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void reporteToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void listadoDeTurnosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReporteTurnos cb;
            cb = new frmReporteTurnos();
            cb.ShowDialog();

            cb.Dispose();
        }

        private void listadoDePacientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReportePacientes cb;
            cb = new frmReportePacientes();
            cb.ShowDialog();

            cb.Dispose();
        }

        private void reporteMedicosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReporteMedicos cb;
            cb = new frmReporteMedicos();
            cb.ShowDialog();

            cb.Dispose();
        }

        private void estadisticaObraSocialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReporteObraSocial cb;
            cb = new frmReporteObraSocial();
            cb.ShowDialog();

            cb.Dispose();
        }
    }
}
