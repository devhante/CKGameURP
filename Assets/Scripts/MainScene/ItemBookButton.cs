using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemBookButton : MonoBehaviour
{
    [SerializeField] private GameObject itemListUI;
    
    private Button button;

    private void Awake()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(OnClickButton);
    }

    private void OnClickButton()
    {
        itemListUI.SetActive(true);
    }
}
