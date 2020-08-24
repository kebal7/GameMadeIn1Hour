﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndGame : MonoBehaviour
{
    public GameObject gameManager;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnCollisionEnter(Collision collisionInfo)
    {
        print("collision found");

        if(collisionInfo.collider.tag == "Enemy")
        {
            gameManager.GetComponent<GameManager>().EndGame();
            print("Collision with enemy");
        }
    }
}
