using System;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            var chadBuilder = new ChadManBuilder();
            var virginBuilder = new VirginManBuilder();

            Man[] manList = { chadBuilder.BuildMan(), virginBuilder.BuildMan() };

            foreach (var man in manList)
            {
                Console.WriteLine($"Man name: {man.Name}");
                Console.WriteLine($"Man fame: {man.Fame}");
                Console.WriteLine($"Man inteligence: {man.Inteligence}");
                Console.WriteLine($"Man stamina: {man.Stamina}");
                Console.WriteLine($"Man money: {man.Money}");
                Console.WriteLine(new string('-', 10));
            }


        }
    }
}
