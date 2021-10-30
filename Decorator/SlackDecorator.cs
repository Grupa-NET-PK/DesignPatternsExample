using System;

namespace Decorator
{
	public class SlackDecorator : BaseDecorator
	{
		public SlackDecorator(Notifier notifier) : base(notifier) { }

		public override void Notify(string message)
		{
			base.Notify(message);
			Console.WriteLine($"SlackDecorator Decorator: {message}");
		}
	}
}
