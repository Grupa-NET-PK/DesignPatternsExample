namespace Command
{
	public class RemoveVowelCommand : ICommand
	{
		public string Execute(string text)
		{
			var result = text;
			foreach (var vowel in new[] { "a", "e", "o", "u", "i", "y" })
			{
				result = result.Replace(vowel, "");
 			}
			return result;
		}
	}
}
