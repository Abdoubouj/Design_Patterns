using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Factory_Method
{
    internal class SandwitchFactory
    {
        public Sandwitch CreateSandwitch(String request)
        {
            Sandwitch sandwitch = null;
            if(request == "Beef")
            {
                sandwitch = new Beef();
            }
            else if(request == "Veggie")
            {
                sandwitch = new Veggie();
            }
            return sandwitch;
            
        }
    }
}
