using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColasFIFO
{
    class Proceso
    {
        public int _ciclo;
        Random rnd = new Random();
        private Proceso _siguiente;

        public Proceso()
        {
            _ciclo = rnd.Next(4, 15);
        }

        public override string ToString()
        {
            return "Proceso: " + _ciclo;
        }

        public Proceso Siguiente
        {
            get { return _siguiente; }
            set { _siguiente = value; }
        }
    }
}
