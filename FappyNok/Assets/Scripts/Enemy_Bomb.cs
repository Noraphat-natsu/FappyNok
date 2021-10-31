﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy_Bomb : MonoBehaviour
{

    void OnCollisionEnter2D(Collision2D collision)
    {


        if (collision.gameObject.tag == "Bullet")
        {
            Destroy(gameObject);
            Debug.Log("Boom");
            Time.timeScale = 0f;
            Debug.Log("GAME OVER");
        }

        if (collision.gameObject.tag == "Finish")
        {
            Destroy(gameObject);   
        }

    
    }
}
