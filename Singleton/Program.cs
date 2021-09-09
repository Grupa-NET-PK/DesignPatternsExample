using System;

namespace Singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            var singleton = SingletonExample.GetInstance();
            var singleton2 = SingletonExample.GetInstance();

            singleton.Example = 20;

            Console.WriteLine($"singleton -> {singleton.Example}");
            Console.WriteLine($"singleton2 -> {singleton2.Example}");
        }
    }
}
