using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainManager : MonoBehaviour
{

    public static MainManager Instance;

    public GameObject player;
    public int incrementCoinValue = 1;
    public float regenerationSpeed = 10f;
    public int numOfCoins = 0;
    public int numOfPotions = 0;
    public int playerSelected = 1;


    void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
            return;
        }

        Instance = this;
        DontDestroyOnLoad(gameObject);
    }

}
