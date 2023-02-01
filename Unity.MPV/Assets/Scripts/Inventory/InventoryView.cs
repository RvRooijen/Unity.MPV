using TMPro;
using UnityEngine;
using UnityEngine.UI;

public interface IInventoryView
{
	
}

public class InventoryView : MonoBehaviour, IActorView, IInventoryView
{
	[SerializeField]
	private TMP_Text nameText;
	[SerializeField]
	private TMP_Text healthText;
	[SerializeField]
	private TMP_Text manaText;

	private IInventoryPresenter inventoryPresenter;
	private IActorPresenter actorPresenter;

	public Button AddItemButton;
	public Button RemoveItemButton;
	
	public void Initialize(Actor actor, IInventorySystem inventorySystem)
	{
		actorPresenter = new ActorPresenter(this, actor);
		inventoryPresenter = new InventoryPresenter(this, inventorySystem);
		
		AddItemButton.onClick.AddListener(inventoryPresenter.AddItem);
		RemoveItemButton.onClick.AddListener(inventoryPresenter.RemoveItem);
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
