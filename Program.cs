using FruityStuff9000.Classes;
using FruityStuff9000.Interfaces;
using FruityStuff9000.Enums;
using FruityStuff9000.Factories;
using System;

FruitSalad salad = new FruitSalad();
salad.AddFruit(new Orange(250, Fruit.TasteModel.Sweet));
salad.AddFruit(new Apple(250, Fruit.TasteModel.Sweet));
Banana banana = new Banana(250, Fruit.TasteModel.Sweet);
salad.AddFruit(banana);

Console.WriteLine(salad.GetSaladWeightInUnit(WeightUnit.Kilogramms));

List<Fruit> ToRemove = new List<Fruit>();
foreach (Fruit fruit in salad.GetIngredients())
{
    if (fruit is IPeelable) ((IPeelable)fruit).Peel();
    if (fruit is IAnnoying) ToRemove.Add(fruit);
}
foreach (Fruit fruit in ToRemove)
{
    salad.GetIngredients().Remove(fruit);
}

Console.WriteLine(salad.GetSaladWeightInUnit(WeightUnit.Kilogramms));

var o = FruitFactory.GetOrange();

var tFruit = FruitFactory.GetFruit<Apple>(200);

Console.ReadLine();