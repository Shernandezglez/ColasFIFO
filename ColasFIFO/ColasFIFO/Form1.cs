using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColasFIFO
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Random prob = new Random();
        Estructura fifo = new Estructura();
        Proceso proceso;
        public int atendido, vacio, incompleto, sumaCiclos = 0;


        private void button1_Click(object sender, EventArgs e)
        {
            for(int i = 1; i <= 300; i++)
            {
                int r = prob.Next(1, 101);

                if(r <= 35)
                {
                    proceso = new Proceso();
                    fifo.encolar(proceso);
                }
                if(fifo.ver() != null)
                {
                    fifo.ver()._ciclo--;

                    if(fifo.ver()._ciclo == 0)
                    {
                        fifo.desencolar();
                        atendido++;
                    }
                }
                else
                {
                    vacio++;
                }
                if(i == 300 && fifo.ver()._ciclo > 0)
                {
                    
                    incompleto++;

                    sumaCiclos += fifo.ver()._ciclo;
                }
            }

            lblResultado.Text = "Ciclos atendidos: " + atendido + " | " 
                + " Vacio hasta el ciclo: " + vacio + " | " 
                + " Ciclos incompletos: " + incompleto + " | "
                + "Suma de ciclos incompletos: " + sumaCiclos;
        }
    }
}
