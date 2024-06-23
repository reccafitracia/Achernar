using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class StaticData
{
    public static int CurrentDay = 0;

    public static void SkipDay()
    {
        CurrentDay += 1;
    }

    public static void ResetDay()
    {
        CurrentDay = 0;
    }
}
