﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankCollision : MonoBehaviour {

    GameObject obj = null;

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter(Collision collision)
    {

       


    }

    private void OnTriggerEnter(Collider collision)
    {
        bool b = collision.gameObject.CompareTag("CubeTeste");


        if (b)
        {
            Debug.Log("teve colisão com:" + collision.gameObject.tag);
            collision.gameObject.transform.SetParent(transform);
            if (obj == null)
            {
                obj = collision.gameObject;
                obj.transform.SetParent(transform);
            }
        }
    }
}
