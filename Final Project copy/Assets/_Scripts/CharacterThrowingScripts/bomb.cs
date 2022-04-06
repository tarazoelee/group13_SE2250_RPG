using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bomb : MonoBehaviour
{
    public float speed = 20f;
    public Rigidbody2D rb;
    // Start is called before the first frame update
    public GameObject ronald;
    HealthSystemForDummies ronaldHealth;
    HealthSystemForDummies ghoulHealth;
    HealthSystemForDummies banditHealth;

    public GameObject LightBandit;
    CoinScripts coinScripts;

    public GameObject character;

    public GameObject ghoul;

    private float banditCurrentHealth=0f;
    private float ghoulCurrentHealth=0f;
    private float ronaldCurrentHealth=0f;


    private void Awake(){
        //ronaldHealth= ronald.GetComponent<HealthSystemForDummies>();
       //banditHealth= LightBandit.GetComponent<HealthSystemForDummies>();
      // ghoulHealth= ghoul.GetComponent<HealthSystemForDummies>();
       //coinScripts = GetComponent<CoinScripts>();
       character= MainManager.Instance.player;
       coinScripts = character.GetComponent<CoinScripts>();
   }
    void Start()
    {
        rb.velocity = transform.right*speed;
        //coin = MainManager.Instance.numOfCoins;
    }

void OnTriggerEnter2D(Collider2D enemy){
    Destroy(gameObject); 
    Debug.Log("shot");
    //HealthSystemForDummies healthSystem = enemy.gameObject.GetComponent<HealthSystemForDummies>();
    if(enemy.gameObject.tag=="Enemy"||enemy.gameObject.tag=="burningGhoul"||enemy.gameObject.tag=="ronald"){
        Destroy(enemy.gameObject);
        Debug.Log("killed" + enemy.gameObject.tag);
         //coinScripts.addCoins(5);
         coinScripts.addCoins(5);
    }
}

}


