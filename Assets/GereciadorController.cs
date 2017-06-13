using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GereciadorController : MonoBehaviour {

    public GameObject[] areasLixo;
     Vector3 pos1 = new Vector3(-90f, 1f, 100f);
     Vector3 pos2 = new Vector3(-11f, 1f, 130f);
     Vector3 pos3 = new Vector3(-7.5f, 1f, -125f);
     Vector3 pos4 = new Vector3(73f, 1f, -96f);
     Vector3 pos5 = new Vector3(33f, 1f, 8f);

    private void Awake()
    {
        print("Entrou aqui");

        ArrayList vectors = new ArrayList();
        vectors.Add(pos1);
        vectors.Add(pos2);
        vectors.Add(pos3);
        vectors.Add(pos4);
        vectors.Add(pos5);

        if (areasLixo == null)
        {
            return;
        }

                 
        foreach ( GameObject gameObject in areasLixo){
            
            Vector3 v = (Vector3) vectors[Random.Range(0, vectors.Count)];
            gameObject.transform.position = v;
            vectors.Remove(v);
        }

    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
