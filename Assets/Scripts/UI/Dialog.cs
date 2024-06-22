using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class Dialog : MonoBehaviour
{
    public TextMeshProUGUI textComponent;
    public string[] sentences;
    public float txtSpeed;
    private int index;
    public Button continueButton;

    void Start()
    {
        textComponent.text = string.Empty;
       // continueButton.gameObject.SetActive(false);
        StartDialog();
    }

    void StartDialog()
    {
        index = 0;
        StartCoroutine(TypeLine());
    }

    IEnumerator TypeLine()
    {
       // continueButton.gameObject.SetActive(false);
        foreach (char c in sentences[index].ToCharArray())
        {
            textComponent.text += c;
            yield return new WaitForSeconds(txtSpeed);
        }
        continueButton.gameObject.SetActive(true);
    }

    void NextLine()
    {
       // continueButton.gameObject.SetActive(false);
        if (index < sentences.Length - 1)
        {
            index++;
            textComponent.text = string.Empty;
            StartCoroutine(TypeLine());
        }
        else
        {
            gameObject.SetActive(false);
        }
    }

    public void OnContinueButtonPressed()
    {
        if (textComponent.text == sentences[index])
        {
            NextLine();
        }
        else
        {
            StopAllCoroutines();
            textComponent.text = sentences[index];
            continueButton.gameObject.SetActive(true);
        }
    }
}
