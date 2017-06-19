using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Contador : MonoBehaviour {

    private int cont = 0;
    public Text texto;
  
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    public void increment()
    {
        this.cont++;
        print(cont);

        texto.text = "Pontos " + cont;
    }

 

}
