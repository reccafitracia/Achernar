using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class DisplayTaskDay1 : MonoBehaviour
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
        if(DialogCompletionCounter.dialogCount>=5)
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
        int maxDialogCount = 5;
        if(DialogCompletionCounter.dialogCount>=5)
        {
            currentDialogCount=5;
        }
        dialogCounterDisplay.text = $"{currentDialogCount}/{maxDialogCount}";
    }
}
