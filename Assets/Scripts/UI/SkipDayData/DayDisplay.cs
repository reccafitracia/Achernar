using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DayDisplay : MonoBehaviour
{
    public TMP_Text dayText;

    void Start()
    {
        UpdateDayDisplay();
    }

    public void UpdateDayDisplay()
    {
        dayText.text = SingletonData.Instance.CurrentDay.ToString();
   
    }
}
