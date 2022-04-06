using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class CoinScripts : MonoBehaviour
{
   public int count = 0;
   private Text counterText;
   public int incrementValue = 1;
    public GameObject counterTextContainer;
    

   void Start(){
       
        counterText = counterTextContainer.GetComponent<Text>();
        incrementValue = MainManager.Instance.incrementCoinValue;
        count = MainManager.Instance.numOfCoins;
        setCounterText();
   } 

   public void OnTriggerEnter2D(Collider2D collide){
        if(collide.gameObject.tag=="coin"){
            Destroy(collide.gameObject);
            count = count+incrementValue;
            setCounterText();
        }
    }
    public void addCoins(int num){
        count=count+num;
        setCounterText();
    }
    void setCounterText(){
        counterText.text="Coins: "+count.ToString();
    }

}
