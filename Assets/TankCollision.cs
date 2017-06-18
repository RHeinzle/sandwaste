using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TankCollision : MonoBehaviour {

    GameObject obj = null;

    Vector3 objposition;

    public void setObj(GameObject obj)
    {
        this.obj = obj;
    }

    public Vector3 getObjPosition()
    {
        return this.objposition;
    }

    
    private void OnTriggerEnter(Collider collision)
    {
        bool b = collision.gameObject.CompareTag("CubeTeste");
        
        if (collision.gameObject.tag.StartsWith("Lixo"))
        {
            Debug.Log("teve colisão com:" + collision.gameObject.tag);
            
            if (obj == null)
            {
                obj = collision.gameObject;
                this.objposition = obj.gameObject.transform.position;
                obj.transform.SetParent(transform);
                
            }
        }
    }
}
