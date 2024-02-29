using Design_Patterns.Abstract.Products;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Abstract
{
    public class ElegantClothesFactory : ClothesFactory
    {
        public override Suit CreateSuit()
        {
            return new Costume("Costume Clothe");
        }
    }
}
