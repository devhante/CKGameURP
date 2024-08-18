using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LaptopItem : Item
{
    public void OnClick()
    {
        GameManager.instance.ActiveSceneIndex = 2;
    }
}
