using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.State
{
    public class StoppingState : IPlayerState
    {
        public override void Pause()
        {
            Console.WriteLine("Imposible Song Is Stopped ....");
        }

        public override void Play()
        {
            Console.WriteLine("Play Music ....");
        }

        public override void Stop()
        {
            Console.WriteLine("Music Already Stopping");
        }
    }
}
