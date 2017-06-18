﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaptureTrash : MonoBehaviour {

    GameObject obj = null;
    public GameObject player;
    public string cor;


    private void OnTriggerEnter(Collider collision)
    {
        string tag = collision.gameObject.tag.ToLower();
        

        if (tag.StartsWith("lixo"))
        {
            Debug.Log(gameObject.name+ " teve colisão com:" + collision.gameObject.tag);

            if (tag.EndsWith(cor))
            {
                obj = collision.gameObject;
                obj.SetActive(false);
                collision.transform.SetParent(null);
                obj = null;
                player.GetComponent<Contador>().increment();
                //player.GetComponent<TankCollision>().setObj(null);
                player.GetComponent<CuboCollision>().setObj(null);
            }
            else
            {
                collision.transform.SetParent(null);
                collision.transform.position =  player.GetComponent<CuboCollision>().getObjPosition();
                //player.GetComponent<TankCollision>().setObj(null);
                player.GetComponent<CuboCollision>().setObj(null);
            }
                        
        }
    }

   
}
