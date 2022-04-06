using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Npc_animation : MonoBehaviour
{
    [SerializeField] private Animation myPlayer;
    [SerializeField] private string myFight="Fighting";
    // Start is called before the first frame update
    void onTriggerEnter2D(Collider2D col)
    {
        if(col.CompareTag("player")){
            myPlayer.Play(myFight);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    void OnCollisionEnter(Collision collision) {
        if (collision.transform.CompareTag("player")) {
        HealthSystemForDummies healthSystem = collision.gameObject.GetComponent<HealthSystemForDummies>();
        // Damage enemy for -100 units
        healthSystem.AddToCurrentHealth(-100); }
        }
    
}
