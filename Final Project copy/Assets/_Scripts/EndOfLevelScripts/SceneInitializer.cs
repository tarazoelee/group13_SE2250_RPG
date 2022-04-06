using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneInitializer : MonoBehaviour
{

    private GameObject player;
    private int playerSelect;

    CoinScripts coinScripts;
    PotionPickup potionPickup;
    PlayerHealth playerHealth;
    PlayerController playerController;
    Player2Controller player2Controller;
    Player3Controller player3Controller;
    PlayerAttack playerAttack;
    Player2Attack player2Attack;
    Player3Attack player3Attack;
    
    void Awake()
    {
        playerSelect = MainManager.Instance.playerSelected;

        if(playerSelect == 1)
        {
            player = PlayerController.Player.gameObject;
            playerController = PlayerController.Player.GetComponent<PlayerController>();
            playerController.regenSpeed = MainManager.Instance.regenerationSpeed;
            coinScripts = PlayerController.Player.GetComponent<CoinScripts>();
            playerHealth = PlayerController.Player.GetComponent<PlayerHealth>();
            potionPickup = PlayerController.Player.GetComponent<PotionPickup>();
            playerAttack = PlayerController.Player.GetComponent<PlayerAttack>();
            playerAttack.SetEnemiesScripts();
            
        }
        else if(playerSelect == 2)
        {
            player = Player2Controller.Player.gameObject;
            player2Controller = Player2Controller.Player.GetComponent<Player2Controller>();
            player2Controller.regenSpeed = MainManager.Instance.regenerationSpeed;
            coinScripts = Player2Controller.Player.GetComponent<CoinScripts>();
            playerHealth = Player2Controller.Player.GetComponent<PlayerHealth>();
            potionPickup = Player2Controller.Player.GetComponent<PotionPickup>();
            player2Attack = Player2Controller.Player.GetComponent<Player2Attack>();
            player2Attack.SetEnemiesScripts();
        }
        else
        {
            player = Player3Controller.Player.gameObject;
            player3Controller = player.GetComponent<Player3Controller>();
            player3Controller.regenSpeed = MainManager.Instance.regenerationSpeed;
            coinScripts = player.GetComponent<CoinScripts>();
            playerHealth = player.GetComponent<PlayerHealth>();
            potionPickup = player.GetComponent<PotionPickup>();
            player3Attack = Player3Controller.Player.GetComponent<Player3Attack>();
            player3Attack.SetEnemiesScripts();
        }

        MainManager.Instance.player = player;

        coinScripts.count = MainManager.Instance.numOfCoins;
        coinScripts.incrementValue = MainManager.Instance.incrementCoinValue;
        potionPickup.potions = MainManager.Instance.numOfPotions;

        player.transform.position = new Vector3(-5f,1f,10f);




    }

  
}
