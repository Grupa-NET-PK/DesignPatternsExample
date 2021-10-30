namespace Decorator
{
	public class BaseDecorator : Notifier
	{
		private readonly Notifier _notifier;

		public BaseDecorator(Notifier notifier)
		{
			_notifier = notifier;
		}

		public override void Notify(string message)
		{
			_notifier.Notify(message);
		}
	}
}
