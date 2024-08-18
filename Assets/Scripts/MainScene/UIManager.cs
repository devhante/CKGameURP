using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIManager : MonoBehaviour
{
    [SerializeField] private GameObject sideSceneUI;
    
    private void Update()
    {
        if (GameManager.instance.ActiveSceneIndex != 0)
            sideSceneUI.SetActive(true);
        else
            sideSceneUI.SetActive(false);
    }
}
