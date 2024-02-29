using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.State
{
    public class PausedState : IPlayerState
    {
        public override void Pause()
        {
            Console.WriteLine("Music Alraedy Paused");
        }

        public override void Play()
        {
            Console.WriteLine("Replay Music.");
        }

        public override void Stop()
        {
            Console.WriteLine("Stop Music ");
        }
    }
}
