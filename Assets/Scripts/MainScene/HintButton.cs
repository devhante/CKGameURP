using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HintButton : MonoBehaviour
{
    private Button button;
    private Item hintItem;

    private void Awake()
    {
        button = GetComponent<Button>();
        button.onClick.AddListener(OnClickButton);
        hintItem = null;
    }

    private void OnClickButton()
    {
        if (hintItem)
        {
            hintItem.Hint = false;
            hintItem = GameManager.instance.GetRandomItem(hintItem);
            StopAllCoroutines();
            StartCoroutine(HintRoutine());
        }
        else
        {
            hintItem = GameManager.instance.GetRandomItem();
            StartCoroutine(HintRoutine());
        }
    }

    private IEnumerator HintRoutine()
    {
        float countdown = 3.0f;
        hintItem.Hint = true;
        
        while (countdown > 0f)
        {
            countdown -= Time.deltaTime;
            yield return null;
        }

        hintItem.Hint = false;
        hintItem = null;
    }
}
