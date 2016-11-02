using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaEjemplo.Interface
{
    public class Ostrich : AbstractClassBird
    {
        //An ostrich does not fly, does speak, does not swin
        public Ostrich() : base(new NoFlyBehaviour(), new OstrichSpeakBehaviour(), new NoSwinBehaviour()) {

        }

        public override void Display()
        {
            Console.WriteLine("This is the Ostrich's information");
        }
    }
}
