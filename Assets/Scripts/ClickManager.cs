using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class ClickManager : MonoBehaviour
{
    [HideInInspector] public List<UnityEvent> eventList;
    [HideInInspector] public List<int> orderList;
    
    private void Update()
    {
        if (eventList.Count > 0)
        {
            int maxOrderIndex = 0;
            for (int i = 0; i < eventList.Count; i++)
            {
                if (orderList[maxOrderIndex] < orderList[i])
                    maxOrderIndex = i;
            }
            eventList[maxOrderIndex].Invoke();
            eventList.Clear();
            orderList.Clear();
        }
    }
}
