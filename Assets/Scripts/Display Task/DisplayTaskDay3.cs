using TMPro;
using UnityEngine;
using System.Collections.Generic;

public class DisplayTaskDay3 : MonoBehaviour
{
    public TMP_Text dialogCounterDisplay;
    public GameObject nextTaskDisplay;
    public List<GameObject> objActive;
    public List<GameObject> objNonActive;

    // Start is called before the first frame update
    void Start()
    {
        //UpdateDisplayText();
        nextTaskDisplay.SetActive(false);
    }

    void Update()
    {
        UpdateDisplayText();

        if(DialogCompletionCounter.dialogCount>=1)
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
            nextTaskDisplay.SetActive(true);
        }
        dialogCounterDisplay.text = $"{currentDialogCount}/{maxDialogCount}";
    }

}
