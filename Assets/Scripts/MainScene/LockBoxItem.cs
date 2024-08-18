using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LockBoxItem : Item
{
    public void OnClick()
    {
        GameManager.instance.ActiveSceneIndex = 3;
    }
}
