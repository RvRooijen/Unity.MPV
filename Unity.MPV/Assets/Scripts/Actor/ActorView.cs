using TMPro;
using UnityEngine;

public interface IActorView
{
	void UpdateName(string name);
	void UpdateHealth(int health);
	void UpdateMana(int mana);
}

/// <summary>
/// The view is the only thing that should be attached to the game object.
/// </summary>
public class ActorView : MonoBehaviour, IActorView
{
	private IActorPresenter presenter;
	
	[SerializeField]
	private TMP_Text nameText;
	[SerializeField]
	private TMP_Text healthText;
	[SerializeField]
	private TMP_Text manaText;
	
	public void Initialize(Actor actor)
	{
		presenter = new ActorPresenter(this, actor);
	}
	
	public void UpdateName(string name)
	{
		nameText.text = $"Name: {name}";
	}
	
	public void UpdateHealth(int health)
	{
		healthText.text = $"Health: {health}";
	}
	
	public void UpdateMana(int mana)
	{
		manaText.text = $"Mana: {mana}";
	}
}
