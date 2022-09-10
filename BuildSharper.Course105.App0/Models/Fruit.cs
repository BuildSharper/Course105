namespace BuildSharper.Course105.App0.Models
{
    public class Fruit
    {
        public string Name { get; set; }
        public Color Color { get; set; }
        public int WeightGrams { get; set; }

        public void Print()
        {
            Console.WriteLine($"The {Color} {Name} weighs {WeightGrams} grams.");
        }
    }
}
