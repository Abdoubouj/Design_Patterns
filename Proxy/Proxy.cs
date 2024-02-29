using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Proxy
{
    public class Proxy:IHome
    {
        private Home home;
        private string _CurrentPage;
        private string _Password;
        public Proxy(string CurrentPage , string Password)
        {
            _CurrentPage = CurrentPage;
            _Password = Password;
        }

        public override void Display()
        {
            if(_Password == "abderrahim")
            {
                if(home == null)
                {
                    home = new Home(_CurrentPage);
                }
                home.Display();
            }
            else
            {
                Console.WriteLine("Something wrong");
            }
        }

    }
}
