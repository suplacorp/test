using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaEjemplo
{
    public class Cuadrado : FiguraBase
    {
        private double _lado;

        public Cuadrado(double lado) {
            this._lado = lado;        
        }

        public override double Area()
        {
            return Math.Pow(this._lado, 2);
        }

        /*override modifier --> re-implements the original derivated member Dibujar*/
        public override void Dibujar(){
            //base.Dibujar();
            Console.WriteLine("Dibujando cuadrado overriden");
        }
    }

    
}
