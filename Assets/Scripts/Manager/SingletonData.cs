using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public sealed class SingletonData
{
    private SingletonData() { }

    private static SingletonData _instance = null;
    public static SingletonData Instance
    {
        get
        {
            if (_instance == null)
            {
                _instance = new SingletonData();
            }
            return _instance;
        }
    }

    public int CurrentDay { get; private set; } = 1;

    public void SkipDay()
    {
        CurrentDay += 1;
    }

    public void ResetDay()
    {
        CurrentDay = 1;
    }
}
