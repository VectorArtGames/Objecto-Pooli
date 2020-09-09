using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IObserver
{
	void OnNotify(Unit entity, EventType type);
}

public class Observer : MonoBehaviour, IObserver
{
	public virtual void OnNotify(Unit entity, EventType type)
	{

	}
}


public enum EventType
{
	Achievement
}