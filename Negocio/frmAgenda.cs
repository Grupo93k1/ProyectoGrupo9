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
    public partial class frmAgenda : Form
    {
        Turno oTurno = new Turno();

        public frmAgenda()
        {
            InitializeComponent();
        }

        private void frmAgenda_Load(object sender, EventArgs e)
        {
            this.CargarGrilla(dgvTurno, oTurno.RecuperarTodos());
        }
        private void CargarGrilla(DataGridView grilla, DataTable tabla)
        {
            grilla.Rows.Clear();
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                grilla.Rows.Add(tabla.Rows[i]["id_turno"],
                                tabla.Rows[i]["nombre_paciente"],
                                tabla.Rows[i]["apellido_paciente"],
                                tabla.Rows[i]["obra_social"],
                                tabla.Rows[i]["estudio"],
                                tabla.Rows[i]["medico"],
                                tabla.Rows[i]["fecha"],
                                tabla.Rows[i]["hora"],
                                tabla.Rows[i]["equipo"],
                                tabla.Rows[i]["costo"]);
            };
        }

        private void dgvTurno_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
