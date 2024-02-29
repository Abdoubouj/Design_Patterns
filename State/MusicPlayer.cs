using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.State
{
    public class MusicPlayer
    {
        IPlayerState playerState;
        public MusicPlayer()
        {
            playerState = new PlayingState();
        }
        public void Play()
        {
            playerState.Play();
            playerState = new PlayingState();
        }
        public void Stop()
        {
            playerState.Stop();
            playerState = new StoppingState();
        }
        public void Pause()
        {
            playerState.Pause();
            playerState = new PausedState();
        }
    }
}
