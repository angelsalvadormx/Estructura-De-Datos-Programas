using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Carreraanimales
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_comenzar_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            Tortuga t = new Tortuga();
            Liebre l = new Liebre();

            while(t.Pasos< 80 && l.Pasos < 80)
            {
                t.avanzar();
                textBox1.Text += t.ToString() + Environment.NewLine;
                l.avanzar();
                textBox1.Text += l.ToString() + Environment.NewLine;
            }
            if (t.Pasos >= 80 && l.Pasos >= 80)
            {
                textBox1.Text += "Empate";
            }
            if (t.Pasos >= 80)
            {
                textBox1.Text += "Gana Tortuga ";
            }
            if (l.Pasos >= 80)
            {
                textBox1.Text += "Gana Liebre ";
            }
            
        }
    }
}
