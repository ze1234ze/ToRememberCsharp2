using FruityStuff9000.Classes;

namespace FruityStuff9000.Factories
{
    internal static class FruitFactory
    {
        public static Orange GetOrange()
        {
            Fruit.TasteModel taste = Fruit.TasteModel.Fruity;
            decimal weight = 0;
            switch (Weather.Instance.CurrentWeather)
            {
                case Weather.CurrentWeatherModel.Sunny:
                    taste = Fruit.TasteModel.Sweet;
                    weight = 250;
                    break;
                case Weather.CurrentWeatherModel.Cloudy:
                    taste = Fruit.TasteModel.Plain;
                    weight = 150;
                    break;
                case Weather.CurrentWeatherModel.Rainy:
                    taste = Fruit.TasteModel.Sour;
                    weight = 200;
                    break;
                default:
                    break;
            }

            return new Orange(weight, taste);
        }

        public static T GetFruit<T>(decimal weight) where T : Fruit
        {
            if (typeof(T).IsEquivalentTo(typeof(Orange))) return (T) Convert.ChangeType(new Orange(weight, Fruit.TasteModel.Sour), typeof(T));
            if (typeof(T).IsEquivalentTo(typeof(Apple))) return (T)Convert.ChangeType(new Apple(weight), typeof(T));
            if (typeof(T).IsEquivalentTo(typeof(Banana))) return (T)Convert.ChangeType(new Banana(weight), typeof(T));
            if (typeof(T).IsEquivalentTo(typeof(Fruit))) return (T)Convert.ChangeType(new Fruit(weight), typeof(T));

            throw new NotImplementedException();
        }
    }
}
