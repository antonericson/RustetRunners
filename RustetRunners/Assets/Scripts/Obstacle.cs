﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Obstacle : MonoBehaviour
{
    public int damage;
    public int speed;

    // Update is called once per frame
    void Update()
    {
        transform.Translate(Vector2.left * speed * Time.deltaTime);
    }

    void OnTriggerEnter2D(Collider2D collider){
        if(collider.CompareTag("Player")){
            collider.GetComponent<PlayerStats>().health -= this.damage;
            Debug.Log(collider.GetComponent<PlayerStats>().health);
            Destroy(gameObject);
        }
    }
}
