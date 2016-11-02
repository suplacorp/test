using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaEjemplo
{
    public class Circulo : FiguraBase
    {
        private double _radio;

        public Circulo(double radio) {
            this._radio = radio;
        }

        public override double Area()
        {
            return Math.PI * Math.Pow(this._radio, 2);
        }

        public override void Dibujar()
        {
            Console.WriteLine("Dibujando círculo");
        }
    }
}
