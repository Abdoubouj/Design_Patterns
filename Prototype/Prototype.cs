using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Prototype
{
    public class Person
    {
        public int Id { get; set; } 
        public string Name { get; set; }
        public int Age { get; set; }

        public Person(int Id , string Name , int Age) {
          
                this.Id = Id;
                this.Name = Name;
                this.Age = Age;
        }
        public void MethodA()
        {
            Console.WriteLine("Method A ");
        }

        public Person Clone()
        {
            return (Person)this.MemberwiseClone();
        }
    }
}
