using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agenda
{
    public partial class Form1 : Form
    {
        Agenda agenda = new Agenda();
        public Form1()
        {
            InitializeComponent();
        }
        private void limpiarTxT()
        {
            txtTelefono.Clear();
            txtNombre.Clear();
            txtApPaterno.Clear();
            txtApMaterno.Clear();
            txtEdad.Clear();
            txtCorreo.Clear();
        }
        private void btnBusqueda_Click(object sender, EventArgs e)
        {
            Contactos busqueda = agenda.buscar(Convert.ToInt32(txtTelefono.Text));
            if (busqueda != null)
            {
                txtTelefono.Text = busqueda.Telefono.ToString();
                txtNombre.Text = busqueda.Nombre;
                txtApPaterno.Text = busqueda.ApellidoPaterno;
                txtApMaterno.Text = busqueda.ApellidoMaterno;
                txtCorreo.Text = busqueda.Correo;
                txtEdad.Text = busqueda.Edad.ToString();
            }
            
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            
            if (agenda.eliminar(Convert.ToInt32(txtTelefono.Text)))
            {
                MessageBox.Show("Contacto eliminado");
            }
            else
            {
                MessageBox.Show("Contacto no encontrado");
            }
            limpiarTxT();
            
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Contactos NuevoContacto = new Contactos();
            NuevoContacto.Telefono = Convert.ToInt32(txtTelefono.Text); 
            NuevoContacto.Nombre = txtNombre.Text;
            NuevoContacto.ApellidoPaterno = txtApPaterno.Text;
            NuevoContacto.ApellidoMaterno = txtApMaterno.Text;
            NuevoContacto.Correo = txtCorreo.Text;
            NuevoContacto.Edad = Convert.ToInt32(txtEdad.Text);

            agenda.agregar(NuevoContacto);

            limpiarTxT();
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            Contactos NuevoContacto = new Contactos();
            NuevoContacto.Telefono = Convert.ToInt32(txtTelefono.Text);
            NuevoContacto.Nombre = txtNombre.Text;
            NuevoContacto.ApellidoPaterno = txtApPaterno.Text;
            NuevoContacto.ApellidoMaterno = txtApMaterno.Text;
            NuevoContacto.Correo = txtCorreo.Text;
            NuevoContacto.Edad = Convert.ToInt32(txtEdad.Text);

            agenda.agregar(NuevoContacto);

            limpiarTxT();
        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Contactos editar = agenda.buscar(Convert.ToInt32(txtTelefono.Text));
            if (editar != null)
            {
                editar.Telefono = Convert.ToInt32(txtTelefono.Text);
                editar.Nombre = txtNombre.Text;
                editar.ApellidoPaterno = txtApPaterno.Text;
                editar.ApellidoMaterno = txtApMaterno.Text;
                editar.Correo = txtCorreo.Text;
                editar.Edad = Convert.ToInt32(txtEdad.Text);
            }
            else MessageBox.Show("Contacto no encontrado");
        }

        private void btnInser_Click(object sender, EventArgs e)
        {
            Contactos NuevoContacto = new Contactos();
            NuevoContacto.Telefono = Convert.ToInt32(txtTelefono.Text);
            NuevoContacto.Nombre = txtNombre.Text;
            NuevoContacto.ApellidoPaterno = txtApPaterno.Text;
            NuevoContacto.ApellidoMaterno = txtApMaterno.Text;
            NuevoContacto.Correo = txtCorreo.Text;
            NuevoContacto.Edad = Convert.ToInt32(txtEdad.Text);

           // agenda.insertar(NuevoContacto,Convert.ToInt32(txtLugar.Text));

            limpiarTxT();
        }

        

        private void btn_eliminarPrimero_Click(object sender, EventArgs e)
        {
            agenda.eliminar_primero();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            agenda.eliminar_ultimo();
        }

        private void btn_invertirLista_Click(object sender, EventArgs e)
        {
            agenda.invertirLista();
        }

        private void btnMostarInserso_Click(object sender, EventArgs e)
        {
            txtMostrar.Text = agenda.reporteInverso();
        }
    }
}
