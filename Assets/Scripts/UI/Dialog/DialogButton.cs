using UnityEngine;
using UnityEngine.UI;

public class DialogButton : MonoBehaviour
{
    public Button button;
    public DialogManager dialogManager;
    public Dialog[] dialogToShow;

    void Start()
    {
        button.onClick.AddListener(ShowDialog);
    }

    void ShowDialog()
    {
        dialogManager.StartDialog(dialogToShow);
    }
}
