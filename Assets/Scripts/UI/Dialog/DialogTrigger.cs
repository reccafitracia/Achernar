using UnityEngine;

public class DialogTrigger : MonoBehaviour
{
    public DialogManager dialogManager;
    public Dialog[] dialogs;

    void Start()
    {
        dialogManager.StartDialog(dialogs);
    }
}
