namespace graficos_por_tortuga
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblResultado = new System.Windows.Forms.Label();
            this.btn_PlumaAbajo = new System.Windows.Forms.Button();
            this.txt_numero = new System.Windows.Forms.TextBox();
            this.btn_PlumaArriba = new System.Windows.Forms.Button();
            this.btn_G_derecha = new System.Windows.Forms.Button();
            this.btn_G_izq = new System.Windows.Forms.Button();
            this.btn_numero = new System.Windows.Forms.Button();
            this.btn_mostrar = new System.Windows.Forms.Button();
            this.btnFin_dato = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(43, 81);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(0, 13);
            this.lblResultado.TabIndex = 0;
            // 
            // btn_PlumaAbajo
            // 
            this.btn_PlumaAbajo.Location = new System.Drawing.Point(238, 23);
            this.btn_PlumaAbajo.Name = "btn_PlumaAbajo";
            this.btn_PlumaAbajo.Size = new System.Drawing.Size(117, 23);
            this.btn_PlumaAbajo.TabIndex = 1;
            this.btn_PlumaAbajo.Text = "Pluma abajo";
            this.btn_PlumaAbajo.UseVisualStyleBackColor = true;
            this.btn_PlumaAbajo.Click += new System.EventHandler(this.btn_PlumaAbajo_Click);
            // 
            // txt_numero
            // 
            this.txt_numero.Location = new System.Drawing.Point(361, 139);
            this.txt_numero.Name = "txt_numero";
            this.txt_numero.Size = new System.Drawing.Size(100, 20);
            this.txt_numero.TabIndex = 2;
            // 
            // btn_PlumaArriba
            // 
            this.btn_PlumaArriba.Location = new System.Drawing.Point(238, 52);
            this.btn_PlumaArriba.Name = "btn_PlumaArriba";
            this.btn_PlumaArriba.Size = new System.Drawing.Size(117, 23);
            this.btn_PlumaArriba.TabIndex = 3;
            this.btn_PlumaArriba.Text = "Pluma arriba";
            this.btn_PlumaArriba.UseVisualStyleBackColor = true;
            this.btn_PlumaArriba.Click += new System.EventHandler(this.btn_PlumaArriba_Click);
            // 
            // btn_G_derecha
            // 
            this.btn_G_derecha.Location = new System.Drawing.Point(238, 81);
            this.btn_G_derecha.Name = "btn_G_derecha";
            this.btn_G_derecha.Size = new System.Drawing.Size(117, 23);
            this.btn_G_derecha.TabIndex = 4;
            this.btn_G_derecha.Text = "Girar ala derecha";
            this.btn_G_derecha.UseVisualStyleBackColor = true;
            this.btn_G_derecha.Click += new System.EventHandler(this.btn_G_derecha_Click);
            // 
            // btn_G_izq
            // 
            this.btn_G_izq.Location = new System.Drawing.Point(238, 110);
            this.btn_G_izq.Name = "btn_G_izq";
            this.btn_G_izq.Size = new System.Drawing.Size(117, 23);
            this.btn_G_izq.TabIndex = 5;
            this.btn_G_izq.Text = "Girar ala izq";
            this.btn_G_izq.UseVisualStyleBackColor = true;
            // 
            // btn_numero
            // 
            this.btn_numero.Location = new System.Drawing.Point(238, 139);
            this.btn_numero.Name = "btn_numero";
            this.btn_numero.Size = new System.Drawing.Size(117, 23);
            this.btn_numero.TabIndex = 6;
            this.btn_numero.Text = "Avanza";
            this.btn_numero.UseVisualStyleBackColor = true;
            this.btn_numero.Click += new System.EventHandler(this.btn_numero_Click);
            // 
            // btn_mostrar
            // 
            this.btn_mostrar.Location = new System.Drawing.Point(238, 168);
            this.btn_mostrar.Name = "btn_mostrar";
            this.btn_mostrar.Size = new System.Drawing.Size(117, 23);
            this.btn_mostrar.TabIndex = 7;
            this.btn_mostrar.Text = "Mostrar";
            this.btn_mostrar.UseVisualStyleBackColor = true;
            this.btn_mostrar.Click += new System.EventHandler(this.btn_mostrar_Click);
            // 
            // btnFin_dato
            // 
            this.btnFin_dato.Location = new System.Drawing.Point(238, 197);
            this.btnFin_dato.Name = "btnFin_dato";
            this.btnFin_dato.Size = new System.Drawing.Size(117, 23);
            this.btnFin_dato.TabIndex = 8;
            this.btnFin_dato.Text = "Fin de dato";
            this.btnFin_dato.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 377);
            this.Controls.Add(this.btnFin_dato);
            this.Controls.Add(this.btn_mostrar);
            this.Controls.Add(this.btn_numero);
            this.Controls.Add(this.btn_G_izq);
            this.Controls.Add(this.btn_G_derecha);
            this.Controls.Add(this.btn_PlumaArriba);
            this.Controls.Add(this.txt_numero);
            this.Controls.Add(this.btn_PlumaAbajo);
            this.Controls.Add(this.lblResultado);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblResultado;
        private System.Windows.Forms.Button btn_PlumaAbajo;
        private System.Windows.Forms.TextBox txt_numero;
        private System.Windows.Forms.Button btn_PlumaArriba;
        private System.Windows.Forms.Button btn_G_derecha;
        private System.Windows.Forms.Button btn_G_izq;
        private System.Windows.Forms.Button btn_numero;
        private System.Windows.Forms.Button btn_mostrar;
        private System.Windows.Forms.Button btnFin_dato;
    }
}

