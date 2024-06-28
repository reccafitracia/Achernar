using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

[System.Serializable]
public class Dialog
{
    public string speakerName;
    [TextArea(3, 10)]
    public string dialogText;
}

public class DialogManager : MonoBehaviour
{
    public TMP_Text speakerNameText;
    public TMP_Text dialogText;
    public Button continueButton;
    public GameObject DialogBox;

    public List<GameObject> objActive;
    public List<GameObject> objNonActive;
    public List<Button> dialogueButtons;

    private Dialog[] dialogs;
    private int currentDialogIndex;
    private System.Action onDialogCompleteCallback;

    void Start()
    {
        continueButton.onClick.AddListener(DisplayNextSentence);
    }
    
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            DisplayNextSentence();
        }
    }

    public void StartDialog(Dialog[] dialogArray, System.Action onDialogComplete = null)
    {
        SetButtonsActive(false);

        dialogs = dialogArray;
        currentDialogIndex = 0;
        onDialogCompleteCallback = onDialogComplete;
        DisplayCurrentDialog();
    }

    public void DisplayNextSentence()
    {
        currentDialogIndex++;
        if (currentDialogIndex < dialogs.Length)
        {
            DisplayCurrentDialog();
        }
        else
        {
            EndDialog();
        }
    }

    void DisplayCurrentDialog()
    {
        DialogBox.SetActive(true);
        speakerNameText.text = dialogs[currentDialogIndex].speakerName;
        dialogText.text = dialogs[currentDialogIndex].dialogText;
        LayoutRebuilder.ForceRebuildLayoutImmediate(DialogBox.GetComponent<RectTransform>());
    }

    void EndDialog()
    {
        DialogBox.SetActive(false);
        speakerNameText.text = "";
        dialogText.text = "";

        // Set objActive to false
        foreach (var obj in objActive)
        {
            obj.SetActive(false);
        }

        // Set objNonActive to true
        foreach (var obj in objNonActive)
        {
            obj.SetActive(true);
        }

        SetButtonsActive(true);
        onDialogCompleteCallback?.Invoke();
    }

    private void SetButtonsActive(bool isActive)
    {
        foreach (var button in dialogueButtons)
        {
            button.gameObject.SetActive(isActive);
        }
    }
}
