using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaEjemplo.Interface
{
    public class FlyBehaviour : IFly
    {
        public void Fly()
        {
            Console.WriteLine("Bird general fly");
        }
    }

    public class ParrotFlyBehaviour : IFly
    {
        public void Fly()
        {
            Console.WriteLine("Parrot fly");
        }
    }

    public class PenguinFlyBehaviour : IFly
    {
        public void Fly()
        {
            Console.WriteLine("Penguin fly");
        }
    }

    public class OstrichFlyBehaviour : IFly
    {
        public void Fly()
        {
            Console.WriteLine("Ostrich fly");
        }
    }

    public class NoFlyBehaviour : IFly
    {
        public void Fly()
        {
            Console.WriteLine("No fly");
        }
    }

}
