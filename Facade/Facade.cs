using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade
{
    public class Facade
    {
        public SubSystem1 system1 { get; }
        public SubSystem2 system2 { get; }

        public Facade()
        {
            system1 = new SubSystem1();
            system2 = new SubSystem2();
        }

        public void DoThing()
        {
            Console.WriteLine("A teraz razem");
            system1.DoThing();
            system2.DoThing();
        }
    }
}
