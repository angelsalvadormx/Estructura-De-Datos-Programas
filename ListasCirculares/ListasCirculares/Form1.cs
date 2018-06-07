using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListasCirculares
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Recorrido recorrido = new Recorrido();
        private void limpiarTxT()
        {
            textBox_nombre.Clear();
            textBox_duracion.Clear();
        }

        private void button_agregarFinal_Click(object sender, EventArgs e)
        {
            string Nombre = textBox_nombre.Text;
            int Duracion = Convert.ToInt32(textBox_duracion.Text);
            Base nueva = new Base(Nombre,Duracion);
            recorrido.agregarFinal(nueva);
            limpiarTxT();
        }

        private void button_buscar_Click(object sender, EventArgs e)
        {
            Base busqueda = recorrido.buscar(textBox_nombre.Text);
            if (busqueda != null)
            {
                textBox1.Text = busqueda.ToString();
            }
            else
            {
                MessageBox.Show("No se ha encontrado la base");
            }
            limpiarTxT();
        }

        private void button_eliminarUltimo_Click(object sender, EventArgs e)
        {
            recorrido.eliminarUltimo();
            limpiarTxT();
        }

        private void button_eliminarInicio_Click(object sender, EventArgs e)
        {
            recorrido.eliminarInicio();
            limpiarTxT();
        }

        private void button_eliminar_Click(object sender, EventArgs e)
        {
            recorrido.eliminar(textBox_nombre.Text);
        }

        private void button_listar_Click(object sender, EventArgs e)
        {
            textBox1.Text = recorrido.listar();
            limpiarTxT();
        }

        private void button_insertar_Click(object sender, EventArgs e)
        {
            string Nombre = textBox_nombre.Text;
            int Duracion = Convert.ToInt32(textBox_duracion.Text);
            Base nueva = new Base(Nombre, Duracion);
            recorrido.insertar(nueva,Convert.ToInt32(textBox_pos.Text));
            limpiarTxT();
        }

        private void button_ruta_Click(object sender, EventArgs e)
        {
            string nombre = textBox_rutaNombre.Text;
            string inicio = textBox_rutaInicio.Text;
            string fin = textBox_rutaFin.Text;
            textBox1.Text = recorrido.ruta(nombre,inicio,fin);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
