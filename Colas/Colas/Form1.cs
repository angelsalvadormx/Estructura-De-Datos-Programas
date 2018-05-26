using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Colas
{
    public partial class Form1 : Form
    {
        int procesos = 0;
        int contador = 0;
        int sinProcesos= 0;
        int suma = 0;
        int sumaSinProceso = 0;
        Proceso inicio;
        string str = "";
        string strPendientes = "";
        Random r = new Random();


        public Form1()
        {
            InitializeComponent();
        }
       
        public void queue(Proceso n)
        {
            if (inicio == null)
            {
                inicio = n;
            }
            else
            {
                queue(n, inicio);
            }
        }
        private void queue(Proceso n, Proceso aux)
        {
            if (aux.Siguiente != null)
            {
                queue(n, aux.Siguiente);
            }
            else
            {
                aux.Siguiente = n;
            }
        }

        public Proceso pop()
        {
            Proceso aux = inicio;
            inicio = inicio.Siguiente;
            return aux;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 300; i++)
            {
                double rand = r.NextDouble();
                if (rand < .35)
                {
                    contador++;
                    Proceso n = new Proceso(r.Next(3, 14),contador);
                    queue(n);
                }

                if (inicio != null)
                {
                    if (inicio.Duracion > 0)
                    {
                        str += inicio.ToString();
                        inicio.Duracion--;
                        suma ++;

                    }
                    else
                    {
                        pop();
                        procesos++;
                    }

                }
                else
                {
                    sinProcesos++;
                }
                
            }
             while(inicio != null)
            {
                Proceso _pop = pop();
                sumaSinProceso += _pop.Duracion;
                strPendientes += _pop.ToString();

            }
            txtResultado.Text = str;
            txtCompletados.Text = procesos.ToString();
            txtVacicos.Text = sinProcesos.ToString();
            txtPendientes.Text = strPendientes;
            txtSuma.Text = sumaSinProceso.ToString();
            lblSuma.Text = suma.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
