using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bateria
{
    internal class Celula
    {
        private int carga { get;  set; }
        private static int cargaBateria {get; set;}

        public Celula()
        {
            this.carga = 25;
            cargaBateria += 25;
        }



        public void setCargabateria(int cargabateria)
        {
           cargaBateria = cargabateria;
        }

        public void consumir()
        {
            if(cargaBateria > 0 && this.carga > 0) { this.carga -= 5; }
        }


        public void carregar()
        {
            if(cargaBateria < 100 && this.carga < 100)
            this.carga += 5;
        }

    }
}
