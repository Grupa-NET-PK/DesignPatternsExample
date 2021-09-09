namespace Builder
{
	public class Man
    {
        public string Name { get; set; }

        public double Fame { get; set; }

        public double Inteligence { get; set; }

        public double Money { get; set; }

        public double Stamina { get; set; }

        public Man AddFame(double fame)
        {
            Fame = fame;
            return this;
        }

        public Man AddInteligence(double inteligence)
        {
            Inteligence = inteligence;
            return this;
        }

        public Man AddMoney(double money)
        {
            Money = money;
            return this;
        }

        public Man AddStamina(double stamina)
        {
            Stamina = stamina;
            return this;
        }

        public Man AddName(string name)
        {
            Name = name;
            return this;
        }
    }
}
