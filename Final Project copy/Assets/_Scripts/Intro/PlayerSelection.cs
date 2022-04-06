using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerSelection : MonoBehaviour
{
    public GameObject playerAPrefab;
    public GameObject playerBPrefab;
    public GameObject playerCPrefab;
    public GameObject displayAbilities;
    

    public Text mainAbilitiesTxt;
    public Text boostAbilitiesTxt;

    public Button button1;
    public Button button2;
    public Button button3;

    private char playerLtr;
    private bool is_Visible = false;
    private GameObject currentPlayer;
    private CoinScripts coinScript;

    public void Awake()
    {
        currentPlayer = Instantiate(playerAPrefab);
        playerLtr = 'A';
    }

    void Start()
    {
        Vector3 position = new Vector3(-7f, -3f, 10f);
        currentPlayer.transform.position = position;
        button1.enabled = false;
        button2.enabled = true;
        button3.enabled = true;
    }


    public void Btn1Clicked()
    {
        Vector3 position = currentPlayer.transform.position;
        position.y += 2;
        Destroy(currentPlayer);
        currentPlayer = Instantiate(playerAPrefab);
        currentPlayer.transform.position = position;
        playerLtr = 'A';
        MainManager.Instance.playerSelected = 1;
        LoadAbilityInfo();

        button1.enabled = false;
        button2.enabled = true;
        button3.enabled = true;
    }

    public void Btn2Clicked()
    {
        Vector3 position = currentPlayer.transform.position;
        Destroy(currentPlayer);
        currentPlayer = Instantiate(playerBPrefab);
        currentPlayer.transform.position = position;
        playerLtr = 'B';
        MainManager.Instance.playerSelected = 2;
        LoadAbilityInfo();

        button1.enabled = true;
        button2.enabled = false;
        button3.enabled = true;
    }

    public void Btn3Clicked()
    {
        Vector3 position = currentPlayer.transform.position;
        position.y += 5;
        Destroy(currentPlayer);
        currentPlayer = Instantiate(playerCPrefab);
        currentPlayer.transform.position = position;
        playerLtr = 'C';
        MainManager.Instance.playerSelected = 3;
        LoadAbilityInfo();

        button1.enabled = true;
        button2.enabled = true;
        button3.enabled = false;
    }

    public void DisplayAbilities()
    {
        if (!is_Visible)
        {
            LoadAbilityInfo();
            displayAbilities.SetActive(true);
            is_Visible = true;
        }

        else
        {
            displayAbilities.SetActive(false);
            is_Visible = false;
        }
    }

    public void LoadAbilityInfo()
    {
        if (playerLtr == 'A')
        {
            mainAbilitiesTxt.text = "Sword Fighting - Press W";
            boostAbilitiesTxt.text = "Fire Throwing - Press E";
        }
        else if (playerLtr == 'B')
        {
            mainAbilitiesTxt.text = "Sword Fighting - Press W";
            boostAbilitiesTxt.text = "Bomb Throwing - Press E";
        }
        else
        {
            mainAbilitiesTxt.text = "Sonic Scream - Press W";
            boostAbilitiesTxt.text = "Wind Slice - Press E";
        }
    }
}
