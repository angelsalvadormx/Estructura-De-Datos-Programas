namespace ListasCirculares
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button_agregarFinal = new System.Windows.Forms.Button();
            this.button_buscar = new System.Windows.Forms.Button();
            this.button_eliminarUltimo = new System.Windows.Forms.Button();
            this.button_eliminarInicio = new System.Windows.Forms.Button();
            this.button_eliminar = new System.Windows.Forms.Button();
            this.button_listar = new System.Windows.Forms.Button();
            this.button_insertar = new System.Windows.Forms.Button();
            this.button_ruta = new System.Windows.Forms.Button();
            this.textBox_nombre = new System.Windows.Forms.TextBox();
            this.textBox_duracion = new System.Windows.Forms.TextBox();
            this.textBox_pos = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_rutaNombre = new System.Windows.Forms.TextBox();
            this.textBox_rutaInicio = new System.Windows.Forms.TextBox();
            this.textBox_rutaFin = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 14);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(309, 279);
            this.textBox1.TabIndex = 0;
            // 
            // button_agregarFinal
            // 
            this.button_agregarFinal.Location = new System.Drawing.Point(374, 22);
            this.button_agregarFinal.Name = "button_agregarFinal";
            this.button_agregarFinal.Size = new System.Drawing.Size(105, 23);
            this.button_agregarFinal.TabIndex = 1;
            this.button_agregarFinal.Text = "Agregar Final";
            this.button_agregarFinal.UseVisualStyleBackColor = true;
            this.button_agregarFinal.Click += new System.EventHandler(this.button_agregarFinal_Click);
            // 
            // button_buscar
            // 
            this.button_buscar.Location = new System.Drawing.Point(374, 51);
            this.button_buscar.Name = "button_buscar";
            this.button_buscar.Size = new System.Drawing.Size(105, 23);
            this.button_buscar.TabIndex = 2;
            this.button_buscar.Text = "Buscar";
            this.button_buscar.UseVisualStyleBackColor = true;
            this.button_buscar.Click += new System.EventHandler(this.button_buscar_Click);
            // 
            // button_eliminarUltimo
            // 
            this.button_eliminarUltimo.Location = new System.Drawing.Point(374, 80);
            this.button_eliminarUltimo.Name = "button_eliminarUltimo";
            this.button_eliminarUltimo.Size = new System.Drawing.Size(105, 23);
            this.button_eliminarUltimo.TabIndex = 3;
            this.button_eliminarUltimo.Text = "Eliminar Último";
            this.button_eliminarUltimo.UseVisualStyleBackColor = true;
            this.button_eliminarUltimo.Click += new System.EventHandler(this.button_eliminarUltimo_Click);
            // 
            // button_eliminarInicio
            // 
            this.button_eliminarInicio.Location = new System.Drawing.Point(374, 109);
            this.button_eliminarInicio.Name = "button_eliminarInicio";
            this.button_eliminarInicio.Size = new System.Drawing.Size(105, 23);
            this.button_eliminarInicio.TabIndex = 4;
            this.button_eliminarInicio.Text = "Eliminar Inicio";
            this.button_eliminarInicio.UseVisualStyleBackColor = true;
            this.button_eliminarInicio.Click += new System.EventHandler(this.button_eliminarInicio_Click);
            // 
            // button_eliminar
            // 
            this.button_eliminar.Location = new System.Drawing.Point(374, 138);
            this.button_eliminar.Name = "button_eliminar";
            this.button_eliminar.Size = new System.Drawing.Size(105, 23);
            this.button_eliminar.TabIndex = 5;
            this.button_eliminar.Text = "Eliminar";
            this.button_eliminar.UseVisualStyleBackColor = true;
            this.button_eliminar.Click += new System.EventHandler(this.button_eliminar_Click);
            // 
            // button_listar
            // 
            this.button_listar.Location = new System.Drawing.Point(374, 167);
            this.button_listar.Name = "button_listar";
            this.button_listar.Size = new System.Drawing.Size(105, 23);
            this.button_listar.TabIndex = 6;
            this.button_listar.Text = "Listar";
            this.button_listar.UseVisualStyleBackColor = true;
            this.button_listar.Click += new System.EventHandler(this.button_listar_Click);
            // 
            // button_insertar
            // 
            this.button_insertar.Location = new System.Drawing.Point(374, 196);
            this.button_insertar.Name = "button_insertar";
            this.button_insertar.Size = new System.Drawing.Size(105, 23);
            this.button_insertar.TabIndex = 7;
            this.button_insertar.Text = "Insertar";
            this.button_insertar.UseVisualStyleBackColor = true;
            this.button_insertar.Click += new System.EventHandler(this.button_insertar_Click);
            // 
            // button_ruta
            // 
            this.button_ruta.Location = new System.Drawing.Point(374, 225);
            this.button_ruta.Name = "button_ruta";
            this.button_ruta.Size = new System.Drawing.Size(105, 23);
            this.button_ruta.TabIndex = 8;
            this.button_ruta.Text = "Ruta";
            this.button_ruta.UseVisualStyleBackColor = true;
            this.button_ruta.Click += new System.EventHandler(this.button_ruta_Click);
            // 
            // textBox_nombre
            // 
            this.textBox_nombre.Location = new System.Drawing.Point(561, 51);
            this.textBox_nombre.Name = "textBox_nombre";
            this.textBox_nombre.Size = new System.Drawing.Size(100, 20);
            this.textBox_nombre.TabIndex = 9;
            // 
            // textBox_duracion
            // 
            this.textBox_duracion.Location = new System.Drawing.Point(561, 77);
            this.textBox_duracion.Name = "textBox_duracion";
            this.textBox_duracion.Size = new System.Drawing.Size(100, 20);
            this.textBox_duracion.TabIndex = 10;
            // 
            // textBox_pos
            // 
            this.textBox_pos.Location = new System.Drawing.Point(582, 128);
            this.textBox_pos.Name = "textBox_pos";
            this.textBox_pos.Size = new System.Drawing.Size(43, 20);
            this.textBox_pos.TabIndex = 12;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(505, 58);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 13;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(505, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 14;
            this.label2.Text = "Duración";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(529, 131);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "Posición";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(508, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 17;
            this.label3.Text = "Base";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(508, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 18;
            this.label5.Text = "Inicio";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(508, 232);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(21, 13);
            this.label6.TabIndex = 19;
            this.label6.Text = "Fin";
            // 
            // textBox_rutaNombre
            // 
            this.textBox_rutaNombre.Location = new System.Drawing.Point(546, 179);
            this.textBox_rutaNombre.Name = "textBox_rutaNombre";
            this.textBox_rutaNombre.Size = new System.Drawing.Size(100, 20);
            this.textBox_rutaNombre.TabIndex = 20;
            // 
            // textBox_rutaInicio
            // 
            this.textBox_rutaInicio.Location = new System.Drawing.Point(546, 205);
            this.textBox_rutaInicio.Name = "textBox_rutaInicio";
            this.textBox_rutaInicio.Size = new System.Drawing.Size(100, 20);
            this.textBox_rutaInicio.TabIndex = 21;
            // 
            // textBox_rutaFin
            // 
            this.textBox_rutaFin.Location = new System.Drawing.Point(546, 231);
            this.textBox_rutaFin.Name = "textBox_rutaFin";
            this.textBox_rutaFin.Size = new System.Drawing.Size(100, 20);
            this.textBox_rutaFin.TabIndex = 22;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(508, 155);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(30, 13);
            this.label7.TabIndex = 23;
            this.label7.Text = "Ruta";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(505, 22);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(79, 13);
            this.label8.TabIndex = 24;
            this.label8.Text = "Crear una base";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(499, 112);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(43, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = "Buscar ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(802, 534);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox_rutaFin);
            this.Controls.Add(this.textBox_rutaInicio);
            this.Controls.Add(this.textBox_rutaNombre);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBox_pos);
            this.Controls.Add(this.textBox_duracion);
            this.Controls.Add(this.textBox_nombre);
            this.Controls.Add(this.button_ruta);
            this.Controls.Add(this.button_insertar);
            this.Controls.Add(this.button_listar);
            this.Controls.Add(this.button_eliminar);
            this.Controls.Add(this.button_eliminarInicio);
            this.Controls.Add(this.button_eliminarUltimo);
            this.Controls.Add(this.button_buscar);
            this.Controls.Add(this.button_agregarFinal);
            this.Controls.Add(this.textBox1);
            this.Name = "Form1";
            this.Text = "Control de bases";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button_agregarFinal;
        private System.Windows.Forms.Button button_buscar;
        private System.Windows.Forms.Button button_eliminarUltimo;
        private System.Windows.Forms.Button button_eliminarInicio;
        private System.Windows.Forms.Button button_eliminar;
        private System.Windows.Forms.Button button_listar;
        private System.Windows.Forms.Button button_insertar;
        private System.Windows.Forms.Button button_ruta;
        private System.Windows.Forms.TextBox textBox_nombre;
        private System.Windows.Forms.TextBox textBox_duracion;
        private System.Windows.Forms.TextBox textBox_pos;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_rutaNombre;
        private System.Windows.Forms.TextBox textBox_rutaInicio;
        private System.Windows.Forms.TextBox textBox_rutaFin;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}

