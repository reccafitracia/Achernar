using TMPro;
using UnityEngine;
using System.Collections.Generic;

public class DisplayTaskDay2 : MonoBehaviour
{
    public TMP_Text dialogCounterDisplay;
    public TMP_Text puzzWinDisplay;
    public List<GameObject> objActive;
    public List<GameObject> objNonActive;

    // Start is called before the first frame update
    void Start()
    {
        //UpdateDisplayText();
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
        int maxDialogCount = 3;
        if(DialogCompletionCounter.dialogCount>=3)
        {
            currentDialogCount=3;
        }
        dialogCounterDisplay.text = $"{currentDialogCount}/{maxDialogCount}";
    }

    public void UpdateDispayPuzz()
    {
        int currentWinPuzz = PuzzleData.CurrentWin;
        int maxWinPuzz = 3;
        if(currentWinPuzz >=3)
        {
            currentWinPuzz=3;
        }
        puzzWinDisplay.text = $"{currentWinPuzz}/{maxWinPuzz}";
    }
}
