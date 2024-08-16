using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CabinetItem : Item
{
    public void OnClick()
    {
        GameManager.instance.ActiveSceneIndex = 1;
    }
}
