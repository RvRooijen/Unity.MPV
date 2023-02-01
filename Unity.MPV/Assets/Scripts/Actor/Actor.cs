using UnityEngine;

/// <summary>
/// Model is loaded from a remote or local source. In this case it is a scriptable object 
/// </summary>
[CreateAssetMenu(fileName = "Actor", menuName = "Model/Actor", order = 0)]
public class Actor : ScriptableObject
{
	public int ID;
	public string Name;
	public int MaxHealth;
	public int Mana;

	public Actor(int id, string name, int maxHealth, int mana)
	{
		ID = id;
		Name = name;
		MaxHealth = maxHealth;
		Mana = mana;
	}
}
