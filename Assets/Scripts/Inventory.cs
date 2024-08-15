using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
	[SerializeField] private Cell[] cells;

	private List<ItemData> itemDataList;
	private int startIndex;
	private bool isToggled;

	private void Start()
	{
		startIndex = 0;
		isToggled = false;
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
		}
	}

	public void AddItem(ItemData data)
	{
		itemDataList.Add(data);
	}
}
