
namespace CapaVista
{
    partial class frmEdiciónCartelera
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
            this.panel3 = new System.Windows.Forms.Panel();
            this.label17 = new System.Windows.Forms.Label();
            this.btnRegreso = new System.Windows.Forms.Button();
            this.btnPeliculas = new System.Windows.Forms.Button();
            this.btnDerechos = new System.Windows.Forms.Button();
            this.btnHorarios = new System.Windows.Forms.Button();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.MediumBlue;
            this.panel3.Controls.Add(this.label17);
            this.panel3.Location = new System.Drawing.Point(0, -1);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(773, 53);
            this.panel3.TabIndex = 42;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.MediumBlue;
            this.label17.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(3, 0);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(250, 40);
            this.label17.TabIndex = 2;
            this.label17.Text = "Edición Cartelera";
            // 
            // btnRegreso
            // 
            this.btnRegreso.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegreso.Location = new System.Drawing.Point(675, 421);
            this.btnRegreso.Name = "btnRegreso";
            this.btnRegreso.Size = new System.Drawing.Size(85, 23);
            this.btnRegreso.TabIndex = 43;
            this.btnRegreso.Text = "Regresar";
            this.btnRegreso.UseVisualStyleBackColor = true;
            this.btnRegreso.Click += new System.EventHandler(this.button6_Click);
            // 
            // btnPeliculas
            // 
            this.btnPeliculas.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnPeliculas.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPeliculas.ForeColor = System.Drawing.Color.White;
            this.btnPeliculas.Location = new System.Drawing.Point(74, 163);
            this.btnPeliculas.Name = "btnPeliculas";
            this.btnPeliculas.Size = new System.Drawing.Size(244, 43);
            this.btnPeliculas.TabIndex = 44;
            this.btnPeliculas.Text = "EDICIÓN PELÍCULAS";
            this.btnPeliculas.UseVisualStyleBackColor = false;
            this.btnPeliculas.Click += new System.EventHandler(this.btnPeliculas_Click);
            // 
            // btnDerechos
            // 
            this.btnDerechos.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnDerechos.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDerechos.ForeColor = System.Drawing.Color.White;
            this.btnDerechos.Location = new System.Drawing.Point(410, 163);
            this.btnDerechos.Name = "btnDerechos";
            this.btnDerechos.Size = new System.Drawing.Size(244, 43);
            this.btnDerechos.TabIndex = 45;
            this.btnDerechos.Text = "EDICIÓN DERECHOS";
            this.btnDerechos.UseVisualStyleBackColor = false;
            // 
            // btnHorarios
            // 
            this.btnHorarios.BackColor = System.Drawing.SystemColors.HotTrack;
            this.btnHorarios.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHorarios.ForeColor = System.Drawing.Color.White;
            this.btnHorarios.Location = new System.Drawing.Point(238, 296);
            this.btnHorarios.Name = "btnHorarios";
            this.btnHorarios.Size = new System.Drawing.Size(244, 43);
            this.btnHorarios.TabIndex = 46;
            this.btnHorarios.Text = "EDICIÓN HORARIOS";
            this.btnHorarios.UseVisualStyleBackColor = false;
            // 
            // frmEdiciónCartelera
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(772, 468);
            this.Controls.Add(this.btnHorarios);
            this.Controls.Add(this.btnDerechos);
            this.Controls.Add(this.btnPeliculas);
            this.Controls.Add(this.btnRegreso);
            this.Controls.Add(this.panel3);
            this.Name = "frmEdiciónCartelera";
            this.Text = "frmEdiciónCartelera";
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btnRegreso;
        private System.Windows.Forms.Button btnPeliculas;
        private System.Windows.Forms.Button btnDerechos;
        private System.Windows.Forms.Button btnHorarios;
    }
}