using System;
using System.Collections.Generic;

namespace Command
{
	public class Program
	{
		static void Main(string[] args)
		{
			const string sampleText = "ala ma kota ze spiczastymi uszami";
			Console.WriteLine(new RemoveVowelCommand().Execute(sampleText));
			Console.WriteLine(new ReplaceSomeLettersToNumbersCommand().Execute(sampleText));
			Console.WriteLine(new AddSomeSauceCommand().Execute(sampleText));

			var commands = new List<ICommand>() { new ReplaceSomeLettersToNumbersCommand(), new RemoveVowelCommand() };
			var commandExecutor = new CommandExecutor(commands);
			Console.WriteLine(commandExecutor.Execute(sampleText));

			var commandsInDifferentOrder = new List<ICommand>() { new RemoveVowelCommand(), new ReplaceSomeLettersToNumbersCommand() };
			var anotherCommandExecutor = new CommandExecutor(commandsInDifferentOrder);
			Console.WriteLine(anotherCommandExecutor.Execute(sampleText));
		}
	}
}
