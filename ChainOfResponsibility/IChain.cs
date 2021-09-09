using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChainOfResponsibility
{
    internal interface IChain
    {
        public void SetNext(IChain chain);

        public object Execute(string test);
    }
}
