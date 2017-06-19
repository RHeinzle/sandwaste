using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Temporizador : MonoBehaviour {

    private int oldTimer;

    public float timer = 0;
    private bool colisao;


    // Use this for initialization
    void Start () {

        
        timer += Time.deltaTime;
        Debug.Log("Tempo inicial: = " + Mathf.RoundToInt(timer));
    }
	
	// Update is called once per frame
	void Update () {



    }

    private void LateUpdate()
    {
        if (colisao)
        {
            timer += Time.deltaTime;
            int tempo = Mathf.RoundToInt(timer);
            Debug.Log(gameObject.name + " Tempo=" + tempo);
        }
        else
        {

            resetTempo();
        }
       
        /*int novo = Mathf.RoundToInt(timer);
        print("novo time =" + novo);*/
    }

    public void resetTempo()
    {
        timer = 0;
 
    }

    public int getTimer()
    {
        return Mathf.RoundToInt(timer);

    }
    public void setColisao(bool c)
    {
        colisao = c;
    }

   
}
    

