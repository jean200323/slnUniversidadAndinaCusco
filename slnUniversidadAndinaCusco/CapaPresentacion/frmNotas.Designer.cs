
namespace CapaPresentacion
{
    partial class frmNotas
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
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtFacultad = new System.Windows.Forms.TextBox();
            this.txtNota = new System.Windows.Forms.TextBox();
            this.txtCreditos = new System.Windows.Forms.TextBox();
            this.btnLeer = new System.Windows.Forms.Button();
            this.btnEscrbrir = new System.Windows.Forms.Button();
            this.btnEstudiar = new System.Windows.Forms.Button();
            this.btnTrabajar = new System.Windows.Forms.Button();
            this.btnAprobar = new System.Windows.Forms.Button();
            this.btnDesaprobar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(32, 40);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(211, 22);
            this.txtNombre.TabIndex = 0;
            this.txtNombre.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtFacultad
            // 
            this.txtFacultad.Location = new System.Drawing.Point(32, 87);
            this.txtFacultad.Name = "txtFacultad";
            this.txtFacultad.Size = new System.Drawing.Size(211, 22);
            this.txtFacultad.TabIndex = 1;
            // 
            // txtNota
            // 
            this.txtNota.Location = new System.Drawing.Point(32, 139);
            this.txtNota.Name = "txtNota";
            this.txtNota.Size = new System.Drawing.Size(211, 22);
            this.txtNota.TabIndex = 2;
            // 
            // txtCreditos
            // 
            this.txtCreditos.Location = new System.Drawing.Point(32, 184);
            this.txtCreditos.Name = "txtCreditos";
            this.txtCreditos.Size = new System.Drawing.Size(211, 22);
            this.txtCreditos.TabIndex = 3;
            this.txtCreditos.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // btnLeer
            // 
            this.btnLeer.Location = new System.Drawing.Point(274, 63);
            this.btnLeer.Name = "btnLeer";
            this.btnLeer.Size = new System.Drawing.Size(75, 23);
            this.btnLeer.TabIndex = 4;
            this.btnLeer.Text = "Leer";
            this.btnLeer.UseVisualStyleBackColor = true;
            this.btnLeer.Click += new System.EventHandler(this.btnLeer_Click);
            // 
            // btnEscrbrir
            // 
            this.btnEscrbrir.Location = new System.Drawing.Point(274, 120);
            this.btnEscrbrir.Name = "btnEscrbrir";
            this.btnEscrbrir.Size = new System.Drawing.Size(75, 23);
            this.btnEscrbrir.TabIndex = 5;
            this.btnEscrbrir.Text = "Escrbrir";
            this.btnEscrbrir.UseVisualStyleBackColor = true;
            this.btnEscrbrir.Click += new System.EventHandler(this.btnEscrbrir_Click);
            // 
            // btnEstudiar
            // 
            this.btnEstudiar.Location = new System.Drawing.Point(32, 248);
            this.btnEstudiar.Name = "btnEstudiar";
            this.btnEstudiar.Size = new System.Drawing.Size(75, 33);
            this.btnEstudiar.TabIndex = 6;
            this.btnEstudiar.Text = "Estudiar";
            this.btnEstudiar.UseVisualStyleBackColor = true;
            this.btnEstudiar.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnTrabajar
            // 
            this.btnTrabajar.Location = new System.Drawing.Point(168, 248);
            this.btnTrabajar.Name = "btnTrabajar";
            this.btnTrabajar.Size = new System.Drawing.Size(75, 33);
            this.btnTrabajar.TabIndex = 7;
            this.btnTrabajar.Text = "Trabajar";
            this.btnTrabajar.UseVisualStyleBackColor = true;
            this.btnTrabajar.Click += new System.EventHandler(this.btnTrabajar_Click);
            // 
            // btnAprobar
            // 
            this.btnAprobar.Location = new System.Drawing.Point(32, 319);
            this.btnAprobar.Name = "btnAprobar";
            this.btnAprobar.Size = new System.Drawing.Size(75, 32);
            this.btnAprobar.TabIndex = 8;
            this.btnAprobar.Text = "Aprobar";
            this.btnAprobar.UseVisualStyleBackColor = true;
            this.btnAprobar.Click += new System.EventHandler(this.btnAprobar_Click);
            // 
            // btnDesaprobar
            // 
            this.btnDesaprobar.Location = new System.Drawing.Point(153, 319);
            this.btnDesaprobar.Name = "btnDesaprobar";
            this.btnDesaprobar.Size = new System.Drawing.Size(90, 33);
            this.btnDesaprobar.TabIndex = 9;
            this.btnDesaprobar.Text = "Desaprobar";
            this.btnDesaprobar.UseVisualStyleBackColor = true;
            this.btnDesaprobar.Click += new System.EventHandler(this.btnDesaprobar_Click);
            // 
            // frmNotas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(367, 373);
            this.Controls.Add(this.btnDesaprobar);
            this.Controls.Add(this.btnAprobar);
            this.Controls.Add(this.btnTrabajar);
            this.Controls.Add(this.btnEstudiar);
            this.Controls.Add(this.btnEscrbrir);
            this.Controls.Add(this.btnLeer);
            this.Controls.Add(this.txtCreditos);
            this.Controls.Add(this.txtNota);
            this.Controls.Add(this.txtFacultad);
            this.Controls.Add(this.txtNombre);
            this.Name = "frmNotas";
            this.Text = "Trabajar con la clase Notas";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtFacultad;
        private System.Windows.Forms.TextBox txtNota;
        private System.Windows.Forms.TextBox txtCreditos;
        private System.Windows.Forms.Button btnLeer;
        private System.Windows.Forms.Button btnEscrbrir;
        private System.Windows.Forms.Button btnEstudiar;
        private System.Windows.Forms.Button btnTrabajar;
        private System.Windows.Forms.Button btnAprobar;
        private System.Windows.Forms.Button btnDesaprobar;
    }
}