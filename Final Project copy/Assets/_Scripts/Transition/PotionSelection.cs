using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PotionSelection : MonoBehaviour
{
    public Text Title;
    public Text howToUseText;
    public Text abilityDescriptionText;
    public Text costText;

    InstantHealthBoost Potion1BoostScript;
    CoinScripts coinScript;

    public GameObject AbilitiesSign;
    public GameObject AbilitiesSignText;
    public GameObject NotEnoughCoins;
    
    
    private GameObject player;

    private bool _isVisible = false;
    private int _viewing = 1;
    private int _coins = 0;

   

    void Start()
    {
        player = MainManager.Instance.player;
        coinScript = player.GetComponent<CoinScripts>();
        _coins = coinScript.count;
        
    }

    
    public void Potion1Clicked()
    {
        _viewing = 1;
        Title.text = "Instant Health Regeneration";
        abilityDescriptionText.text = "Instantly heal your player's health by 50 points";
        howToUseText.text = "Press R to use the ability during gameplay. Can only be used once every 10 seconds";
        costText.text = "12 coins";
        DisplayAbilitiesWindow();
    }

    public void Potion2Clicked()
    {
        _viewing = 2;
        Title.text = "Doubletime Regeneration";
        abilityDescriptionText.text = "Player's health regenerates 2 times faster";
        howToUseText.text = "";
        costText.text = "10 coins";
        DisplayAbilitiesWindow();
    }

    public void Potion3Clicked()
    {
        _viewing = 3;
        Title.text = "Double Coins";
        abilityDescriptionText.text = "Every coin collected in levels gives you 2 coins worth";
        howToUseText.text = "";
        costText.text = "8 coins";
        DisplayAbilitiesWindow();
    }

    void DisplayAbilitiesWindow()
    {
        if (!_isVisible)
        {
            AbilitiesSign.SetActive(true);
            AbilitiesSignText.SetActive(true);
            _isVisible = true;
        }
        else
        {
            AbilitiesSign.SetActive(false);
            AbilitiesSignText.SetActive(false);
            _isVisible = false;
        }
    }

    public void BuyClicked()
    {
        if(_viewing == 1 && _coins >= 12)
        {
            player.gameObject.AddComponent<InstantHealthBoost>();
            coinScript.addCoins(-12);
            _coins -= 12;
    
        }
        else if(_viewing == 2 && _coins >= 10)
        {
            MainManager.Instance.regenerationSpeed = 5f;
            coinScript.addCoins(-10);
            _coins -= 10;
        }
        else if(_viewing == 3 && _coins >= 8)
        {
            MainManager.Instance.incrementCoinValue = 2;
            coinScript.addCoins(-8);
            _coins -= 8;
        }
        else
        {
            NotEnoughCoins.SetActive(true);
            Invoke("DisableNotEnoughCoinsWarning", 2f);
        }
    }

    void DisableNotEnoughCoinsWarning()
    {
        NotEnoughCoins.SetActive(false);
    }
}
