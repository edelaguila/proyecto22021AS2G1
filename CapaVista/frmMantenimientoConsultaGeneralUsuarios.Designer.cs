
namespace CapaVista
{
    partial class frmMantenimientoConsultaGeneralUsuarios
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.dvgConsulta = new System.Windows.Forms.DataGridView();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.btnActualizar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_consulta = new System.Windows.Forms.Button();
            this.btnRegreso = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgConsulta)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumBlue;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(-2, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(794, 49);
            this.panel1.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(3, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(379, 40);
            this.label4.TabIndex = 0;
            this.label4.Text = "Consulta General Usuarios";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // dvgConsulta
            // 
            this.dvgConsulta.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgConsulta.Location = new System.Drawing.Point(42, 158);
            this.dvgConsulta.Margin = new System.Windows.Forms.Padding(2);
            this.dvgConsulta.Name = "dvgConsulta";
            this.dvgConsulta.ReadOnly = true;
            this.dvgConsulta.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dvgConsulta.RowHeadersWidth = 51;
            this.dvgConsulta.RowTemplate.Height = 24;
            this.dvgConsulta.Size = new System.Drawing.Size(669, 236);
            this.dvgConsulta.TabIndex = 2;
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(186, 429);
            this.btnFiltrar.Margin = new System.Windows.Forms.Padding(2);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(105, 46);
            this.btnFiltrar.TabIndex = 3;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            // 
            // btnActualizar
            // 
            this.btnActualizar.Location = new System.Drawing.Point(342, 429);
            this.btnActualizar.Margin = new System.Windows.Forms.Padding(2);
            this.btnActualizar.Name = "btnActualizar";
            this.btnActualizar.Size = new System.Drawing.Size(105, 46);
            this.btnActualizar.TabIndex = 4;
            this.btnActualizar.Text = "Actualizar";
            this.btnActualizar.UseVisualStyleBackColor = true;
            this.btnActualizar.Click += new System.EventHandler(this.btnActualizar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(489, 429);
            this.button1.Margin = new System.Windows.Forms.Padding(2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 46);
            this.button1.TabIndex = 9;
            this.button1.Text = "Limpiar";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // btn_consulta
            // 
            this.btn_consulta.Location = new System.Drawing.Point(296, 71);
            this.btn_consulta.Name = "btn_consulta";
            this.btn_consulta.Size = new System.Drawing.Size(173, 60);
            this.btn_consulta.TabIndex = 10;
            this.btn_consulta.Text = "Consultar";
            this.btn_consulta.UseVisualStyleBackColor = true;
            this.btn_consulta.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnRegreso
            // 
            this.btnRegreso.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegreso.Location = new System.Drawing.Point(658, 474);
            this.btnRegreso.Name = "btnRegreso";
            this.btnRegreso.Size = new System.Drawing.Size(75, 23);
            this.btnRegreso.TabIndex = 11;
            this.btnRegreso.Text = "Regresar";
            this.btnRegreso.UseVisualStyleBackColor = true;
            this.btnRegreso.Click += new System.EventHandler(this.btnRegreso_Click);
            // 
            // frmMantenimientoConsultaGeneralUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(745, 509);
            this.Controls.Add(this.btnRegreso);
            this.Controls.Add(this.btn_consulta);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnActualizar);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.dvgConsulta);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmMantenimientoConsultaGeneralUsuarios";
            this.Text = "frmConsultaGeneralUsuarios";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgConsulta)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dvgConsulta;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.Button btnActualizar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_consulta;
        private System.Windows.Forms.Button btnRegreso;
    }
}