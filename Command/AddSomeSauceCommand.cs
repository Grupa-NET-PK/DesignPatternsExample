namespace Command
{
	public class AddSomeSauceCommand : ICommand
	{
		public string Execute(string text)
		{
			return text + " sauce...";
		}
	}
}
