using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy
{
    internal class StrategyImplementation
    {
        private IStrategy strategy { get; set; }

        public void SetStrategy(IStrategy _strategy)
        {
            strategy = _strategy;
        }

        public string Execute(TestClass testClass)
        {
            return strategy.DoThing(testClass);
        }
    }
}
