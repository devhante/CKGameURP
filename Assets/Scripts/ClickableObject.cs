using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ClickableObject : MonoBehaviour
{
    public void OnClick()
    {
        Debug.Log(gameObject.name + " Clicked");
    }
}
