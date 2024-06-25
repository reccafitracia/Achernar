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
    public List<Button> dialogueButtons;
    private Dialog[] dialogs;
    private int currentDialogIndex;

    void Start()
    {
        continueButton.onClick.AddListener(DisplayNextSentence);
    }

    public void StartDialog(Dialog[] dialogArray)
    {

        SetButtonsActive(false);

        dialogs = dialogArray;
        currentDialogIndex = 0;
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
    }

    void EndDialog()
    {
        DialogBox.SetActive(false);
        speakerNameText.text = "";
        dialogText.text = "";

        foreach (var obj in objActive)
        {
            obj.SetActive(false);
        }

        SetButtonsActive(true);
    }

    private void SetButtonsActive(bool isActive)
    {
        foreach (var button in dialogueButtons)
        {
            button.gameObject.SetActive(isActive);
        }
    }
}
