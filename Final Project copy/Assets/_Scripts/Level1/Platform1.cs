using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Platform1 : MonoBehaviour
{
    public Transform pos1;
    public Transform pos2; 
    public float speed = 0f; 
    public Transform startPos; 
    Vector3 nextPos;
    private Transform playerTransform;
    private GameObject guy;

    // Start is called before the first frame update
    void Start()
    {
        nextPos = startPos.position;
        guy = MainManager.Instance.player;
        playerTransform = guy.GetComponent<Transform>();
    }

    // Update is called once per frame
    void Update()
    {
        if(transform.position==pos1.position){
            nextPos= pos2.position; 

        }
        if(transform.position ==pos2.position){
            nextPos = pos1.position;
        }
        transform.position = Vector3.MoveTowards(transform.position, nextPos, speed*Time.deltaTime);
    }
    private void OnDrawGizmos(){
       Gizmos.DrawLine(pos1.position,pos2.position);
    }

    private void OnCollisionEnter2D(Collision2D col){
        if(col.gameObject.CompareTag("player")){ //if player collides with the platform then stays on 
           
        }
    }
    private void OnCollisionExit2D(Collision2D col){
        if(col.gameObject.CompareTag("player")){ //exiting the collsion
        }
    }


    }
