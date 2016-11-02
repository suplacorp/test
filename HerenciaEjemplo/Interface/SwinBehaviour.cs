using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaEjemplo.Interface
{
    public class SwinBehaviour : ISwin
    {
        public void Swin()
        {
            Console.WriteLine("Bird general swin");
        }
    }

    public class ParrotSwinBehaviour : ISwin
    {
        public void Swin()
        {
            Console.WriteLine("Parrot swin");
        }
    }

    public class PenguinSwinBehaviour : ISwin
    {
        public void Swin()
        {
            Console.WriteLine("Penguin swin");
        }
    }

    public class OstrichSwinBehaviour : ISwin
    {
        public void Swin()
        {
            Console.WriteLine("Ostrich swin");
        }
    }

    public class NoSwinBehaviour : ISwin
    {
        public void Swin()
        {
            Console.WriteLine("No swin");
        }
    }


}
