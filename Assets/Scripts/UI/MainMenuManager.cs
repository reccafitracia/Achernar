using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;
using UnityEngine.EventSystems;

public class MainMenuManager : MonoBehaviour
{       
    [Header("Settings Overlay")]
    [SerializeField] private GameObject _mainMenuCanvas;
    [SerializeField] private GameObject _settingsCanvas;
    [SerializeField] private GameObject _aboutCanvas;

    [SerializeField] private GameObject _mainMenuOverlaySelectedFirst;
    [SerializeField] private GameObject _settingsOverlaySelectedFirst;
    [SerializeField] private GameObject _aboutOverlaySelectedFirst;

    // [SerializeField] private GameObject _newGameButton;
    // [SerializeField] private GameObject _exitButton;

    private bool isPaused;
    // Start is called before the first frame update
    void Start()
    {
        _mainMenuCanvas.SetActive(true);
        _settingsCanvas.SetActive(false);
        _aboutCanvas.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        // if(InputManager.Instance.PauseOpenAndCloceInput)
        // {
        //     if(!isPaused)
        //     {
        //         Pause();
        //     }
        //     else
        //     {
        //         Unpause();
        //     }
        // }
        
    }

    // public void Pause()
    // {
    //     isPaused = true;
    //     Time.timeScale = 0f;

    //     OpenPauseOverlay();
    // }

    // public void Unpause()
    // {
    //     isPaused = false;
    //     Time.timeScale = 1f;

    //     ClosePauseOverlay();
    // }

    private void OpenMainMenuOverlay()
    {
        _mainMenuCanvas.SetActive(true);
        _settingsCanvas.SetActive(false);
        _aboutCanvas.SetActive(false);

        EventSystem.current.SetSelectedGameObject(_mainMenuOverlaySelectedFirst);
    }

    private void OpenSettingsOverlayHandle()
    {
        _mainMenuCanvas.SetActive(false);
        _settingsCanvas.SetActive(true);
        _aboutCanvas.SetActive(false);

        EventSystem.current.SetSelectedGameObject(_settingsOverlaySelectedFirst);
    }

    private void OpenAboutOverlayHandle()
    {
        _mainMenuCanvas.SetActive(false);
        _settingsCanvas.SetActive(false);
        _aboutCanvas.SetActive(true);

        EventSystem.current.SetSelectedGameObject(_aboutOverlaySelectedFirst);
    }

    // private void ClosePauseOverlay()
    // {
    //     _settingsCanvas.SetActive(false);
    //     _aboutCanvas.SetActive(false);

    //     EventSystem.current.SetSelectedGameObject(null);
    // }
    public void OnNewGamePress()
    {
        SceneManager.LoadScene(1);
    }

    public void OnExitPress()
    {
        Application.Quit();
    }
    public void OnSettingsPress()
    {
        OpenSettingsOverlayHandle();
    }

    public void OnAboutPress()
    {
        OpenAboutOverlayHandle();
    }

    public void OnSettingsBackPress()
    {
        OpenMainMenuOverlay();
    }

    public void OnAboutBackPress()
    {
        OpenMainMenuOverlay();
    }
}
