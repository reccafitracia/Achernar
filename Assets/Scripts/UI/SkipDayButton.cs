using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkipDayButton : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void OnSkipDayPress()
    {
        GameManagerUI.Instance.SkipDay();
    }
}
