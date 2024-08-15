using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Cell : MonoBehaviour
{
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

    private bool toggle;
    private Image image;
    private Button button;

    private void Awake()
    {
        toggle = false;
        image = GetComponent<Image>();
        button = GetComponent<Button>();
        button.onClick.AddListener(OnClickButton);
    }

    private void Update()
    {
        if (ItemData != null)
        {
            if (toggle == false)
                image.sprite = ItemData.ItemSprite;
            else
                image.sprite = itemData.ToggleItemSprite;
        }
    }

    private void OnClickButton()
    {
        toggle = !toggle;
    }
}
