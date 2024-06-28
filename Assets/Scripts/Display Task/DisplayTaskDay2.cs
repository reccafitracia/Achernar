using TMPro;
using UnityEngine;
using System.Collections.Generic;
using System;

public class DisplayTaskDay2 : MonoBehaviour
{
    public TMP_Text dialogCounterDisplay;
    public TMP_Text puzzWinDisplay;
    public GameObject nextTaskDisplay1;
    public GameObject nextTaskDisplay2;
    public List<GameObject> objActive;
    public List<GameObject> objNonActive;

    // Start is called before the first frame update
    void Start()
    {
        //UpdateDisplayText();
        nextTaskDisplay1.SetActive(false);
        nextTaskDisplay2.SetActive(false);
    }

    void Update()
    {
        UpdateDisplayText();
        UpdateDispayPuzz();
        if(SingletonData.Instance.CurrentDay==3)
        {
            PuzzleData.ResetCurrentWin();
        }
        
        if(DialogCompletionCounter.dialogCount>=2 && PuzzleData.CurrentWin>=2)
        {
            foreach (var obj in objActive)
            {
                obj.SetActive(true);
            }

            foreach (var obj in objNonActive)
            {
                obj.SetActive(false);
            }
        }
    }

    public void UpdateDisplayText()
    {
        int currentDialogCount = DialogCompletionCounter.dialogCount;
        int maxDialogCount = 2;
        if(DialogCompletionCounter.dialogCount>=2)
        {
            currentDialogCount=2;
            nextTaskDisplay1.SetActive(true);
        }
        dialogCounterDisplay.text = $"{currentDialogCount}/{maxDialogCount}";
    }

    public void UpdateDispayPuzz()
    {
        int currentWinPuzz = PuzzleData.CurrentWin;
        int maxWinPuzz = 2;
        if(currentWinPuzz >=2)
        {
            currentWinPuzz=2;
            nextTaskDisplay2.SetActive(true);
        }
        puzzWinDisplay.text = $"{currentWinPuzz}/{maxWinPuzz}";
    }
}
