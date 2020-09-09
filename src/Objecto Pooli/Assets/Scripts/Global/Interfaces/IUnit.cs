public interface IUnit
{
	/// <summary>
	/// Deal damage to self
	/// </summary>
	/// <param name="damage">total damage</param>
	bool DealDamage(float damage);

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
