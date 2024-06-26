using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class DialogCompletionCounter
{
    public static int dialogCount = 0;

    public static void IncrementDialogCount()
    {
        dialogCount++;
       // Debug.Log("dialogcount"+dialogCount);
    }

    public static int GetDialogCount()
    {
        return dialogCount;
    }

    public static int ResetDialogCounter()
    {
        return dialogCount = 0;
    }
}
