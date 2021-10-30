namespace Command
{
	public class ReplaceSomeLettersToNumbersCommand : ICommand
	{
		public string Execute(string text)
		{
			return text.Replace("i", "1").Replace("s", "5").Replace("a", "4").Replace("o", "0").Replace("z", "2").Replace("e", "3");
		}
	}
}
