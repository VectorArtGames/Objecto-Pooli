using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyUnit : Unit
{
	public void Start()
	{
		
	}

	private void OnTriggerEnter(Collider other)
	{
		if (!(other.GetComponent<PlayerUnit>() is PlayerUnit unit)) return;

		unit.DealDamage(1);
	}
}
