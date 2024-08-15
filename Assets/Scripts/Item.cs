using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public bool IsHint { get; set; }

    private void Awake()
    {
        IsHint = false;
    }
}