using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CuboCollision : MonoBehaviour {

    GameObject obj = null;
    public int heightY;
  

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
        
        
    }


    // Fazer Y fixo ( não funciona ainda )
    private void LateUpdate()
    {
        /*
       Vector3 novaPosicao = new Vector3(
            gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z);
                 novaPosicao.y = heightY;
        
           gameObject.transform.position = novaPosicao;

        */

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
