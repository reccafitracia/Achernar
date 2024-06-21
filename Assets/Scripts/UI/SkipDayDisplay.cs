 using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class SkipDayDisplay : MonoBehaviour
{
    public TextMeshProUGUI SkipDayText;
    public Button SkipDayButton;
    void Start()
    {
        // if (skipDayText == null)
        // {
        //     Debug.Log("skipday text not assign");
        // }
        // else{
        //     Debug.Log("skipday text assign");
        // }
        // skipDayText = GetComponent<TextMeshProUGUI>();
        // SkipDayText = FindObjectOfType<Text>();
        // SkipDayButton = FindObjectOfType<Text>();
        // SkipDayText = GameObject.Find("SkipDay Display");
        // SkipDayButton = GameObject.Find("SkipDay Button");
    
    }
    

    // Update is called once per frame
    void Update()
    {
        SkipDayText.text = _GameManager.Instance.CurrentDay.ToString();
        if(_GameManager.Instance.CurrentDay==30){
           // skipDayText.gameObject.SetActive(false);
            SkipDayButton.gameObject.SetActive(false);
            Debug.Log("GameBerakhir");
        }

    }
}
