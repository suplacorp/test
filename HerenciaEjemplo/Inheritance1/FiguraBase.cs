using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaEjemplo
{
    /* - Cannot create objects from an abstract class 
       - Used when you want this class to be a "base class only" for other classes.
        */
    public abstract class FiguraBase
    {
        public string Nombre{ get; set; }
        
        /*protected modifier makes this member accessible from all derived classes*/
        protected string var1 = "";

        /* virtual --> allows a derived class changes its implementation through the use of the modifier "override" */
        public virtual void Dibujar() {
            Console.WriteLine("Dibujando x Figura");
        }

        /*abstract methods do not have a body or implementation */
        public abstract double Area();
    }   
}
