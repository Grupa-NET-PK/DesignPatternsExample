using System;

namespace ChainOfResponsibility
{
    class Program
    {
        static void Main(string[] args)
        {
            var chainOne = new ComandChecker();
            var chainTwo = new DataChecker();
            var chainThree = new ComandChecker();
            var chainFour = new DataChecker();

            chainOne.SetNext(chainTwo);
            chainTwo.SetNext(chainThree);
            chainThree.SetNext(chainFour);
            chainFour.SetNext(null);

            Console.Write("Give me name and year > ");
            var userInput = Console.ReadLine();
            chainOne.Execute(userInput);

        }
    }
}
