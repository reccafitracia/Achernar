using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

[System.Serializable]
public class DayConfiguration
{
    public int day;
    public List<GameObject> objActive;
    public List<GameObject> objNonActive;
}

public class DayManager : MonoBehaviour
{
    public List<DayConfiguration> dayConfigurations;

    void Start()
    {
        UpdateDayObjects();
    }

    void Update()   
    {
        
    }

    public void UpdateDayObjects()
    {
        int currentDay = SingletonData.Instance.CurrentDay;

        foreach (var config in dayConfigurations)
        {
            SetActiveObjects(config.objActive, false);
            SetActiveObjects(config.objNonActive, true);
        }
        foreach (var config in dayConfigurations)
        {
            if (config.day == currentDay)
            {
                SetActiveObjects(config.objActive, true);
                SetActiveObjects(config.objNonActive, false);
                break;
            }
        }
    }

    void SetActiveObjects(List<GameObject> objects, bool isActive)
    {
        foreach (var obj in objects)
        {
            if (obj != null)
            {
                obj.SetActive(isActive);
            }
        }
    }
}