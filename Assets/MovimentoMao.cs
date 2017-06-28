using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovimentoMao : MonoBehaviour
{
    public float m_Speed = 12f;
    public float m_TurnSpeed = 180f;
  

    private string m_MovementAxisName;
    private string m_TurnAxisName;
    private Rigidbody m_Rigidbody;
    private float m_MovementInputValue;
    private float m_TurnInputValue;
    


    private void Awake()
    {
        m_Rigidbody = GetComponent<Rigidbody>();
    }


    private void OnEnable()
    {
        //m_Rigidbody.isKinematic = false;
        m_MovementInputValue = 0f;
        m_TurnInputValue = 0f;
    }


    private void OnDisable()
    {
        //m_Rigidbody.isKinematic = true;
    }


    private void Start()
    {
   

    }

    private void FixedUpdate()
    {
        // Move and turn the tank.

        Move();
       // Turn();
    }


    private void Move()
    {
        // Adjust the position of the tank based on the player's input.
        Vector3 moviment = transform.position  * m_Speed * Time.deltaTime;

        transform.Translate(transform.position + moviment);

        //m_Rigidbody.MovePosition(m_Rigidbody.position + moviment);

    }


    private void Turn()
    {
        // Adjust the rotation of the tank based on the player's input.
        float turn =  m_TurnSpeed * Time.deltaTime;

        Quaternion turnRotation = Quaternion.Euler(0f, turn, 0f);

        m_Rigidbody.MoveRotation(m_Rigidbody.rotation * turnRotation);

    }
}

