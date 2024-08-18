using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Item : MonoBehaviour
{
    public bool Hint { get; set; }

    public ItemData itemData;
    
    private SpriteRenderer sr;
    
    private void Awake()
    {
        Hint = false;
        sr = GetComponent<SpriteRenderer>();
    }

    private void Update()
    {
        if (itemData != null && itemData.HintItemSprite != null)
        {
            if (Hint == false)
            {
                sr.sprite = itemData.ItemSprite;
            }
            else
                sr.sprite = itemData.HintItemSprite;
        }
    }
}