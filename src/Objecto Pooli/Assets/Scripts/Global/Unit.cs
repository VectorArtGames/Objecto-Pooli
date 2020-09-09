using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Serialization;

public interface IUnit
{
	/// <summary>
	/// Deal damage to self
	/// </summary>
	/// <param name="damage">total damage</param>
	void DealDamage(float damage);

	/// <summary>
	/// Deal damage to Unit
	/// </summary>
	/// <param name="unit">Deal damage to unit</param>
	/// <param name="damage">total damage</param>
	void Attack(Unit unit, float damage);

	/// <summary>
	/// On Death Event
	/// </summary>
	void OnDeath();
}

[Serializable]
public class Unit : MonoBehaviour, IUnit
{
	public float health;

	public float damage;

	public bool isDead;

	public void DealDamage(float points)
	{
		Debug.Log("Dealt Damage");
		if (health - points > 0)
			health -= points;
		else
			OnDeath();
	}

	public void Attack(Unit unit, float points)
	{
		Debug.Log("Attacking ..");
		unit.DealDamage(points);
	}

	public void OnDeath()
	{
		isDead = true;
		health = 0;
		Debug.Log("Whoopsie .. You died");
	}
}