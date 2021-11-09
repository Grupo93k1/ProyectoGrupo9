
namespace ProyectoGrupo9.Negocio
{
    partial class frmAgenda
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvTurno = new System.Windows.Forms.DataGridView();
            this.colum_id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colum_np = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colum_ap = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colum_obra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colum_estudio = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colum_me = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colum_fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colum_hora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colum_equipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colum_Costo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTurno)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvTurno
            // 
            this.dgvTurno.AllowUserToAddRows = false;
            this.dgvTurno.AllowUserToDeleteRows = false;
            this.dgvTurno.BackgroundColor = System.Drawing.Color.LightSkyBlue;
            this.dgvTurno.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTurno.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colum_id,
            this.colum_np,
            this.colum_ap,
            this.colum_obra,
            this.colum_estudio,
            this.colum_me,
            this.colum_fecha,
            this.colum_hora,
            this.colum_equipo,
            this.colum_Costo});
            this.dgvTurno.GridColor = System.Drawing.Color.LightSkyBlue;
            this.dgvTurno.Location = new System.Drawing.Point(12, 27);
            this.dgvTurno.Name = "dgvTurno";
            this.dgvTurno.ReadOnly = true;
            this.dgvTurno.Size = new System.Drawing.Size(876, 349);
            this.dgvTurno.TabIndex = 4;
            this.dgvTurno.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTurno_CellContentClick);
            // 
            // colum_id
            // 
            this.colum_id.HeaderText = "ID";
            this.colum_id.Name = "colum_id";
            this.colum_id.ReadOnly = true;
            this.colum_id.Width = 50;
            // 
            // colum_np
            // 
            this.colum_np.HeaderText = "Nombre_Paciente";
            this.colum_np.Name = "colum_np";
            this.colum_np.ReadOnly = true;
            // 
            // colum_ap
            // 
            this.colum_ap.HeaderText = "Apellido Paciente";
            this.colum_ap.Name = "colum_ap";
            this.colum_ap.ReadOnly = true;
            // 
            // colum_obra
            // 
            this.colum_obra.HeaderText = "ObraSocial";
            this.colum_obra.Name = "colum_obra";
            this.colum_obra.ReadOnly = true;
            this.colum_obra.Width = 80;
            // 
            // colum_estudio
            // 
            this.colum_estudio.HeaderText = "Estudio";
            this.colum_estudio.Name = "colum_estudio";
            this.colum_estudio.ReadOnly = true;
            // 
            // colum_me
            // 
            this.colum_me.HeaderText = "Medico";
            this.colum_me.Name = "colum_me";
            this.colum_me.ReadOnly = true;
            // 
            // colum_fecha
            // 
            this.colum_fecha.HeaderText = "Fecha";
            this.colum_fecha.Name = "colum_fecha";
            this.colum_fecha.ReadOnly = true;
            // 
            // colum_hora
            // 
            this.colum_hora.HeaderText = "Hora";
            this.colum_hora.Name = "colum_hora";
            this.colum_hora.ReadOnly = true;
            this.colum_hora.Width = 50;
            // 
            // colum_equipo
            // 
            this.colum_equipo.HeaderText = "Equipo";
            this.colum_equipo.Name = "colum_equipo";
            this.colum_equipo.ReadOnly = true;
            // 
            // colum_Costo
            // 
            this.colum_Costo.HeaderText = "Costo";
            this.colum_Costo.Name = "colum_Costo";
            this.colum_Costo.ReadOnly = true;
            this.colum_Costo.Width = 50;
            // 
            // frmAgenda
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(885, 398);
            this.Controls.Add(this.dgvTurno);
            this.Name = "frmAgenda";
            this.Text = "frmAgenda";
            this.Load += new System.EventHandler(this.frmAgenda_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTurno)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvTurno;
        private System.Windows.Forms.DataGridViewTextBoxColumn colum_id;
        private System.Windows.Forms.DataGridViewTextBoxColumn colum_np;
        private System.Windows.Forms.DataGridViewTextBoxColumn colum_ap;
        private System.Windows.Forms.DataGridViewTextBoxColumn colum_obra;
        private System.Windows.Forms.DataGridViewTextBoxColumn colum_estudio;
        private System.Windows.Forms.DataGridViewTextBoxColumn colum_me;
        private System.Windows.Forms.DataGridViewTextBoxColumn colum_fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn colum_hora;
        private System.Windows.Forms.DataGridViewTextBoxColumn colum_equipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colum_Costo;
    }
}