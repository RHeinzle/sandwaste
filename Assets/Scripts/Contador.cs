using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Contador : MonoBehaviour {

    private int cont = 0;
    public int limite_lixos_fim = 5;
    public Text texto;
    public Text texto_fim;
    public GameObject fundo_fim;
    public GameObject gerenciador;
    public GameObject obj_inicio;
    private bool inicio;



    // Use this for initialization
    void Start () {

        
    }

    private void Awake()
    {

    }

    public void setInicio(bool iniciar)
    {
        inicio = iniciar;
        Destroy(obj_inicio);
        this.gerenciador.GetComponent<GereciadorController>().ativar_areas_lixo();
        fundo_fim.SetActive(false);
    }

	// Update is called once per frame
	void Update () {

        if (inicio)
        {
            
            testa_fim();
        }
       

    }

    public void increment()
    {
        this.cont++;
        print(cont);

        texto.text = "Pontos " + cont;

        this.gerenciador.GetComponent<GereciadorController>().setLiberarLixo(true);
    }

    public void testa_fim()
    {
        if(cont == limite_lixos_fim)
        {

            GameObject pai = texto_fim.transform.parent.gameObject;

            texto_fim.text = "Continue praticando a coleta seletiva!!!";
            texto_fim.fontSize = 25;
            texto_fim.gameObject.SetActive(true);
            texto.gameObject.SetActive(false);
            fundo_fim.SetActive(true);
            this.gerenciador.GetComponent<GereciadorController>().desativar_areas_lixo();
            gameObject.SetActive(false);
        }
    }

}
