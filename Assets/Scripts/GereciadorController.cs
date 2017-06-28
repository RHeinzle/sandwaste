using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GereciadorController : MonoBehaviour {

    public GameObject[] areasLixo;
    public GameObject[] lixos;
    public GameObject area_desova;
    private bool liberar_lixo = true;

    public float altura_lixos = 5;
    public float offsetX = -60;
    public float offsetZ = 60;
    private float offsetY = 2f;
    


    Vector3 pos1 = new Vector3(-90f, 1f, 100f);
     Vector3 pos2 = new Vector3(-11f, 1f, 130f);
     Vector3 pos3 = new Vector3(-7.5f, 1f, -125f);
     Vector3 pos4 = new Vector3(73f, 1f, -96f);
     Vector3 pos5 = new Vector3(33f, 1f, 8f);
     ArrayList vectors;
     ArrayList vectorsAux;

    private void Awake()
    {
        vectors = new ArrayList();
        vectorsAux = new ArrayList();
        adiconaLixeiras();
        desativar_areas_lixo();
        //adicionaLixos();

    }

    private void Update()
    {
        soltar_lixo();
    }

    public void setLiberarLixo(bool liberar)
    {
        this.liberar_lixo = liberar;
        
    }

    private void adiconaLixeiras()
    {
        Debug.Log("Entrou Lixeiras aleatorias");

        if (areasLixo == null)
        {
            return;
        }


        for (int i = 0; i < areasLixo.Length; i++)
        {
            
            vectors.Add(areasLixo[i].transform.position);
        }
        

     
        foreach (GameObject gameObject in areasLixo)
        {
            
            Vector3 v = (Vector3)vectors[Random.Range(0, vectors.Count)];
            gameObject.transform.position = v;
            gameObject.SetActive(true);
            vectorsAux.Add(v);
            vectors.Remove(v);
        }

    }

    private void soltar_lixo()
    {
        if (liberar_lixo)
        {
            Debug.Log("Entrou Lixos aleatorios");
            ArrayList lixos2 = new ArrayList(lixos);
            if (lixos2 == null)
            {
                return;
            }

            GameObject desova = area_desova;
            GameObject lixo = (GameObject)lixos2[Random.Range(0, lixos2.Count)];
            lixos2.Remove(lixo);
            GameObject pos_desova = desova.transform.GetChild(0).gameObject;
            Vector3 transformAux = pos_desova.transform.position;
            transformAux.y = altura_lixos;
            pos_desova.transform.position = transformAux;
            lixo.transform.position = pos_desova.transform.position;
            lixo.SetActive(true);

           
            liberar_lixo = false;

        }
    }

    public void desativar_areas_lixo()
    {
                
        for (int i = 0; i < areasLixo.Length; i++)
        {
            areasLixo[i].gameObject.SetActive(false);
        }
    }

    public void ativar_areas_lixo()
    {

        for (int i = 0; i < areasLixo.Length; i++)
        {
            areasLixo[i].gameObject.SetActive(true);
        }
    }

    /* private void adicionaLixos()
     {
         Debug.Log("Entrou Lixos aleatorios");
         ArrayList lixos2 = new ArrayList(lixos);
         if (lixos2 == null)
         {
             return;
         }

         GameObject desova = area_desovas[Random.Range(0, area_desovas.Length)];


         for(int i =0; i< qtd_lixos ; i++)
         {
             GameObject lixo = (GameObject) lixos2[Random.Range(0, lixos2.Count)];
             lixos2.Remove(lixo);

             for( int j=0; j < desova.transform.childCount ; j++)
             {
                 GameObject pos_desova =  desova.transform.GetChild(i).gameObject;
                 Vector3 transformAux = pos_desova.transform.position;
                 transformAux.y = altura_lixos;
                 pos_desova.transform.position = transformAux;
                 lixo.transform.position = pos_desova.transform.position;
                 lixo.SetActive(true);
             }


         }
     }*/


}
