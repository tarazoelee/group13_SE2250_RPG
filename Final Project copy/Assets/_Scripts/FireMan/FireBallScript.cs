using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireBallScript : MonoBehaviour
{
    public float dieTime;
    public float damage;

    private GameObject playerGuy;
    PlayerHealth playerHealth;


   void Start(){
       StartCoroutine(CountDownTimer());
       gameObject.SetActive(true);
        playerGuy = MainManager.Instance.player;
        playerHealth = playerGuy.GetComponent<PlayerHealth>();
   }

  

    void OnTriggerEnter2D(Collider2D col)
    {
        if (col.gameObject.tag == "player")
        {
            playerHealth.UpdateHealth(-10);
            Destroy(gameObject);
        }
        if(col.gameObject.tag=="wall"){
            Destroy(this.gameObject);
        }
    }

    IEnumerator CountDownTimer(){
        gameObject.SetActive(true);
        yield return new WaitForSeconds(dieTime);
        Die();
    }


    void Die(){
        gameObject.SetActive(false);
    } 





}
