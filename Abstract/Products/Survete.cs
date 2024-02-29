using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Abstract.Products
{
    public class Survete:Suit
    {
        public string Name { get; set; }

        public Survete(string Name)
        {
            this.Name = Name;
        }
    }
}
