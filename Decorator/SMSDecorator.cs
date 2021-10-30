using System;

namespace Decorator
{
	public class SMSDecorator : BaseDecorator
	{
		public SMSDecorator(Notifier notifier) : base(notifier) { }

		public override void Notify(string message)
		{
			base.Notify(message);
			Console.WriteLine($"SMS Decorator: {message}");
		}
	}
}
