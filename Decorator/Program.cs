using System;

namespace Decorator
{
	public class Program
	{
		static void Main(string[] args)
		{
			var notifier = new Notifier();
			bool facebookEnabled = true;
			bool slackEnabled = true;

			if (facebookEnabled)
			{
				notifier = new FacebookDecorator(notifier);
			}
			if (slackEnabled)
			{
				notifier = new SlackDecorator(notifier);
			}
			notifier.Notify("Test");
		}
	}
}
