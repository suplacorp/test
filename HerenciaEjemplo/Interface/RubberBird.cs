using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaEjemplo.Interface
{
    public class RubberBird : AbstractClassBird
    {
        //A rubberbird does nothing
        public RubberBird() : base(new NoFlyBehaviour(), new NoSpeakBehaviour(), new NoSwinBehaviour()) {

        }

        public override void Display()
        {
            Console.WriteLine("This is the RubberBird's information");
        }
    }
}
