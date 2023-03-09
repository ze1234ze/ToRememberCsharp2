using FruityStuff9000.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruityStuff9000.Classes
{
    internal class Apple : Fruit, IVitamineA, IVitamineC
    {
        public Apple(decimal weight) : base(weight)
        {
        }
        public Apple(decimal weight, TasteModel taste) : base(weight, taste)
        {
        }
    }
}
