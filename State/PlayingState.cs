using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.State
{
    public class PlayingState : IPlayerState
    {
        public override void Pause()
        {
            Console.WriteLine("Pause Music...");
        }

        public override void Play()
        {
            Console.WriteLine("Music Already Playing....");
        }

        public override void Stop()
        {
            Console.WriteLine("Stop Music ....");
        }
    }
}
