using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CuboCollision : MonoBehaviour {

    GameObject obj = null;
    public int heightY = 10; 

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		

	}


    // Fazer Y fixo ( não funciona ainda )
    private void LateUpdate()
    {

        gameObject.transform.position.Set(
            gameObject.transform.position.x, heightY, gameObject.transform.position.z);
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
