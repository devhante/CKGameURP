using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickableItem : Item
{
    public void OnClick()
    {
        IsHint = false;
        Debug.Log(gameObject.name + " Clicked");
    }
}
