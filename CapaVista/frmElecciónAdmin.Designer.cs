
namespace CapaVista
{
    partial class frmElecciónAdmin
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnGenerarReportes = new System.Windows.Forms.Button();
            this.btnAdminUsuarios = new System.Windows.Forms.Button();
            this.btnEdicionCartelera = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.btnGestion = new System.Windows.Forms.Button();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(114, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(586, 45);
            this.label1.TabIndex = 4;
            this.label1.Text = "Bienvenido al Sistema Administrativo";
            // 
            // btnGenerarReportes
            // 
            this.btnGenerarReportes.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnGenerarReportes.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarReportes.ForeColor = System.Drawing.Color.White;
            this.btnGenerarReportes.Location = new System.Drawing.Point(64, 167);
            this.btnGenerarReportes.Name = "btnGenerarReportes";
            this.btnGenerarReportes.Size = new System.Drawing.Size(244, 43);
            this.btnGenerarReportes.TabIndex = 23;
            this.btnGenerarReportes.Text = "GENERAR REPORTES";
            this.btnGenerarReportes.UseVisualStyleBackColor = false;
            this.btnGenerarReportes.Click += new System.EventHandler(this.btnGenerarReportes_Click);
            // 
            // btnAdminUsuarios
            // 
            this.btnAdminUsuarios.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnAdminUsuarios.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdminUsuarios.ForeColor = System.Drawing.Color.White;
            this.btnAdminUsuarios.Location = new System.Drawing.Point(64, 298);
            this.btnAdminUsuarios.Name = "btnAdminUsuarios";
            this.btnAdminUsuarios.Size = new System.Drawing.Size(244, 43);
            this.btnAdminUsuarios.TabIndex = 24;
            this.btnAdminUsuarios.Text = "ADMIN. USUARIOS";
            this.btnAdminUsuarios.UseVisualStyleBackColor = false;
            this.btnAdminUsuarios.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnEdicionCartelera
            // 
            this.btnEdicionCartelera.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnEdicionCartelera.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdicionCartelera.ForeColor = System.Drawing.Color.White;
            this.btnEdicionCartelera.Location = new System.Drawing.Point(479, 167);
            this.btnEdicionCartelera.Name = "btnEdicionCartelera";
            this.btnEdicionCartelera.Size = new System.Drawing.Size(244, 43);
            this.btnEdicionCartelera.TabIndex = 25;
            this.btnEdicionCartelera.Text = "EDICIÓN CARTELERA";
            this.btnEdicionCartelera.UseVisualStyleBackColor = false;
            this.btnEdicionCartelera.Click += new System.EventHandler(this.btnEdicionCartelera_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.MediumBlue;
            this.panel3.Controls.Add(this.label3);
            this.panel3.Location = new System.Drawing.Point(1, 2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(804, 53);
            this.panel3.TabIndex = 26;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.MediumBlue;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(3, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(336, 40);
            this.label3.TabIndex = 2;
            this.label3.Text = "Sistema Administrativo";
            // 
            // btnGestion
            // 
            this.btnGestion.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnGestion.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGestion.ForeColor = System.Drawing.Color.White;
            this.btnGestion.Location = new System.Drawing.Point(479, 298);
            this.btnGestion.Name = "btnGestion";
            this.btnGestion.Size = new System.Drawing.Size(244, 43);
            this.btnGestion.TabIndex = 27;
            this.btnGestion.Text = "GESTIÓN DE USUARIOS";
            this.btnGestion.UseVisualStyleBackColor = false;
            this.btnGestion.Click += new System.EventHandler(this.btnGestion_Click);
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnCerrarSesion.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarSesion.ForeColor = System.Drawing.Color.White;
            this.btnCerrarSesion.Location = new System.Drawing.Point(274, 378);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(244, 43);
            this.btnCerrarSesion.TabIndex = 28;
            this.btnCerrarSesion.Text = "CERRAR SESIÓN";
            this.btnCerrarSesion.UseVisualStyleBackColor = false;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // frmElecciónAdmin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCerrarSesion);
            this.Controls.Add(this.btnGestion);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.btnEdicionCartelera);
            this.Controls.Add(this.btnAdminUsuarios);
            this.Controls.Add(this.btnGenerarReportes);
            this.Controls.Add(this.label1);
            this.Name = "frmElecciónAdmin";
            this.Text = "frmElecciónAdmin";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnGenerarReportes;
        private System.Windows.Forms.Button btnAdminUsuarios;
        private System.Windows.Forms.Button btnEdicionCartelera;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnGestion;
        private System.Windows.Forms.Button btnCerrarSesion;
    }
}