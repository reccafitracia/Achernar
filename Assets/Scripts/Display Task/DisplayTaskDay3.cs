using TMPro;
using UnityEngine;
using System.Collections.Generic;

public class DisplayTaskDay3 : MonoBehaviour
{
    public TMP_Text dialogCounterDisplay;
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
        }
        dialogCounterDisplay.text = $"{currentDialogCount}/{maxDialogCount}";
    }

}
