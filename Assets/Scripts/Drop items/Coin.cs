﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] private float speed;
    [SerializeField] private float timeMove;

    private float timeCount;

    void Start()
    {
        
    }

    void Update()
    {
        timeCount += Time.deltaTime;

        if(timeCount < timeMove)
        {
            transform.Translate(Vector2.right * speed * Time.deltaTime);
        }        
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            if(collision.GetComponent<PlayerItems>().CollectCash())
            {
                collision.GetComponent<PlayerItems>().AddCash(1);
                Destroy(gameObject);
            }
        }
    }
}
