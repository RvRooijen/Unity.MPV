using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IInventorySystem
{
	void AddItem();
	void RemoveItem();
	void UseItem();
	void EquipItem();
}

public class InventorySystem : IInventorySystem
{
	public InventorySystem()
	{
		
	}
	
	public void AddItem()
	{
		Debug.Log("Item added");
	}
	
	public void RemoveItem()
	{
		Debug.Log("Item removed");
	}
	
	public void UseItem()
	{
		Debug.Log("Item used");
	}
	
	public void EquipItem()
	{
		Debug.Log("Item equipped");
	}
}
