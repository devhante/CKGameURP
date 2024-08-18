using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
	[SerializeField] private Cell[] cells;

	public int ToggleIndex { get; set; }
	
	private List<ItemData> itemDataList;
	private int startIndex;

	private void Start()
	{
		startIndex = 0;
		ToggleIndex = -1;
		itemDataList = new List<ItemData>();
	}

	private void Update()
	{
		for (int i = 0; i < cells.Length; i++)
		{
			if (startIndex + i < itemDataList.Count)
			{
				cells[i].gameObject.SetActive(true);
				cells[i].ItemData = itemDataList[startIndex + i];
			}
			else
			{
				cells[i].gameObject.SetActive(false);
			}

			if (i == ToggleIndex)
				cells[i].Toggle = true;
			else
				cells[i].Toggle = false;
		}
	}

	public void AddItem(ItemData data)
	{
		itemDataList.Add(data);
	}

	public ItemData GetItemDataByIndex(int index)
	{
		return cells[index].ItemData;
	}
}
