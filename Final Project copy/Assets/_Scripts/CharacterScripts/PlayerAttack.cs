using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PlayerAttack : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private float attackCooldown; //before fire next shot 
   private Animator anim; 
   private PlayerController playerMovement; 
   private float coolDownTimer = 1;
   public Transform attackPoint;
   public float attackRange=0.5f;
   public LayerMask enemyLayer;
    int coin;
    CoinScripts coinScripts;
   public GameObject LightBandit;
   public GameObject ghoul;

    public Transform firePoint;

    public GameObject bomb;

    public GameObject ronald;
    HealthSystemForDummies ronaldHealth;
    public float ronaldCurrentHealth=100f;
    HealthSystemForDummies banditHealth;
    public float banditCurrentHealth=100f;
    HealthSystemForDummies ghoulHealth;
    public float ghoulCurrentHealth=100f;

    private GameObject ronnyBoy;
    private GameObject banditBoy;
    private GameObject fireBoy;

   private void Awake(){
       anim = GetComponent<Animator>();
       playerMovement = GetComponent<PlayerController>();
       coinScripts = GetComponent<CoinScripts>();

    }
   void Start() { 
    
   }
   private void Update(){
       if(Input.GetKeyDown(KeyCode.W) ){
            Attack();
       }
        if (Input.GetKeyDown(KeyCode.Space) && playerMovement.jumping == false)
        {
            Jump();
        }

        float hMove = Input.GetAxis("Horizontal") * 40f;
        anim.SetFloat("speed",hMove);
       coolDownTimer+=Time.deltaTime;
   }
   private void Attack(){
       anim.SetTrigger("attack");

       Collider2D [] enemies=Physics2D.OverlapCircleAll(attackPoint.position, attackRange, enemyLayer);
       
    foreach(Collider2D enemy in enemies){
        if(enemy.gameObject.tag=="Enemy")
            {
            banditHealth.AddToCurrentHealth(-50);
            banditCurrentHealth-=50;
            if(banditCurrentHealth<=0){
                Destroy(enemy.gameObject);
                coinScripts.addCoins(3);
            }
        }
        else if (enemy.gameObject.tag=="burningGhoul")
            {
            ghoulHealth.AddToCurrentHealth(-25);
            ghoulCurrentHealth-=25;
            if(ghoulCurrentHealth<=0){
                Destroy(enemy.gameObject);
                coinScripts.addCoins(5);
            }
        }
        else if(enemy.gameObject.tag=="ronald")
        {
            ronaldHealth.AddToCurrentHealth(-20);
            ronaldCurrentHealth-=20;
            if(ronaldCurrentHealth<=0){
                Destroy(enemy.gameObject);
                coinScripts.addCoins(7);
            }

        }

    }
      
   }
    private void Jump()
    {
        playerMovement.jumping = true;
        anim.SetBool("isJumping",true);
        playerMovement.Jump();
    }

    public void StopJumping()
    {
        anim.SetBool("isJumping",false);
    }


    public void SetEnemiesScripts()
    {
        ronnyBoy = GameObject.FindGameObjectWithTag("ronald");
        banditBoy = GameObject.FindGameObjectWithTag("Enemy");
        fireBoy = GameObject.FindGameObjectWithTag("burningGhoul");

        if(ronnyBoy != null)
        {
            ronaldHealth = ronnyBoy.GetComponent<HealthSystemForDummies>();
            ronaldHealth.ReviveWithMaximumHealth();
        }
        if(banditBoy != null)
        {
            banditHealth = banditBoy.GetComponent<HealthSystemForDummies>();
            banditHealth.ReviveWithMaximumHealth();
        }
        if(fireBoy != null)
        {
            ghoulHealth = fireBoy.GetComponent<HealthSystemForDummies>();
            ghoulHealth.ReviveWithMaximumHealth();
        }
        
    }
}
