using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bases
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Recorrido recorrido = new Recorrido();
        Base nuevo;
        private void button1_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            int duracion = Convert.ToInt32(txtTiempo.Text);
            nuevo = new Base(nombre, duracion);
            recorrido.agregarFinal(nuevo);

        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            txtResultado.Text= recorrido.listar();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Base resultado = recorrido.buscar(txtBuscar.Text);
            if (resultado != null)
            {
                txtResultado.Text = resultado.String();
            }
            else
            {
                txtResultado.Text = "Contacto no registrado";
            }
        }

        private void btnEliminarUltimo_Click(object sender, EventArgs e)
        {
            recorrido.eliminarUltimo();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            recorrido.eliminar(txtEliminar.Text);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            recorrido.eliminarInicio();
        }
    }
}
