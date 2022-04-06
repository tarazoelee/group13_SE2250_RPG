using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PlayerHealth : MonoBehaviour
{
    HealthSystemForDummies healthScript;
    public float health= 0f;
    [SerializeField]private float maxHealth = 100f;

    private Animator anim;
    public float currentHealth = 100f;

    private void Start(){

        healthScript = GetComponent<HealthSystemForDummies>();
        anim = GetComponent<Animator>();
        health= maxHealth;
        
    }

    public void UpdateHealth(float mod){
        healthScript.AddToCurrentHealth(mod);
        currentHealth += mod;

        if(currentHealth <= 0f)
        {
            anim.SetTrigger("die");
            Invoke("Respawn", 2f);
        }
    
    }

    public void Respawn()
    {
        healthScript.ReviveWithMaximumHealth();
        currentHealth=100f;
        transform.position = new Vector3(-6f, 1f, 10f);
    }

    
}
