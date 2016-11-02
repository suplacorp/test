using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaEjemplo.Interface
{
    public class SpeakBehaviours : ISpeak
    {
        public void Speak()
        {
            Console.WriteLine("Bird general noise");
        }
    } 

    public class ParrotSpeakBehaviour : ISpeak
    {
        public void Speak()
        {
            Console.WriteLine("Parrot noise");
        }
    }

    public class PenguinSpeakBehaviour : ISpeak
    {
        public void Speak()
        {
            Console.WriteLine("Penguin noise");
        }
    }

    public class OstrichSpeakBehaviour : ISpeak
    {
        public void Speak()
        {
            Console.WriteLine("Ostrich noise");
        }
    }

    public class NoSpeakBehaviour : ISpeak
    {
        public void Speak()
        {
            Console.WriteLine("Silence");
        }
    }
}
