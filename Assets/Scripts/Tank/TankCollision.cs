using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TankCollision : MonoBehaviour {

    GameObject obj = null;

    Vector3 objposition;
    public GameObject gerenciador;
    
    public void setObj(GameObject obj)
    {
        this.obj = obj;
    }

    public Vector3 getObjPosition()
    {
        return this.objposition;
    }

    
    /*private void OnTriggerEnter(Collider collision)
    {
        // bool b = collision.gameObject.CompareTag("CubeTeste");

        if (collision.gameObject.tag.StartsWith("Lixo"))
        {
            Debug.Log(gameObject.name + " teve colisão com:" + collision.gameObject.tag);

            if (obj == null)
            {
                if (podePegar)
                {
                    obj = collision.gameObject;
                    this.objposition = obj.gameObject.transform.position;
                    obj.transform.SetParent(transform);
                }

            }
        }
    }*/



    private void OnTriggerStay(Collider collision)
    {
        if (collision.gameObject.tag.StartsWith("Lixo"))
        {
            Debug.Log(gameObject.name + " teve colisão com:" + collision.gameObject.tag);

            gerenciador.GetComponent<Temporizador>().setColisao(true);
            int damage = gerenciador.GetComponent<Temporizador>().getTimer();
            collision.gameObject.GetComponent<PegarLixo>().TakeDamage(damage);

            if (collision.gameObject.GetComponent<PegarLixo>().PodePegar())
            {
                Debug.Log("agora pode pegar");
                if (obj == null)
                {
                
                    obj = collision.gameObject;
                    this.objposition = obj.gameObject.transform.position;
                    Debug.Log("Pegou posição inicial: " + objposition.x +" "+objposition.y+" "+objposition.z);
                    obj.transform.SetParent(transform);
                    
                }

            }
        }
    }

    private void OnTriggerExit(Collider collision)
    {
        if (collision.gameObject.tag.StartsWith("Lixo"))
        {
            Debug.Log(gameObject.name + " desfez colisão com:" + collision.gameObject.tag);

            gerenciador.GetComponent<Temporizador>().setColisao(false);
            gerenciador.GetComponent<Temporizador>().resetTempo();
            collision.gameObject.GetComponent<PegarLixo>().ResetLixo();
            setObj(null);

        }
    }

}
