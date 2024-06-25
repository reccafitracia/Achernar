using UnityEngine;
using UnityEngine.UI;
using System.Collections.Generic;

public class DialogButton : MonoBehaviour
{
    public Button button;
    public DialogManager dialogManager;
    public Dialog[] dialogToShow;
    public List<GameObject> objActive;
    public List<GameObject> objNonActive;

    void Start()
    {
        button.onClick.AddListener(ShowDialog);
    }

    void ShowDialog()
    {
        dialogManager.StartDialog(dialogToShow, OnDialogComplete);
    }

    void OnDialogComplete()
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
