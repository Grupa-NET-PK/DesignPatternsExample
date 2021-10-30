using System;

namespace Decorator
{
	public class Notifier
	{
		public virtual void Notify(string message)
		{
			Console.WriteLine($"Default Notifier: {message}");
		}
	}
}
