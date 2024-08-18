using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SideSceneUI : MonoBehaviour
{
    [SerializeField] private Button backButton;
    private void Awake()
    {
        backButton.onClick.AddListener(OnClickBackButton);
    }

    private void OnClickBackButton()
    {
        GameManager.instance.ActiveSceneIndex = 0;
    }
}
