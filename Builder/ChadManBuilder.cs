using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class ChadManBuilder : IBuilder
    {
        private Man man { get; set; }

        public ChadManBuilder()
        {
            man = new Man();
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
            man.Fame = 100;
        }

        public void AddPartInteligence()
        {
            man.Inteligence = 132;
        }

        public void AddPartMoney()
        {
            man.Money = 200000200.99;
        }

        public void AddPartStamina()
        {
            man.Stamina = 200;
        }

        public Man GetMan()
        {
            return man;
        }

        public void AddPartName()
        {
            man.Name = "Chad";
        }

        public void Reset()
        {
            man = new Man();
        }


    }
}
