using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject SkipDayButtonVar;
    public GameObject EndGameOverlay;
    public DayDisplay dayDisplay;

    void Start()
    {
        dayDisplay.UpdateDayDisplay();
    }

    public void OnSkipDayButtonPressed()
    {
        SingletonData.Instance.SkipDay();
        dayDisplay.UpdateDayDisplay();
        if (SingletonData.Instance.CurrentDay >= 7)
        {
            SkipDayButtonVar.SetActive(false);
            EndGameOverlay.SetActive(true);
        }

    }

    public void OnBackToMainMenu()
    {
        SingletonData.Instance.ResetDay();

        dayDisplay.UpdateDayDisplay();

    }
}
