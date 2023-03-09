using FruityStuff9000.Enums;

namespace FruityStuff9000.Classes
{
    internal class Fruit : ICloneable
    {
        public TasteModel Taste { get; }
        private decimal Weight;
        public bool Skin { get; protected set; }

        public Fruit(decimal weight) {
            Skin= true;
            Weight = weight;
            Taste = TasteModel.Fruity;
        }

        public Fruit(decimal weight,TasteModel taste)
        {
            Skin = true;
            Weight = weight;
            Taste = taste;
        }

        public virtual decimal GetWeightInUnit(WeightUnit unit)
        {
            if (unit == WeightUnit.Kilogramms) return Weight / 1000;
            return Weight;
        }

        public object Clone()
        {
            return new Fruit(Weight, Taste)
            {
                Skin = Skin,
            };
        }

        public enum TasteModel
        {
            Fruity,
            Sweet,
            Sour,
            Plain
        }
    }
}
