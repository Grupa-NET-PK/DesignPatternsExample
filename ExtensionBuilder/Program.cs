using System;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            var chad = new Man()
                .AddName("Chad")
                .AddFame(100)
                .AddMoney(100);
            var virgin = new Man()
                .AddName("Virgin")
                .AddFame(0)
                .AddMoney(0);

            Man[] manList = { chad, virgin };

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
