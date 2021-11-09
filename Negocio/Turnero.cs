using ProyectoGrupo9.Clases;
using ProyectoGrupo9.Datos;
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

namespace ProyectoGrupo9.Negocio
{
    public partial class Turnero : Form
    {
        Paciente oPaciente = new Paciente();
        Medicos oMedico = new Medicos();
        Especialidad especialidad = new Especialidad();
        Equipos oEquipos = new Equipos();
        Horas oHoras = new Horas();
        Estudio oEstudio = new Estudio();

        public Turnero()
        {
            InitializeComponent();
        }

        private void Turnero_Load(object sender, EventArgs e)
        {
            btnSeleccionar.Enabled = false;
            this.CargarGrilla(dgvPaciente, oPaciente.RecuperarTodos());
            this.CargarCombo(cboEstudio, oEstudio.RecuperarTodos());
            this.CargarCombo(cboHoras, oHoras.RecuperarTodos());
          
        }
        private void CargarGrilla(DataGridView grilla, DataTable tabla)
        {
            grilla.Rows.Clear();
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                grilla.Rows.Add(tabla.Rows[i]["dni"],
                                tabla.Rows[i]["nombre"],
                                tabla.Rows[i]["apellido"],
                                tabla.Rows[i]["provincia"],
                                tabla.Rows[i]["ciudad"],
                                tabla.Rows[i]["obra_social"],
                                tabla.Rows[i]["calle"],
                                tabla.Rows[i]["altura_Calle"],
                                tabla.Rows[i]["fecha_nacimiento"],
                                tabla.Rows[i]["mail"]);
            };
        }

        private void btnBucar_Click(object sender, EventArgs e)
        {
            string DNI = string.Empty;
            DNI = this.textBox1.Text;

            this.CargarGrilla(dgvPaciente, oPaciente.RecuperarFiltrados(DNI));
            this.btnSeleccionar.Enabled = false;
           
        }
        private void CargarCombo(ComboBox combo, DataTable tabla)
        {
            combo.DataSource = tabla;
            combo.DisplayMember = tabla.Columns[1].ColumnName;
            combo.ValueMember = tabla.Columns[0].ColumnName;
            combo.SelectedIndex = -1;
            combo.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        private void CargarCombo(ComboBox combo, DataTable tabla, string campoMostrar, string campoValor)
        {
            combo.DataSource = tabla;
            combo.DisplayMember = campoMostrar;
            combo.ValueMember = campoValor;
            combo.SelectedIndex = -1;
            combo.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void dgvPaciente_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnSeleccionar.Enabled = true;
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            this.txtNombre.Text = (string)dgvPaciente.CurrentRow.Cells[1].Value;
            this.txtApellido.Text = (string)dgvPaciente.CurrentRow.Cells[2].Value;
            this.txtObraSocial.Text = (string)dgvPaciente.CurrentRow.Cells[5].Value;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboEstudio_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboEstudio.Text == "Consulta")
            {
                this.CargarCombo2(cboMedico, oMedico.RecuperarConsulta());
                this.cboEquipo.Enabled = false;
            }
            else
            {
                this.CargarCombo2(cboMedico, oMedico.RecuperarImagenes());
                this.cboEquipo.Enabled = true;
                this.CargarCombo(cboEquipo, oEquipos.RecuperarTodos());
                
            }
        }

        private void cboMedico_SelectedIndexChanged(object sender, EventArgs e)
        {
            string medico = string.Empty;
            medico = this.cboMedico.Text;

            CargarCombo3(cboCosto, oMedico.RecuperarCosto(medico));
        }
        private void CargarCombo2(ComboBox combo, DataTable tabla)
        {
            combo.DataSource = tabla;
            combo.DisplayMember = tabla.Columns[5].ColumnName;
            combo.ValueMember = tabla.Columns[0].ColumnName;
            combo.SelectedIndex = -1;
            combo.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        private void CargarCombo2(ComboBox combo, DataTable tabla, string campoMostrar, string campoValor)
        {
            combo.DataSource = tabla;
            combo.DisplayMember = campoMostrar;
            combo.ValueMember = campoValor;
            combo.SelectedIndex = -1;
            combo.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        private void CargarCombo3(ComboBox combo, DataTable tabla)
        {
            combo.DataSource = tabla;
            combo.DisplayMember = tabla.Columns[2].ColumnName;
            combo.ValueMember = tabla.Columns[0].ColumnName;
            combo.SelectedIndex = -1;
            combo.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        private void CargarCombo3(ComboBox combo, DataTable tabla, string campoMostrar, string campoValor)
        {
            combo.DataSource = tabla;
            combo.DisplayMember = campoMostrar;
            combo.ValueMember = campoValor;
            combo.SelectedIndex = -1;
            combo.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            BDHelper.GetDBHelper().conectarConTransaccion();
            grabarTurnos();
            BDHelper.GetDBHelper().desconectar();
            //if (this.cboEstudio.Text == "" || this.cboMedico.Text == "" || this.cboHoras.Text == "" || this.dtpFecha.Text == "" || this.cboCosto.Text == "" )
            //{
            //  MessageBox.Show("Debe ingresar todos los campos obligatorios");

            //}
            //else
            //{
            
            //}
        }

        private void btnRefrescar_Click(object sender, EventArgs e)
        {
            this.CargarGrilla(dgvPaciente, oPaciente.RecuperarTodos());
        }

        private void btnAgenda_Click(object sender, EventArgs e)
        {
            frmAgenda cb;
            cb = new frmAgenda();
            cb.ShowDialog();

            cb.Dispose();

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            dgvTurno.Rows.Add(txtNombre.Text, txtApellido.Text, txtObraSocial.Text, cboEstudio.Text, cboMedico.Text, dtpFecha.Value.ToString("yyyy-MM-dd"),
                cboHoras.Text,   cboEquipo.Text,
                cboCosto.Text, txtDescripcion.Text);
        }
        public void grabarTurnos()
        {
            string agregado = "";
            agregado = "INSERT INTO Turnos VALUES (" +
            txtNombre.Text + "," +
            txtApellido.Text + "," +
            dtpFecha.Value.ToString() + "," +
            cboHoras.SelectedValue.ToString() + "," +
            cboMedico.SelectedValue.ToString() + "," +
            cboEstudio.SelectedValue.ToString() + "," +
            cboEquipo.Text + "," +
            txtObraSocial.Text + "," +
            cboCosto.SelectedValue.ToString() + ",";

            BDHelper.getDBHelper().EjecutarSQLConTransaccion(agregado);
            var IDnew = BDHelper.GetDBHelper().ConsultaSQLScalar("SELECT @@IDENTITY ");


            for (int i = 0; i < dgvTurno.Rows.Count; i++)
            {
                string consulta = "INSERT INTO DetallesTurnos values ( " + dgvTurno.CurrentRow.Cells[9].Value.ToString() + ")";




                BDHelper.GetDBHelper().EjecutarSQLConTransaccion(consulta);


            }
        }
    }
}
