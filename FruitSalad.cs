using FruityStuff9000.Enums;

namespace FruityStuff9000.Classes
{
    internal class FruitSalad
    {
        private List<Fruit> _ingredients;

        public FruitSalad() 
        {
            _ingredients = new List<Fruit>();
        }

        public FruitSalad(List<Fruit> ingredients)
        {
            _ingredients = ingredients;
        }

        public void AddFruit(Fruit ingredient)
        {
            _ingredients!.Add(ingredient);
        }

        public decimal GetSaladWeightInUnit(WeightUnit unit)
        {
            decimal weight = 0;
            foreach (Fruit fruit in _ingredients) 
            {
                weight += fruit.GetWeightInUnit(unit);
            }
            return weight;
        }

        public List<Fruit> GetIngredients()
        {
            return _ingredients;
        }
    }
}
