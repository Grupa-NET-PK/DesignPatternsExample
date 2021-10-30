using System;

namespace Decorator
{
	public class FacebookDecorator : BaseDecorator
	{
		public FacebookDecorator(Notifier notifier) : base(notifier) { }

		public override void Notify(string message)
		{
			base.Notify(message);
			Console.WriteLine($"FacebookDecorator Decorator: {message}");
		}
	}
}
