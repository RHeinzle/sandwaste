using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CuboCollision : MonoBehaviour {

    bool filho;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		

	}

    private void OnCollisionEnter(Collision collision)
    {

       bool b =  collision.gameObject.CompareTag("VERDE");

        
        if (b)
        {
            Debug.Log("teve colisão com:" + collision.gameObject.tag);

           // collision.gameObject.transform.position = transform.position;
            
        }

        
    }

    
}
