using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene3Areas : MonoBehaviour
{
    public void OnVillagePress()
    {
        SceneManager.LoadScene(2);
    }

    public void OnRiverPress()
    {
        SceneManager.LoadScene(3);
    }

    public void OnFactoryPress()
    {
        SceneManager.LoadScene(4);
    }

    public void OnBackToMap()
    {
        SceneManager.LoadScene(1);
    }


}
