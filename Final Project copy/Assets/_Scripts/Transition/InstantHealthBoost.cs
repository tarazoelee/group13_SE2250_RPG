using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InstantHealthBoost : MonoBehaviour
{
    private PlayerHealth playerHealth;
    private GameObject player;
    private bool _isInCooldown = false;

   
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("player");
        playerHealth = player.GetComponent<PlayerHealth>();
    }

    
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.R) && !_isInCooldown)
        {
            _isInCooldown = true;
            InstantHeal();
            Invoke("SetActiveAgain", 10f);
        }
    }

    void InstantHeal()
    {
        playerHealth.UpdateHealth(50f);
    }

    void SetActiveAgain()
    {
        Debug.Log("Here");
        _isInCooldown = false;
    }
}
