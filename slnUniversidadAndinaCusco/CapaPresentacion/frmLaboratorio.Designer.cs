
namespace CapaPresentacion
{
    partial class frmLaboratorio
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
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.txtReferencia = new System.Windows.Forms.TextBox();
            this.btnLeer = new System.Windows.Forms.Button();
            this.btnEscribir = new System.Windows.Forms.Button();
            this.btnEstudiar = new System.Windows.Forms.Button();
            this.btnTrabajar = new System.Windows.Forms.Button();
            this.btnAprobarExamen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(37, 37);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(228, 22);
            this.txtNombre.TabIndex = 0;
            this.txtNombre.TextChanged += new System.EventHandler(this.txtNombre_TextChanged);
            // 
            // txtFacultad
            // 
            this.txtFacultad.Location = new System.Drawing.Point(37, 92);
            this.txtFacultad.Name = "txtFacultad";
            this.txtFacultad.Size = new System.Drawing.Size(228, 22);
            this.txtFacultad.TabIndex = 1;
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(37, 155);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(228, 22);
            this.txtNumero.TabIndex = 2;
            // 
            // txtReferencia
            // 
            this.txtReferencia.Location = new System.Drawing.Point(37, 213);
            this.txtReferencia.Name = "txtReferencia";
            this.txtReferencia.Size = new System.Drawing.Size(228, 22);
            this.txtReferencia.TabIndex = 3;
            // 
            // btnLeer
            // 
            this.btnLeer.Location = new System.Drawing.Point(302, 62);
            this.btnLeer.Name = "btnLeer";
            this.btnLeer.Size = new System.Drawing.Size(75, 23);
            this.btnLeer.TabIndex = 4;
            this.btnLeer.Text = "Leer";
            this.btnLeer.UseVisualStyleBackColor = true;
            this.btnLeer.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnEscribir
            // 
            this.btnEscribir.Location = new System.Drawing.Point(302, 135);
            this.btnEscribir.Name = "btnEscribir";
            this.btnEscribir.Size = new System.Drawing.Size(75, 23);
            this.btnEscribir.TabIndex = 5;
            this.btnEscribir.Text = "Escribir ";
            this.btnEscribir.UseVisualStyleBackColor = true;
            this.btnEscribir.Click += new System.EventHandler(this.btnEscribir_Click);
            // 
            // btnEstudiar
            // 
            this.btnEstudiar.Location = new System.Drawing.Point(37, 275);
            this.btnEstudiar.Name = "btnEstudiar";
            this.btnEstudiar.Size = new System.Drawing.Size(76, 34);
            this.btnEstudiar.TabIndex = 6;
            this.btnEstudiar.Text = "Estudiar ";
            this.btnEstudiar.UseVisualStyleBackColor = true;
            this.btnEstudiar.Click += new System.EventHandler(this.btnEstudiar_Click);
            // 
            // btnTrabajar
            // 
            this.btnTrabajar.Location = new System.Drawing.Point(190, 275);
            this.btnTrabajar.Name = "btnTrabajar";
            this.btnTrabajar.Size = new System.Drawing.Size(75, 34);
            this.btnTrabajar.TabIndex = 7;
            this.btnTrabajar.Text = "trabajar";
            this.btnTrabajar.UseVisualStyleBackColor = true;
            this.btnTrabajar.Click += new System.EventHandler(this.btnTrabajar_Click);
            // 
            // btnAprobarExamen
            // 
            this.btnAprobarExamen.Location = new System.Drawing.Point(59, 333);
            this.btnAprobarExamen.Name = "btnAprobarExamen";
            this.btnAprobarExamen.Size = new System.Drawing.Size(195, 29);
            this.btnAprobarExamen.TabIndex = 8;
            this.btnAprobarExamen.Text = "Aprobar Examen ";
            this.btnAprobarExamen.UseVisualStyleBackColor = true;
            this.btnAprobarExamen.Click += new System.EventHandler(this.btnAprobarExamen_Click);
            // 
            // frmLaboratorio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(393, 407);
            this.Controls.Add(this.btnAprobarExamen);
            this.Controls.Add(this.btnTrabajar);
            this.Controls.Add(this.btnEstudiar);
            this.Controls.Add(this.btnEscribir);
            this.Controls.Add(this.btnLeer);
            this.Controls.Add(this.txtReferencia);
            this.Controls.Add(this.txtNumero);
            this.Controls.Add(this.txtFacultad);
            this.Controls.Add(this.txtNombre);
            this.Name = "frmLaboratorio";
            this.Text = "Trabajar con la clase Laboratorio";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtFacultad;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.TextBox txtReferencia;
        private System.Windows.Forms.Button btnLeer;
        private System.Windows.Forms.Button btnEscribir;
        private System.Windows.Forms.Button btnEstudiar;
        private System.Windows.Forms.Button btnTrabajar;
        private System.Windows.Forms.Button btnAprobarExamen;
    }
}