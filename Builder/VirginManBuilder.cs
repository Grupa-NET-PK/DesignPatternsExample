using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class VirginManBuilder : IBuilder
    {
        private Man man { get; set; }

        public VirginManBuilder()
        {
            man = new Man();
        }

        public void AddPartName()
        {
            man.Name = "Virgin";
        }

        public Man BuildMan()
        {
            AddPartFame();
            AddPartInteligence();
            AddPartMoney();
            AddPartStamina();
            AddPartName();
            return man;
        }

        public void AddPartFame()
        {
            man.Fame = 0;
        }

        public void AddPartInteligence()
        {
            man.Inteligence = 91;
        }

        public void AddPartMoney()
        {
            man.Money = 220.2;
        }

        public void AddPartStamina()
        {
            man.Stamina = 100;
        }

        public Man GetMan()
        {
            return man;
        }

        public void Reset()
        {
            man = new Man();
        }
    }
}
