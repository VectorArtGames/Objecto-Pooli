using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

[Serializable]
public class Unit : MonoBehaviour, IUnit
{
	public float health;

	public float damage;

	public bool isDead;

	public bool DealDamage(float points)
	{
		Debug.Log("Dealt Damage");
		if (health - points > 0)
		{
			health -= points;
			return true;
		}
		else
		{
			isDead = true;
			health = 0;
			OnDeath();
			return false;
		}
	}

	public void Attack(Unit unit, float points)
	{
		Debug.Log("Attacking ..");
		unit.DealDamage(points);
	}

	public virtual void OnDeath()
	{

	}
}
