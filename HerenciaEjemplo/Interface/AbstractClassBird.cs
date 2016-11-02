using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerenciaEjemplo.Interface
{
    public abstract class AbstractClassBird : IFly, ISpeak, ISwin
    {
        public AbstractClassBird(IFly flyBehaviour, ISpeak speakBehaviour, ISwin swinBehaviour) {
            FlyBehaviour = flyBehaviour;
            SpeakBehaviour = speakBehaviour;
            SwinBehaviour = swinBehaviour;
        }

        public IFly FlyBehaviour { get; set; }
        public ISwin SwinBehaviour { get; set; }
        public ISpeak SpeakBehaviour { get; set; }

        #region properties
        public void Fly()
        {
            try
            {
                FlyBehaviour.Fly();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
        }

        public void Speak()
        {
            try
            {
                SpeakBehaviour.Speak();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
        }

        public void Swin()
        {
            try
            {
                SwinBehaviour.Swin();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message.ToString());
            }
        }
        #endregion

        public abstract void Display();

    }
}
