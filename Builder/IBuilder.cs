using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public interface IBuilder
    {
        public void Reset();

        public Man GetMan();

        public void AddPartMoney();

        public void AddPartFame();

        public void AddPartInteligence();

        public void AddPartStamina();

        public void AddPartName();
    }
}
