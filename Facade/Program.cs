using System;

namespace Facade
{
    class Program
    {
        static void Main(string[] args)
        {
            var facade = new Facade();

            facade.system1.DoThing();
            facade.system2.DoThing();

            facade.DoThing();
        }
    }
}
