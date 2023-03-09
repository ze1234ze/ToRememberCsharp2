using FruityStuff9000.Interfaces;

namespace FruityStuff9000.Classes
{
    internal class Orange : Fruit, IAnnoying, IVitamineC
    { 
        public Orange() : base (200, TasteModel.Fruity)
        {

        }

        public Orange(decimal weight, TasteModel taste) : base(weight, taste) 
        {

        }
    }
}
