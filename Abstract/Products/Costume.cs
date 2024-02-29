﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design_Patterns.Abstract.Products
{
    public class Costume:Suit
    {
        public string Name { get; set; }

        public Costume(string Name)
        {
            this.Name = Name;
        }
    }
}
