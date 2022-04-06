using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playPotionAnimation : MonoBehaviour
{
     Animation potion_fill;
     GameObject finalPotion;
    // Start is called before the first frame update
    void Awake(){
        potion_fill = finalPotion.GetComponent<Animation>();
    }


    void Start()
    {
      potion_fill.Play("potion_fill"); 
    }
   
}
