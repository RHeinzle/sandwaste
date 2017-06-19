using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CaptureTrash : MonoBehaviour {

    GameObject obj = null;
    public GameObject player;
    public string cor;


    private void OnTriggerEnter(Collider collision)
    {
        obj = collision.gameObject;
        string tag = obj.tag.ToLower();
        

        if (tag.StartsWith("lixo"))
        {
            Debug.Log(gameObject.name+ " teve colisão com:" + collision.gameObject.tag);

            if (tag.EndsWith(cor))
            {
                player.GetComponent<Contador>().increment();
                obj.transform.SetParent(null);
                obj.SetActive(false);
                obj = null;
                //player.GetComponent<TankCollision>().setObj(null);
                player.GetComponent<CuboCollision>().setObj(null);

            }
            else
            {
                
                obj.transform.SetParent(null);
                obj.GetComponent<PegarLixo>().ResetLixo();
                obj = null;
                collision.transform.position =  player.GetComponent<CuboCollision>().getObjPosition();
                player.GetComponent<CuboCollision>().setObj(null);
                //obj.transform.position = player.GetComponent<TankCollision>().getObjPosition();
                //player.GetComponent<TankCollision>().setObj(null);

            }

        }
    }

   
}
