using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateMainManager : MonoBehaviour
{
    GameObject mainManagerContainer;

    void Awake()
    {
        mainManagerContainer = new GameObject("MainManager");
        mainManagerContainer.AddComponent<MainManager>();
    }
}
