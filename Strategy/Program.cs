using System;

namespace Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            var testObject = new TestClass()
            {
                Name = "Tomek",
                Age = 21,
                FavoriteColor = "Black",
            };

            var jsonStrategy = new MakeItJSON();
            var xmlStrategy = new MakeItXML();

            var startegyImplementation = new StrategyImplementation();

            startegyImplementation.SetStrategy(jsonStrategy);
            Console.WriteLine(startegyImplementation.Execute(testObject));

            Console.WriteLine();

            startegyImplementation.SetStrategy(xmlStrategy);
            Console.WriteLine(startegyImplementation.Execute(testObject));
        }
    }
}
