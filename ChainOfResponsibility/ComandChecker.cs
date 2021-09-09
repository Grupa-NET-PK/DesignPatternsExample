using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    internal class ComandChecker : IChain
    {
        private IChain NextChain { get; set; }

        private string[] Names = { "Piotrek", "Błażej", "Mikołaj", "Wojtuś", "Jędrzej" };

        public object Execute(string test)
        {
            var perperedString = test.Split(" ");
            var outpu = Array.FindIndex(Names, q => q.Equals(perperedString[0]));
            if(outpu != -1)
            {
                string textToWrite = "Nice";
                
                switch (outpu)
                {
                    case 0:
                        textToWrite = "Handsome";
                        break;
                    case 1:
                        textToWrite = "Cute";
                        break;
                    case 2:
                        textToWrite = "Good-looking";
                        break;
                    case 3:
                        textToWrite = "Me";
                        break;
                    case 4:
                        textToWrite = "Fine-looking";
                        break;
                }
                Console.WriteLine($"Ohh i know {perperedString[0]} he is really {textToWrite}");
                return NextChain.Execute(test);
            }
            else
            {
                Console.WriteLine("Sorry i dono who is that");
                return null;
            }
        }

        public void SetNext(IChain chain)
        {
            NextChain = chain;
        }
    }
}
