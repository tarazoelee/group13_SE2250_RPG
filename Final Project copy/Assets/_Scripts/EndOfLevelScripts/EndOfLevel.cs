using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndOfLevel : MonoBehaviour
{

    CoinScripts coinScripts;
    PlayerController playerController;
    PlayerHealth playerHealth;
    PotionPickup potionPickup;
    ChestController chestController;

    private GameObject player;


    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.tag == "player")
        {
            player = GameObject.FindGameObjectWithTag("player");
   
            coinScripts = player.GetComponent<CoinScripts>();
            playerController = player.GetComponent<PlayerController>();
            playerHealth = player.GetComponent<PlayerHealth>();
            potionPickup = player.GetComponent<PotionPickup>();
            
            MainManager.Instance.numOfCoins = coinScripts.count;
            MainManager.Instance.numOfPotions = potionPickup.potions;

            LoadNextScene();
        }
    }

    void LoadNextScene()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
