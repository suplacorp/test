using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaEjemplo.Interface
{
    public class Parrot : AbstractClassBird
    {
        //A parrot Flies, Speaks, but DOES NOT SWIN
        public Parrot() : base(new ParrotFlyBehaviour(), new ParrotSpeakBehaviour(), new NoSwinBehaviour())
        {

        }

        public override void Display()
        {
            Console.WriteLine("This is the parrot's information");
        }
    }
}
