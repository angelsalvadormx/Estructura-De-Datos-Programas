using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace graficos_por_tortuga
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Tortuga torgua1 = new Tortuga();


        private void btn_mostrar_Click(object sender, EventArgs e)
        {
             lblResultado.Text=torgua1.ToString();
        }

        private void btn_numero_Click(object sender, EventArgs e)
        {
            if (!torgua1.Avanza(Convert.ToInt32(txt_numero.Text)))
            {
                MessageBox.Show("Posicion fuera de los limites");
            }
        }

        private void btn_PlumaAbajo_Click(object sender, EventArgs e)
        {
            torgua1.pluma = true;
        }

        private void btn_PlumaArriba_Click(object sender, EventArgs e)
        {
            torgua1.pluma = false;
        }

        private void btn_G_derecha_Click(object sender, EventArgs e)
        {
            torgua1.Girar_Derecha();
        }
    }
}
