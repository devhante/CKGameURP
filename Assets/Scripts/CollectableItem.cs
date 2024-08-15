using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CollectableItem : MonoBehaviour
{
	[SerializeField] private ItemData itemData;
	
	public void OnClickItem()
	{
		gameObject.SetActive(false);
		FindObjectOfType<Inventory>().AddItem(itemData);
	}
}