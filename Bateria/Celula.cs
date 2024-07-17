using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bateria
{
    internal class Celula
    {
        public int carga { get; private set; }
        private static int cargaBateria;
        public Celula()
        {
            carga = 25;
            cargaBateria += 25;
        }

        public int getCargaBateira()
        {
            return cargaBateria;
        }

        public void setCargabateria(int cargabateria)
        {
            cargaBateria = cargabateria;
        }

        public void consumir()
        {
            if (cargaBateria > 0 && this.carga > 0) { this.carga -= 5; }
        }


        public void carregar()
        {
            if (cargaBateria < 100 && this.carga < 100)
                this.carga += 5;
        }

    }
}
