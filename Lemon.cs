using FruityStuff9000.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruityStuff9000.Classes
{
    internal class Lemon : Fruit, IVitamineC
    {
        public Lemon(decimal weight) : base (weight, TasteModel.Sour)
        {

        }
        public Lemon() : base(150, TasteModel.Sour) 
        {

        }
    }
}
