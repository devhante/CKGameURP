using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Item : MonoBehaviour
{
    public bool Hint { get; set; }

    [SerializeField] protected ItemData itemData;
    
    private Image image;
    
    private void Awake()
    {
        Hint = false;
        image = GetComponent<Image>();
    }

    private void Update()
    {
        if (itemData != null && itemData.HintItemSprite != null)
        {
            if (Hint == false)
                image.sprite = itemData.ItemSprite;
            else
                image.sprite = itemData.HintItemSprite;
        }
    }
}