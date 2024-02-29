using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Builder
{
    internal class Club
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int FoundationYear { get; set; }
        public int Trophies {  get; set; }
        public bool IsFamous { get; set; }

        //public Club(int Id , string Name , int FoundationYear , int Trophies , bool isFamous)
        //{
        //    this.Id = Id;
        //    this.Name = Name;
        //    this.FoundationYear = FoundationYear;
        //    this.Trophies = Trophies;
        //    this.IsFamous = isFamous;
        //}
        public void Print() {
            Console.WriteLine($"id:{Id} - Name:{Name} - Year:{FoundationYear} - TrophiesCount:{Trophies}  -  IsFamous:{IsFamous}");
        }
    }
}
