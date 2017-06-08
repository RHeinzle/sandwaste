using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaptureTrash : MonoBehaviour {

    GameObject obj = null;
    public GameObject player;

    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {


    }

    private void OnCollisionEnter(Collision collision)
    {
        

    }

    private void OnTriggerEnter(Collider collision)
    {
        bool b = collision.gameObject.CompareTag("CubeTeste");
        if (b)
        {
            Debug.Log(gameObject.name+ " teve colisão com:" + collision.gameObject.tag);
            if (obj == null)
            {
                obj = collision.gameObject;
                obj.SetActive(false);
                obj = null;

                player.GetComponent<Contador>().increment();
                
            }
        }
    }

   
}
