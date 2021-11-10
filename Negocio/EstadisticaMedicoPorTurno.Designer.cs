
namespace ProyectoGrupo9.Negocio
{
    partial class EstadisticaMedicoPorTurno
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
            this.reportViewer8 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // reportViewer8
            // 
            this.reportViewer8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer8.LocalReport.ReportEmbeddedResource = "ProyectoGrupo9.EstidistaTurnosPorMedico.rdlc";
            this.reportViewer8.Location = new System.Drawing.Point(0, 0);
            this.reportViewer8.Name = "reportViewer8";
            this.reportViewer8.ServerReport.BearerToken = null;
            this.reportViewer8.Size = new System.Drawing.Size(579, 340);
            this.reportViewer8.TabIndex = 0;
            this.reportViewer8.Load += new System.EventHandler(this.reportViewer8_Load);
            // 
            // EstadisticaMedicoPorTurno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 340);
            this.Controls.Add(this.reportViewer8);
            this.Name = "EstadisticaMedicoPorTurno";
            this.Text = "EstadisticaMedicoPorTurno";
            this.Load += new System.EventHandler(this.EstadisticaMedicoPorTurno_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer8;
    }
}