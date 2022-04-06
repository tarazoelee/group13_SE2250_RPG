using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Weapon : MonoBehaviour
{
    public Transform firePoint;
    private Animator anim; 
    public GameObject bomb;

    // Start is called before the first frame update
    void Awake(){
        anim = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.E)){
            Shoot();
        }
    }

     private void Shoot(){
       anim.SetTrigger("shoot");
       GameObject newBomb = Instantiate(bomb,firePoint.position,firePoint.rotation);
       Debug.Log("creating bomb");
   }
}
