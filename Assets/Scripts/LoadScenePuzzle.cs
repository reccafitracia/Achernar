using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScenePuzzle : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnBagasPress()
    {
        SceneManager.LoadScene(5);
    }

    public void OnLiliPress()
    {
        SceneManager.LoadScene(6);
    }

        public void OnBagusPress()
    {
        SceneManager.LoadScene(7);
    }
}
