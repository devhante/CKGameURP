using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private Animator globalLight;
    [SerializeField] private Animator windowLight;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            Lightning();
        }
    }

    private void Lightning()
    {
        globalLight.SetTrigger("Lightning");
        windowLight.SetTrigger("Lightning");
    }
}
