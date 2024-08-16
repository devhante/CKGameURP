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
        return itemList[Random.Range(0, itemList.Count)];
    }

    private void Lightning()
    {
        globalLight.SetTrigger("Lightning");
        windowLight.SetTrigger("Lightning");
    }
}
