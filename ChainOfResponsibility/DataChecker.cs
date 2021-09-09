using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    internal class DataChecker : IChain
    {
        private IChain NextChain { get; set; }

        private string[] Names = { "Piotrek", "Błażej", "Mikołaj", "Wojtuś", "Jędrzej" };

        private string[] Year = { "4th", "3th" };

        public object Execute(string test)
        {
            var perperedString = test.Split(" ");
            var outpu = Array.FindIndex(Names, q => q.Equals(perperedString[0]));
            var outpu2 = Array.FindIndex(Year, q => q.Equals(perperedString[1]));
            if((outpu == 0 || outpu == 1 || outpu == 2 || outpu == 3) &&  outpu2 == 0)
            {
                Console.WriteLine("Omg he's so OLD");
            }
            else if (outpu == 4 && outpu2 == 1)
            {
                Console.WriteLine("Whole life before you");
            }
            else
            {
                Console.WriteLine("Sombody made mistake here");
            }

            if(NextChain != null)
            {
                return NextChain.Execute(test);
            }
            else
            {
                return null;
            }
            
        }

        public void SetNext(IChain chain)
        {
            NextChain = chain;
        }
    }
}
