using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class PotionPickup : MonoBehaviour
{
    //variable keeping track of the potions collected
    public int potions = 0;
    private Text potionDisplay;
    public GameObject childWithPotionText;
    
    void Start()
    {
        potionDisplay = childWithPotionText.GetComponent<Text>();
        SetPotionDisplay();
    }

    void SetPotionDisplay(){
        potionDisplay.text = "ingredient count: " + potions.ToString();
    }


    private void OnTriggerEnter2D(Collider2D other){
        if(other.gameObject.CompareTag("potion_2")){
        other.gameObject.SetActive(false);
        potions = potions + 1;
        SetPotionDisplay();
        }if(other.gameObject.CompareTag("magicBook")){
        other.gameObject.SetActive(false);
        potions = potions + 1;
        SetPotionDisplay();
        }if(other.gameObject.CompareTag("gem_4")){
        other.gameObject.SetActive(false);
        potions = potions + 1;
        SetPotionDisplay();
        }if(other.gameObject.CompareTag("potion_3")){
        other.gameObject.SetActive(false);
        potions = potions + 1;
        SetPotionDisplay();
        }if(other.gameObject.CompareTag("feather")){
        other.gameObject.SetActive(false);
        potions = potions + 1;
        SetPotionDisplay();
        }
        
    }


}
