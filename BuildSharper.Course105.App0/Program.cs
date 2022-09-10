using BuildSharper.Course105.App0;
using BuildSharper.Course105.App0.Models;

Console.WriteLine("****************************");
Console.WriteLine("All about fruit!");
Console.WriteLine("****************************");
Console.WriteLine();

//let's create a collection of Fruits, so we can easily add more and traverse them
var fruits = new List<Fruit>();

fruits.Add(new Fruit()
{
    Name = "Banana",
    Color = Color.Yellow,
    WeightGrams = 118
});

fruits.Add(new Fruit()
{
    Name = "Blueberry",
    Color = Color.Blue,
    WeightGrams = 2
});

fruits.Add(new Fruit()
{
    Name = "Kiwi",
    Color = Color.Green,
    WeightGrams = 69
});

fruits.Add(new Fruit()
{
    Name = "Orange",
    Color = Color.Orange,
    WeightGrams = 154
});

fruits.Add(new Fruit()
{
    Name = "Strawberry",
    Color = Color.Red,
    WeightGrams = 12
});

//iterated through the Fruit objects
foreach (var fruit in fruits)
{
    //foreach fruit in the collection, execute the Print() method
    fruit.Print();
}

Console.WriteLine();
Console.WriteLine("Press any key to continue.");
Console.ReadKey();