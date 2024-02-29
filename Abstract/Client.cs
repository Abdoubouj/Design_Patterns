using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Abstract
{
    internal class Client
    {
        private readonly Suit _suit;

        public Client(ClothesFactory clothesFactory)
        {
            _suit = clothesFactory.CreateSuit();
        }
        public void Display()
        {
            Console.WriteLine(_suit.GetType().Name);
        }
    }
}
