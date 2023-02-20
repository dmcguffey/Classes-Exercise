namespace Classes
{
    public class Program
    {
        static void Main(string[] args)
        {
            Car Palisade = new Car();
            Palisade.Make = "Hyundai";
            Palisade.Model = "Palisade";
            Palisade.Year = 2022;

            Console.WriteLine($"This is a {Palisade.Year} {Palisade.Make} {Palisade.Model}. What a car!");
        }
    }
}
