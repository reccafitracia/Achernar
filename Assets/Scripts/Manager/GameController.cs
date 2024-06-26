using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public GameObject SkipDayButtonVar;
    public GameObject EndGameOverlay;
    public DayDisplay dayDisplay;
    public DayManager dayManager;

    void Start()
    {
        //int currentDialogCount = DialogCompletionCounter.GetDialogCount();
        if (dayDisplay == null)
        {
            return;
        }

        if (dayManager == null)
        {
            return;
        }

        dayDisplay.UpdateDayDisplay();
    }

    void Update()
    {
        if(SingletonData.Instance.CurrentDay==1)
        {
            if(DialogCompletionCounter.GetDialogCount() < 5)
            {
                SkipDayButtonVar.SetActive(false);
            }
            else
            {
                SkipDayButtonVar.SetActive(true);
            }
        }
          if(SingletonData.Instance.CurrentDay==2)
        {
            if(DialogCompletionCounter.GetDialogCount() < 3 && PuzzleData.CurrentWin<3)
            {
                SkipDayButtonVar.SetActive(false);
            }
            else
            {
                SkipDayButtonVar.SetActive(true);
            }
        }
          if(SingletonData.Instance.CurrentDay==3)
        {
            if(DialogCompletionCounter.GetDialogCount() < 1)
            {
                SkipDayButtonVar.SetActive(false);
            }
            else
            {
                SkipDayButtonVar.SetActive(true);
            }
        }
    }
    public void OnSkipDayButtonPressed()
    {
        if (SingletonData.Instance == null)
        {
            return;
        }

        SingletonData.Instance.SkipDay();
        dayDisplay.UpdateDayDisplay();
        dayManager.UpdateDayObjects();
        DialogCompletionCounter.ResetDialogCounter();

        if (SingletonData.Instance.CurrentDay >= 4)
        {
            if (SkipDayButtonVar != null)
            {
                SkipDayButtonVar.SetActive(false);
            }
            else
            {
                //
            }

            if (EndGameOverlay != null)
            {
                EndGameOverlay.SetActive(true);
            }
            else
            {
                //
            }
        }
    }

    public void OnBackToMainMenu()
    {
        if (SingletonData.Instance == null)
        {
            return;
        }
        DialogCompletionCounter.ResetDialogCounter();
        PuzzleData.ResetCurrentWin();
        SingletonData.Instance.ResetDay();
        dayDisplay.UpdateDayDisplay();
    }
}