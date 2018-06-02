using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColasFIFO
{
    class Estructura
    {
        Proceso inicio = null;

        public void encolar(Proceso nuevo)
        {
            if(inicio == null)
            {
                inicio = nuevo;
            }
            else
            {
                Proceso temp = inicio;

                while (temp.Siguiente != null)
                {
                    temp = temp.Siguiente;
                }
                temp.Siguiente = nuevo;
            }
           

        }

        public void desencolar()
        {
            inicio = inicio.Siguiente;
        }

        public Proceso ver()
        {
            return inicio;
        }

    }
}
