using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Factory_Method
{
    internal class Restaurant
    {
        public void OrderSandwitch(String request)
        {
            SandwitchFactory factory = new SandwitchFactory();
            Sandwitch sandwitch = factory.CreateSandwitch(request);
            sandwitch.Prepare();
        }
    }
}
