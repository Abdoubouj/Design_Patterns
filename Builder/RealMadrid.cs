using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Builder
{
    internal class RealMadrid : IClubBuilder
    {
        private readonly Club _club = new Club();
        public void BuildFamous()
        {
            _club.IsFamous = true;
        }

        public void BuildFoundationYear()
        {
            _club.FoundationYear = 1900;
        }

        public void BuildId()
        {
            _club.Id = 1;
        }

        public void BuildName()
        {
            _club.Name = "real madrid";
        }

        public void BuildTrophies()
        {
            _club.Trophies = 33; 
        }

        public Club GetClub()
        {
            return _club;
        }
    }
}
