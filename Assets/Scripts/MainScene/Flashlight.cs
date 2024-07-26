using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Random = UnityEngine.Random;

public class Flashlight : MonoBehaviour
{
    private Animator _animator;

    private void Start()
    {
        _animator = GetComponent<Animator>();
        StartCoroutine(BlinkRoutine());
    }

    private void Update()
    {
        Vector3 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        transform.position = new Vector3(pos.x, pos.y, transform.position.z);
    }

    private IEnumerator BlinkRoutine()
    {
        float blinkValue = 0.1f;
        
        while (true)
        {
            float randomValue = Random.Range(0.0f, 1.0f);
            if (randomValue < blinkValue)
            {
                Blink();
                yield return new WaitForSeconds(5f);
            }
            yield return new WaitForSeconds(1f);
        }
    }

    private void Blink()
    {
        _animator.SetTrigger("Blink");
    }
}
