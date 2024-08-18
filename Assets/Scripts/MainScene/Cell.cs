using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cell : MonoBehaviour
{
    [SerializeField] private int cellIndex;
    
    private ItemData itemData;

    public ItemData ItemData
    {
        get
        {
            return itemData;
        }
        set
        {
            itemData = value;
        }
    }
    
    public bool Toggle { get; set; }

    private Inventory inventory;
    private Image image;
    private Button button;

    private void Awake()
    {
        inventory = FindObjectOfType<Inventory>();
        Toggle = false;
        image = GetComponent<Image>();
        button = GetComponent<Button>();
        button.onClick.AddListener(OnClickButton);
    }

    private void Update()
    {
        if (ItemData != null)
        {
            if (Toggle == false)
                image.sprite = ItemData.ItemSprite;
            else
                image.sprite = itemData.ToggleItemSprite;
        }
    }

    private void OnClickButton()
    {
        if (inventory.ToggleIndex == cellIndex)
            inventory.ToggleIndex = -1;
        else
            inventory.ToggleIndex = cellIndex;
    }
}
