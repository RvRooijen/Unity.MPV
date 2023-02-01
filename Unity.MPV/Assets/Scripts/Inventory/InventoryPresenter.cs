public interface IInventoryPresenter
{
	void AddItem();
	void RemoveItem();
	void UseItem();
	void EquipItem();
}

public class InventoryPresenter : IInventoryPresenter
{
	private IInventorySystem inventorySystem;
	private IInventoryView inventoryView;

	public InventoryPresenter(IInventoryView inventoryView, IInventorySystem inventorySystem)
	{
		this.inventoryView = inventoryView;
		this.inventorySystem = inventorySystem;
	}
	
	public void AddItem()
	{
		inventorySystem.AddItem();
	}
	
	public void RemoveItem()
	{
		inventorySystem.RemoveItem();
	}
	
	public void UseItem()
	{
		inventorySystem.UseItem();
	}
	
	public void EquipItem()
	{
		inventorySystem.EquipItem();
	}
}
