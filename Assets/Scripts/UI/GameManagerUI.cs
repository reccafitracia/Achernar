using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManagerUI : MonoBehaviour
{
    public static GameManagerUI Instance;
    public int CurrentDay = 1;
    void Start()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    public void SkipDay()
    {
        CurrentDay++;
        Debug.Log("Current Day : " + CurrentDay);
    }

    public void ResetDay()
    {
        CurrentDay = 1;
    }

}