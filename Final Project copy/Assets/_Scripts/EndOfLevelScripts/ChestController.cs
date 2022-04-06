using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChestController : MonoBehaviour
{
    Animator anim;

    void Awake()
    {
        anim = gameObject.GetComponent<Animator>();
    }

    public void Open()
    {
        Debug.Log("Here");
        anim.SetTrigger("Open");
    }
}
