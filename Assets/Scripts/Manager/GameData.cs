using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameData
{
    public static GameData Data = new GameData();

    public int CurrentDay = 0;

    public void SkipDay()
    {
        CurrentDay += 1;
    }

    public void ResetDay()
    {
        CurrentDay = 0;
    }
}
