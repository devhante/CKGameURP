using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using Random = UnityEngine.Random;

public class GameManager : MonoBehaviour
{
    [SerializeField] private Animator globalLight;
    [SerializeField] private Animator windowLight;

    private List<Item> itemList;

    private void Start()
    {
        itemList = Enumerable.ToList(FindObjectsOfType<Item>());
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.L))
        {
            Lightning();
        }
    }

    public Item GetRandomItem()
    {
        return itemList[Random.Range(0, itemList.Count)];
    }

    private void Lightning()
    {
        globalLight.SetTrigger("Lightning");
        windowLight.SetTrigger("Lightning");
    }
}
