using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PegarLixo : MonoBehaviour {

    public float m_StartingHealth = 100f;
    public Slider m_Slider;
    public Image m_FillImage;
    public Color m_FullHealthColor = Color.green;
    public Color m_ZeroHealthColor = Color.red;
    
    private float m_CurrentHealth;
    private bool podePegar;

    public bool PodePegar()
    {
        return podePegar;
    }
    
    public void setPodePegar(bool pode)
    {
        podePegar = pode;
    }

    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnEnable()
    {
        m_CurrentHealth = m_StartingHealth;
        podePegar = false;

        SetHealthUI();

    }

    public void ResetLixo()
    {
        m_CurrentHealth = m_StartingHealth;
        podePegar = false;
        gameObject.transform.SetParent(null);
        SetHealthUI();
    }

    private void SetHealthUI()
    {
        // Adjust the value and colour of the slider.
        m_Slider.value = m_CurrentHealth;
        m_FillImage.color = Color.Lerp(m_ZeroHealthColor, m_FullHealthColor, m_CurrentHealth / m_StartingHealth);

    }

    private void OnDeath()
    {
        // Play the effects for the death of the tank and deactivate it.
        podePegar = true;


    }

    public void TakeDamage(float amount)
    {
        // Adjust the tank's current health, update the UI based on the new health and check whether or not the tank is dead.
        Debug.Log("Recebeu dano= " + amount);
        m_CurrentHealth -= amount;
        SetHealthUI();

        if (m_CurrentHealth <= 0f && !podePegar)
        {
            OnDeath();
        }

    }
}
