using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField] private float attackDamage=10f;
    [SerializeField] private float attackSpeed=1f;
   
    PlayerHealth playerHealth;
    private Animator animator;
    public LayerMask player;
    public float attackRange=0.5f;
    public Transform attackPoint;
   
    public bool canAttack;

    private GameObject playerGuy;

    CameraController camera;
   
    float fireRate= 3.0f;
    private float nextFire;
   
    private void Awake(){
        animator=GetComponent<Animator>();
    }

    void Start()
    {
        playerGuy = MainManager.Instance.player;
        playerHealth = playerGuy.GetComponent<PlayerHealth>();
    
    }

    private void Update(){
        Collider2D [] chars=Physics2D.OverlapCircleAll(attackPoint.position, attackRange, player);
       int num=chars.Length;
        if(num!=0){
            Attack();
            num--;
        }
        
    }

    private void Attack(){
        if(Time.time>nextFire){
        Collider2D [] chars=Physics2D.OverlapCircleAll(attackPoint.position, attackRange, player);
        foreach(Collider2D players in chars){
           playerHealth.UpdateHealth(-10);
           nextFire=Time.time+fireRate;
        } 
        }
    
    }
}
