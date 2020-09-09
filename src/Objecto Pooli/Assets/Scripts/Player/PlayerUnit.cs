using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerUnit : Unit
{
	private void Start()
	{
		Attack(this, damage);
	}

	public override void OnDeath()
	{
		Debug.Log("DEATH_EVENT");
	}

	private void OnTriggerEnter2D(Collider2D collision)
	{
		Debug.Log($"<color=orange>Trigger(2D) Enter: {collision.name}</color>");
		if (!(collision.GetComponentInParent<EnemyUnit>() is EnemyUnit unit)) return;

		if (unit.DealDamage(1))
			Observer.Notify(this, EventType.Damaged, damage);
	}
}
