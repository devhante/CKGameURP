using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemListUI : MonoBehaviour
{
    [SerializeField] private Button closeButton;

    private void Awake()
    {
        closeButton.onClick.AddListener(OnClickCloseButton);
        gameObject.SetActive(false);
    }

    private void OnClickCloseButton()
    {
        gameObject.SetActive(false);
    }
}
