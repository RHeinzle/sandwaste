using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BloqueiaY : MonoBehaviour {

	public float y;
    public Vector3 rotationUAx;
    public float m_Speed = 12f;
    public float m_TurnSpeed = 180f;


    private string m_MovementAxisName;
    private string m_TurnAxisName;
    private Rigidbody m_Rigidbody;
    private float m_MovementInputValue;
    private float m_TurnInputValue;

    private Vector3 posicao_anterior;

    void Start()
    {
        posicao_anterior = this.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        Vector3 transformAux = this.transform.position;
        transformAux.y = y;
        transform.position = transformAux;



        Quaternion transformAux2 = this.transform.rotation;
        transformAux2.x = rotationUAx.x;
        // O Y deixa livre para rotacionar
        //transformAux2.y = rotationUAx.y;
        transformAux2.z = rotationUAx.z;
        transform.rotation = transformAux2;
    }

    private void FixedUpdate()
    {
        // Move and turn the tank.

        //Move();
        // Turn();

       // transform.Translate(Vector3.forward * 1, Space.World);
    }


    private void Move()
    {
        Vector3 moviment = transform.forward  * m_Speed * Time.deltaTime;

        m_Rigidbody.MovePosition(m_Rigidbody.position + moviment);

        //m_Rigidbody.MovePosition(m_Rigidbody.position + moviment);

        //m_Rigidbody.MovePosition(transform.position + transform.forward * Time.deltaTime);

        //rb.AddForce(transform.forward * thrust);

        /*if(transform.position.x != posicao_anterior.x)
        {
            transform.Translate(Vector3.forward * 0.1f, Space.World);
            posicao_anterior = transform.position;
        }
        else if(transform.position.z != posicao_anterior.z)
        {
            transform.Translate(Vector3.back * 0.1f, Space.World);
            posicao_anterior = transform.position;
        }*/


    }


    private void Turn()
    {
        // Adjust the rotation of the tank based on the player's input.
        float turn = m_TurnSpeed * Time.deltaTime;

        Quaternion turnRotation = Quaternion.Euler(0f, turn, 0f);

        m_Rigidbody.MoveRotation(m_Rigidbody.rotation * turnRotation);

    }
}
