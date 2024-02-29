using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Builder
{
    internal interface IClubBuilder
    {
        void BuildId();
        void BuildName();
        void BuildFoundationYear();
        void BuildTrophies();
        void BuildFamous();
        Club GetClub();
    }
}
