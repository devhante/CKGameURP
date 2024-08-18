using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CabinetItem : Item
{
    [SerializeField] private ItemData crowbarItemData;
    
    public void OnClick()
    {
        var inventory = FindObjectOfType<Inventory>();
        if (inventory.ToggleIndex != -1)
            if (inventory.GetItemDataByIndex(inventory.ToggleIndex) == crowbarItemData )
                GameManager.instance.ActiveSceneIndex = 1;
    }
}
