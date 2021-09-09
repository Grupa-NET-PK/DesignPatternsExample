using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    public class MakeItJSON : IStrategy
    {
        public string DoThing(TestClass test)
        {
            return JsonConvert.SerializeObject(test);
        }
    }
}
