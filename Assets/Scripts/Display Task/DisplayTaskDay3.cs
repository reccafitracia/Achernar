using TMPro;
using UnityEngine;
using System.Collections.Generic;

public class DisplayTaskDay3 : MonoBehaviour
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
        
        if(DialogCompletionCounter.dialogCount>=3 && PuzzleData.CurrentWin>=3)
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
        int maxDialogCount = 1;
        if(DialogCompletionCounter.dialogCount>=1)
        {
            currentDialogCount=1;
            nextTaskDisplay1.SetActive(true);
        }
        dialogCounterDisplay.text = $"{currentDialogCount}/{maxDialogCount}";
    }

    public void UpdateDispayPuzz()
    {
        int currentWinPuzz = PuzzleData.CurrentWin;
        int maxWinPuzz = 1;
        if(currentWinPuzz >=1)
        {
            currentWinPuzz=1;
            nextTaskDisplay2.SetActive(true);
        }
        puzzWinDisplay.text = $"{currentWinPuzz}/{maxWinPuzz}";
    }
}
