
namespace CapaVista
{
    partial class frmMantenimientoDePeliculas
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
            this.txtNom = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbClasi = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.cmbGenero = new System.Windows.Forms.ComboBox();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtIdioma = new System.Windows.Forms.TextBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.btnRegreso = new System.Windows.Forms.Button();
            this.txtSinopsis = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cmbSub = new System.Windows.Forms.ComboBox();
            this.btnConsulta = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumBlue;
            this.panel1.Controls.Add(this.label4);
            this.panel1.Location = new System.Drawing.Point(-8, 2);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(863, 60);
            this.panel1.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(4, 0);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(504, 50);
            this.label4.TabIndex = 0;
            this.label4.Text = "Mantenimiento de Películas";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(227, 74);
            this.txtNom.Location = new System.Drawing.Point(327, 127);
            this.txtNom.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(269, 22);
            this.txtNom.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(130, 126);
            this.label3.Location = new System.Drawing.Point(197, 191);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(114, 23);
            this.label3.TabIndex = 11;
            this.label3.Text = "Clasificación:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(149, 77);
            this.label2.Location = new System.Drawing.Point(223, 130);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 23);
            this.label2.TabIndex = 10;
            this.label2.Text = "Nombre:";
            // 
            // cmbClasi
            // 
            this.cmbClasi.FormattingEnabled = true;
            this.cmbClasi.Items.AddRange(new object[] {
            "A ",
            "PG ",
            "PG13",
            "R",
            "NC17 "});
            this.cmbClasi.Location = new System.Drawing.Point(227, 122);
            this.cmbClasi.Name = "cmbClasi";
            this.cmbClasi.Size = new System.Drawing.Size(203, 21);
            this.cmbClasi.TabIndex = 13;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "A -(Apta para todo público)",
            "PG (Sugiere la compañía de un adulto para los menores de 10 años)",
            "PG-13 (Sugiere la compañía de un adulto para los menores de 13 años)",
            "R- (No apta para menores de 17 años si no es con la compañía de un adulto)",
            "NC-17 (Contenido sólo apto para mayores de 18años)",
            ""});
            this.comboBox1.Location = new System.Drawing.Point(327, 186);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(269, 24);
            this.comboBox1.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(155, 165);
            this.label1.Location = new System.Drawing.Point(231, 239);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 23);
            this.label1.TabIndex = 14;
            this.label1.Text = "Género:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(130, 204);
            this.label5.Location = new System.Drawing.Point(197, 287);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 23);
            this.label5.TabIndex = 15;
            this.label5.Text = "Subtitulado";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(148, 243);
            this.label6.Location = new System.Drawing.Point(221, 335);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(66, 23);
            this.label6.TabIndex = 16;
            this.label6.Text = "Idioma";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(148, 281);
            this.label7.Location = new System.Drawing.Point(221, 382);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 23);
            this.label7.TabIndex = 17;
            this.label7.Text = "Precio:";
            // 
            // cmbGenero
            // 
            this.cmbGenero.FormattingEnabled = true;
            this.cmbGenero.Items.AddRange(new object[] {
            "Acción",
            "Comedia",
            "Romance",
            "Drama",
            "Terror",
            "Ciencia Ficción",
            "Fantasía",
            "Musical",
            "Animada",
            "Misterio"});
            this.cmbGenero.Location = new System.Drawing.Point(227, 161);
            this.cmbGenero.Name = "cmbGenero";
            this.cmbGenero.Size = new System.Drawing.Size(203, 21);
            this.cmbGenero.TabIndex = 18;
            this.comboBox2.Location = new System.Drawing.Point(327, 234);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(269, 24);
            this.comboBox2.TabIndex = 18;
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(227, 278);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(203, 20);
            this.txtPrecio.TabIndex = 20;
            this.textBox1.Location = new System.Drawing.Point(327, 283);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(269, 22);
            this.textBox1.TabIndex = 19;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(327, 378);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(269, 22);
            this.textBox2.TabIndex = 20;
            // 
            // txtIdioma
            // 
            this.txtIdioma.Location = new System.Drawing.Point(227, 240);
            this.txtIdioma.Name = "txtIdioma";
            this.txtIdioma.Size = new System.Drawing.Size(203, 20);
            this.txtIdioma.TabIndex = 21;
            this.textBox3.Location = new System.Drawing.Point(327, 331);
            this.textBox3.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(269, 22);
            this.textBox3.TabIndex = 21;
            // 
            // btnIngresar
            // 
            this.btnIngresar.Location = new System.Drawing.Point(253, 368);
            this.btnIngresar.Location = new System.Drawing.Point(252, 442);
            this.btnIngresar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(149, 46);
            this.btnIngresar.TabIndex = 22;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // btnRegreso
            // 
            this.btnRegreso.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRegreso.Location = new System.Drawing.Point(659, 610);
            this.btnRegreso.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnRegreso.Name = "btnRegreso";
            this.btnRegreso.Size = new System.Drawing.Size(113, 28);
            this.btnRegreso.TabIndex = 44;
            this.btnRegreso.Text = "Regresar";
            this.btnRegreso.UseVisualStyleBackColor = true;
            this.btnRegreso.Click += new System.EventHandler(this.btnRegreso_Click);
            // 
            // txtSinopsis
            // 
            this.txtSinopsis.Location = new System.Drawing.Point(227, 319);
            this.txtSinopsis.Name = "txtSinopsis";
            this.txtSinopsis.Size = new System.Drawing.Size(203, 20);
            this.txtSinopsis.TabIndex = 46;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(148, 322);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(63, 17);
            this.label8.TabIndex = 45;
            this.label8.Text = "Sinopsis:";
            // 
            // cmbSub
            // 
            this.cmbSub.FormattingEnabled = true;
            this.cmbSub.Items.AddRange(new object[] {
            "SI",
            "NO"});
            this.cmbSub.Location = new System.Drawing.Point(227, 204);
            this.cmbSub.Name = "cmbSub";
            this.cmbSub.Size = new System.Drawing.Size(203, 21);
            this.cmbSub.TabIndex = 47;
            // 
            // btnConsulta
            // 
            this.btnConsulta.Location = new System.Drawing.Point(458, 442);
            this.btnConsulta.Margin = new System.Windows.Forms.Padding(4);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(149, 46);
            this.btnConsulta.TabIndex = 45;
            this.btnConsulta.Text = "Consultar";
            this.btnConsulta.UseVisualStyleBackColor = true;
            this.btnConsulta.Click += new System.EventHandler(this.btnConsulta_Click);
            // 
            // frmMantenimientoDePeliculas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(601, 531);
            this.Controls.Add(this.cmbSub);
            this.Controls.Add(this.txtSinopsis);
            this.Controls.Add(this.label8);
            this.ClientSize = new System.Drawing.Size(801, 654);
            this.Controls.Add(this.btnConsulta);
            this.Controls.Add(this.btnRegreso);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.txtIdioma);
            this.Controls.Add(this.txtPrecio);
            this.Controls.Add(this.cmbGenero);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbClasi);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmMantenimientoDePeliculas";
            this.Text = "frmMantenimientoDePeliculas";
            this.Load += new System.EventHandler(this.frmMantenimientoDePeliculas_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbClasi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cmbGenero;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtIdioma;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Button btnRegreso;
        private System.Windows.Forms.TextBox txtSinopsis;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cmbSub;
        private System.Windows.Forms.Button btnConsulta;
    }
}