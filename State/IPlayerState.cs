using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.State
{
    public abstract class IPlayerState
    {
        public abstract void Play();
        public abstract void Pause();
        public abstract void Stop();
    }
}
