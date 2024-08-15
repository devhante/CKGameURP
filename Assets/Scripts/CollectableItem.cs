using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableItem : Item
{
	[SerializeField] private ItemData itemData;
	
	public void OnClickItem()
	{
		IsHint = false;
		gameObject.SetActive(false);
		FindObjectOfType<Inventory>().AddItem(itemData);
	}
}