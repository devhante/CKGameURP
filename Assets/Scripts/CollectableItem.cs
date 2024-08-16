using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableItem : Item
{
	public void OnClickItem()
	{
		Hint = false;
		gameObject.SetActive(false);
		FindObjectOfType<Inventory>().AddItem(itemData);
	}
}