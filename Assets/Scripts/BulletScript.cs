﻿using UnityEngine;
using System.Collections;

public class BulletScript : MonoBehaviour
{

    public float speed = 10;
    //public bool GoingRight;
    // Use this for initialization
    void Start()
    {

        rigidbody2D.velocity = new Vector3(speed, Random.Range(-0.2f, 0.2f));
    }

    // Update is called once per frame
    void Update()
    {
        if (rigidbody2D.position.y < -100)
            Destroy(gameObject);
    }


    // Gets called when the object goes out of the screen
    void OnBecameInvisible()
    {
        // Destroy the bullet 
        Destroy(gameObject);
    }
}
