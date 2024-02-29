using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Builder
{
    internal class Director
    {
        private readonly IClubBuilder _clubBuilder;
        public Director(IClubBuilder clubBuilder)
        {
            _clubBuilder = clubBuilder;
        }
        public void ConstractClub()
        {
            _clubBuilder.BuildName();
            _clubBuilder.BuildId();
            _clubBuilder.BuildTrophies();
            _clubBuilder.BuildFamous();
            _clubBuilder.BuildFoundationYear();
        }
        public Club GetClub()
        {
            return _clubBuilder.GetClub();
        }
    }
}
