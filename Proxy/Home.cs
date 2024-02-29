using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Proxy
{
    public class Home : IHome
    {
        private string CurrentPage { get; set; }
        public Home(string CurrentPage)
        {
            this.CurrentPage = CurrentPage;
        }
        public override void Display()
        {
            Console.WriteLine($"The Current Page Is : {CurrentPage}");
        }
    }
}
