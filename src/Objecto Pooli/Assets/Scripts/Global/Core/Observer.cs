using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Observer : MonoBehaviour
{
	public static event EventHandler<NotifyEventArgs> OnNotify;

	public static void Notify(object sender, EventType type, object value = null) =>
		OnNotify?.Invoke(sender, new NotifyEventArgs(type, value));
}
