
namespace ProyectoGrupo9.Negocio
{
    partial class frmPrincipal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPrincipal));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.registroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroPacienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroMedicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroEmpleadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroEquipoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.datosPacienteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.datosMedicoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.empleadoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.turnoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.turneroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDeTurnosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listadoDePacientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reporteMedicosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.estadisticaObraSocialToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.MediumTurquoise;
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.Left;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registroToolStripMenuItem,
            this.modificarToolStripMenuItem,
            this.turnoToolStripMenuItem,
            this.reporteToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Table;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(144, 393);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // registroToolStripMenuItem
            // 
            this.registroToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registroPacienteToolStripMenuItem,
            this.registroMedicoToolStripMenuItem,
            this.registroEmpleadoToolStripMenuItem,
            this.registroEquipoToolStripMenuItem});
            this.registroToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("registroToolStripMenuItem.Image")));
            this.registroToolStripMenuItem.Name = "registroToolStripMenuItem";
            this.registroToolStripMenuItem.Size = new System.Drawing.Size(138, 20);
            this.registroToolStripMenuItem.Text = "Registro                    ";
            this.registroToolStripMenuItem.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.registroToolStripMenuItem.Click += new System.EventHandler(this.registroToolStripMenuItem_Click);
            // 
            // registroPacienteToolStripMenuItem
            // 
            this.registroPacienteToolStripMenuItem.BackColor = System.Drawing.Color.CornflowerBlue;
            this.registroPacienteToolStripMenuItem.Name = "registroPacienteToolStripMenuItem";
            this.registroPacienteToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.registroPacienteToolStripMenuItem.Text = "Registro Paciente";
            this.registroPacienteToolStripMenuItem.Click += new System.EventHandler(this.registroPacienteToolStripMenuItem_Click);
            // 
            // registroMedicoToolStripMenuItem
            // 
            this.registroMedicoToolStripMenuItem.BackColor = System.Drawing.Color.CornflowerBlue;
            this.registroMedicoToolStripMenuItem.Name = "registroMedicoToolStripMenuItem";
            this.registroMedicoToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.registroMedicoToolStripMenuItem.Text = "Registro Medico";
            this.registroMedicoToolStripMenuItem.Click += new System.EventHandler(this.registroMedicoToolStripMenuItem_Click);
            // 
            // registroEmpleadoToolStripMenuItem
            // 
            this.registroEmpleadoToolStripMenuItem.BackColor = System.Drawing.Color.CornflowerBlue;
            this.registroEmpleadoToolStripMenuItem.Name = "registroEmpleadoToolStripMenuItem";
            this.registroEmpleadoToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.registroEmpleadoToolStripMenuItem.Text = "Registro Empleado";
            this.registroEmpleadoToolStripMenuItem.Click += new System.EventHandler(this.registroEmpleadoToolStripMenuItem_Click);
            // 
            // registroEquipoToolStripMenuItem
            // 
            this.registroEquipoToolStripMenuItem.BackColor = System.Drawing.Color.CornflowerBlue;
            this.registroEquipoToolStripMenuItem.Name = "registroEquipoToolStripMenuItem";
            this.registroEquipoToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.registroEquipoToolStripMenuItem.Text = "Registro Equipo";
            this.registroEquipoToolStripMenuItem.Click += new System.EventHandler(this.registroEquipoToolStripMenuItem_Click);
            // 
            // modificarToolStripMenuItem
            // 
            this.modificarToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.datosPacienteToolStripMenuItem,
            this.datosMedicoToolStripMenuItem,
            this.empleadoToolStripMenuItem});
            this.modificarToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("modificarToolStripMenuItem.Image")));
            this.modificarToolStripMenuItem.Name = "modificarToolStripMenuItem";
            this.modificarToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.modificarToolStripMenuItem.Text = "Buscar";
            this.modificarToolStripMenuItem.Click += new System.EventHandler(this.modificarToolStripMenuItem_Click);
            // 
            // datosPacienteToolStripMenuItem
            // 
            this.datosPacienteToolStripMenuItem.BackColor = System.Drawing.Color.CornflowerBlue;
            this.datosPacienteToolStripMenuItem.Name = "datosPacienteToolStripMenuItem";
            this.datosPacienteToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.datosPacienteToolStripMenuItem.Text = "Paciente";
            this.datosPacienteToolStripMenuItem.Click += new System.EventHandler(this.datosPacienteToolStripMenuItem_Click);
            // 
            // datosMedicoToolStripMenuItem
            // 
            this.datosMedicoToolStripMenuItem.BackColor = System.Drawing.Color.CornflowerBlue;
            this.datosMedicoToolStripMenuItem.Name = "datosMedicoToolStripMenuItem";
            this.datosMedicoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.datosMedicoToolStripMenuItem.Text = "Medico";
            this.datosMedicoToolStripMenuItem.Click += new System.EventHandler(this.datosMedicoToolStripMenuItem_Click);
            // 
            // empleadoToolStripMenuItem
            // 
            this.empleadoToolStripMenuItem.BackColor = System.Drawing.Color.CornflowerBlue;
            this.empleadoToolStripMenuItem.Name = "empleadoToolStripMenuItem";
            this.empleadoToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.empleadoToolStripMenuItem.Text = "Empleado";
            this.empleadoToolStripMenuItem.Click += new System.EventHandler(this.empleadoToolStripMenuItem_Click);
            // 
            // turnoToolStripMenuItem
            // 
            this.turnoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.turneroToolStripMenuItem});
            this.turnoToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("turnoToolStripMenuItem.Image")));
            this.turnoToolStripMenuItem.Name = "turnoToolStripMenuItem";
            this.turnoToolStripMenuItem.Size = new System.Drawing.Size(66, 20);
            this.turnoToolStripMenuItem.Text = "Turno";
            // 
            // turneroToolStripMenuItem
            // 
            this.turneroToolStripMenuItem.BackColor = System.Drawing.Color.CornflowerBlue;
            this.turneroToolStripMenuItem.Name = "turneroToolStripMenuItem";
            this.turneroToolStripMenuItem.Size = new System.Drawing.Size(115, 22);
            this.turneroToolStripMenuItem.Text = "Turnero";
            this.turneroToolStripMenuItem.Click += new System.EventHandler(this.turneroToolStripMenuItem_Click);
            // 
            // reporteToolStripMenuItem
            // 
            this.reporteToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listadoDeTurnosToolStripMenuItem,
            this.listadoDePacientesToolStripMenuItem,
            this.reporteMedicosToolStripMenuItem,
            this.estadisticaObraSocialToolStripMenuItem});
            this.reporteToolStripMenuItem.Image = global::ProyectoGrupo9.Properties.Resources.excel4;
            this.reporteToolStripMenuItem.Name = "reporteToolStripMenuItem";
            this.reporteToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.reporteToolStripMenuItem.Text = "Reporte";
            this.reporteToolStripMenuItem.Click += new System.EventHandler(this.reporteToolStripMenuItem_Click);
            // 
            // listadoDeTurnosToolStripMenuItem
            // 
            this.listadoDeTurnosToolStripMenuItem.Name = "listadoDeTurnosToolStripMenuItem";
            this.listadoDeTurnosToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.listadoDeTurnosToolStripMenuItem.Text = "Listado de Turnos";
            this.listadoDeTurnosToolStripMenuItem.Click += new System.EventHandler(this.listadoDeTurnosToolStripMenuItem_Click);
            // 
            // listadoDePacientesToolStripMenuItem
            // 
            this.listadoDePacientesToolStripMenuItem.Name = "listadoDePacientesToolStripMenuItem";
            this.listadoDePacientesToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.listadoDePacientesToolStripMenuItem.Text = "Listado de Pacientes";
            this.listadoDePacientesToolStripMenuItem.Click += new System.EventHandler(this.listadoDePacientesToolStripMenuItem_Click);
            // 
            // reporteMedicosToolStripMenuItem
            // 
            this.reporteMedicosToolStripMenuItem.Name = "reporteMedicosToolStripMenuItem";
            this.reporteMedicosToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.reporteMedicosToolStripMenuItem.Text = "Reporte Medicos";
            this.reporteMedicosToolStripMenuItem.Click += new System.EventHandler(this.reporteMedicosToolStripMenuItem_Click);
            // 
            // estadisticaObraSocialToolStripMenuItem
            // 
            this.estadisticaObraSocialToolStripMenuItem.Name = "estadisticaObraSocialToolStripMenuItem";
            this.estadisticaObraSocialToolStripMenuItem.Size = new System.Drawing.Size(189, 22);
            this.estadisticaObraSocialToolStripMenuItem.Text = "Estadistica ObraSocial";
            this.estadisticaObraSocialToolStripMenuItem.Click += new System.EventHandler(this.estadisticaObraSocialToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("salirToolStripMenuItem.Image")));
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(57, 20);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DarkTurquoise;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(147)))), ((int)(((byte)(57)))));
            this.panel1.Location = new System.Drawing.Point(144, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(536, 393);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(536, 393);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Location = new System.Drawing.Point(0, 13);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(8, 8);
            this.reportViewer1.TabIndex = 2;
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(680, 393);
            this.Controls.Add(this.reportViewer1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sistema Gasitua";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem registroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroPacienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem datosPacienteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroMedicoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem datosMedicoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroEmpleadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroEquipoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem empleadoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem turnoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem turneroToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem reporteToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoDeTurnosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listadoDePacientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reporteMedicosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem estadisticaObraSocialToolStripMenuItem;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}