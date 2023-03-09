using FruityStuff9000.Interfaces;
using FruityStuff9000.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FruityStuff9000.Classes
{
    internal class Banana : Fruit, IPeelable, IVitamineB
    {
        public Banana(decimal weight) : base(weight)
        {

        }

        public Banana(decimal weight, TasteModel taste) : base(weight, taste)
        {

        }

        public override decimal GetWeightInUnit(WeightUnit unit)
        {
            var weight = base.GetWeightInUnit(unit);
            decimal addWeight = 50;
            if (unit == WeightUnit.Kilogramms) addWeight = addWeight / 1000;
            if (!this.Skin) weight -= addWeight;
            return weight;
        }

        public void Peel()
        {
            this.Skin = false;
        }
    }
}
