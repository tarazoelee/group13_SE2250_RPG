using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PressurePotion : MonoBehaviour
{
    
    [SerializeField] private Animator finalPotion=null;
   
    

  void OnTriggerEnter2D(Collider2D other){
      if(other.CompareTag("player")){
            //Debug.Log("Here");
          finalPotion.Play("potion_filling",0,0.0f);
      }
  }


}
