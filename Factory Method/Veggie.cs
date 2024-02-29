using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Factory_Method
{
    internal class Veggie : Sandwitch
    {
        public void Prepare()
        {
            Console.WriteLine("prepare beef sandwitch...");
        }
    }
}
