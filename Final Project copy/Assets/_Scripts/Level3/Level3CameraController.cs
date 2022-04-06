using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Level3CameraController : MonoBehaviour
{
    private int playerOn;

    public Vector3 offset;

    void Start()
    {
        playerOn = MainManager.Instance.playerSelected;
    }

    void Update()
    {
        if (playerOn == 1)
        {
            transform.position = new Vector3(PlayerController.Player.transform.position.x + offset.x, 0f, -10f);
        }
        else if (playerOn == 2)
        {
            transform.position = new Vector3(Player2Controller.Player.transform.position.x + offset.x, 0f, -10f);
        }
        else if (playerOn == 3)
        {
            transform.position = new Vector3(Player3Controller.Player.transform.position.x + offset.x, 0f, -10f);
        }

       

    }


}


