using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GereciadorController : MonoBehaviour {

    public GameObject[] areasLixo;
    public GameObject[] lixos;

    Vector3 pos1 = new Vector3(-90f, 1f, 100f);
     Vector3 pos2 = new Vector3(-11f, 1f, 130f);
     Vector3 pos3 = new Vector3(-7.5f, 1f, -125f);
     Vector3 pos4 = new Vector3(73f, 1f, -96f);
     Vector3 pos5 = new Vector3(33f, 1f, 8f);
     ArrayList vectors = new ArrayList();

    private void Awake()
    {
        adiconaLixeiras();
        adicionaLixos();

    }

    private void adiconaLixeiras()
    {
        Debug.Log("Entrou Lixeiras aleatorias");

        vectors.Add(pos1);
        vectors.Add(pos2);
        vectors.Add(pos3);
        vectors.Add(pos4);
        vectors.Add(pos5);

        if (areasLixo == null)
        {
            return;
        }

        foreach (GameObject gameObject in areasLixo)
        {

            Vector3 v = (Vector3)vectors[Random.Range(0, vectors.Count)];
            gameObject.transform.position = v;
            gameObject.SetActive(true);
            vectors.Remove(v);
        }

    }

    private void adicionaLixos()
    {
        Debug.Log("Entrou Lixos aleatorios");

        if (lixos == null)
        {
            return;
        }

        Vector3 anterior = new Vector3(0f, 0f, 0f);

        foreach (GameObject gameObject in lixos)
        {
            Vector3 atual = new Vector3(Random.Range(-60, 60), 1f, Random.Range(-60, 60));

            foreach (Vector3 v in vectors ){
                while (atual.x == v.x ||atual.z == v.z)
                {
                    atual = new Vector3(Random.Range(-60, 60), 1f, Random.Range(-60, 60));
                }
            }


            foreach (GameObject g in lixos)
            {
                if (atual.x == g.transform.position.x || atual.z == g.transform.position.z)
                {
                    atual = new Vector3(Random.Range(-60, 60), 1f, Random.Range(-70, 70));
                }
            }

            
            anterior = atual;
            gameObject.transform.position = atual;
            gameObject.SetActive(true);

        }
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
