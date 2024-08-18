using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using Random = UnityEngine.Random;

public class GameManager : Singleton<GameManager>
{
    [SerializeField] private Animator globalLight;
    [SerializeField] private Animator windowLight;
    [SerializeField] private GameObject[] scenes;

    public int ActiveSceneIndex { get; set; }

    private List<Item> itemList;

    private void Start()
    {
        ActiveSceneIndex = 0;
        itemList = Enumerable.ToList(FindObjectsOfType<Item>());
    }

    private void Update()
    {
        for (int i = 0; i < scenes.Length; i++)
        {
            if (i == ActiveSceneIndex)
                scenes[i].SetActive(true);
            else
                scenes[i].SetActive(false);
        }
        
        if (Input.GetKeyDown(KeyCode.L))
        {
            Lightning();
        }
    }

    public Item GetRandomItem()
    {
        Item result;
        while (true)
        {
            result = itemList[Random.Range(0, itemList.Count)];
            if (result.itemData.HintItemSprite != null)
                break;
        }

        return result;
    }
    
    public Item GetRandomItem(Item item)
    {
        Item result;
        while (true)
        {
            result = itemList[Random.Range(0, itemList.Count)];
            if (result.itemData.HintItemSprite != null && result.itemData != item.itemData)
                break;
        }

        return result;
    }

    private void Lightning()
    {
        globalLight.SetTrigger("Lightning");
        windowLight.SetTrigger("Lightning");
    }
}
