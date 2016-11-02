using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaEjemplo.Interface
{
    public class Penguin : AbstractClassBird
    {
        //A penguin does not fly, does speak, does swin
        public Penguin() :base(new NoFlyBehaviour(), new PenguinSpeakBehaviour(), new PenguinSwinBehaviour()) {

        }

        public override void Display()
        {
            Console.WriteLine("This is the penguin's information");
        }
    }
}
