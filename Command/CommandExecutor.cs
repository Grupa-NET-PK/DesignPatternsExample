using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Command
{
	public class CommandExecutor : ICommand
	{
		private List<ICommand> commandsToExcecute;

		public CommandExecutor(List<ICommand> commands)
		{
			commandsToExcecute = commands;
		}

		public string Execute(string text)
		{
			var result = text;
			commandsToExcecute.ForEach(c =>
			{
				result = c.Execute(result);
			});
			return result;
		}
	}
}
