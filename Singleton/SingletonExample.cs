using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class SingletonExample
    {
        private static SingletonExample _instance;

        public int Example { get; set; }

        public SingletonExample(int example)
        {
            Example = example;
        }

        public static SingletonExample GetInstance()
        {
            if (_instance == null)
            {
                _instance = new SingletonExample(1);
            }
            return _instance;
        }

        public void DoThing(string tekst)
        {
            Console.WriteLine(tekst);
        }
    }
}
