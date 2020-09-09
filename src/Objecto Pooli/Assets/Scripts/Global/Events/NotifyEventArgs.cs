using System;

public class NotifyEventArgs : EventArgs
{
	public EventType Type { get; }

	public object Value { get; }

	public NotifyEventArgs(EventType type, object value) =>
		(Type, Value) = (type, value);
}
