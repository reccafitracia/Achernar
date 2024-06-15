using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.SceneManagement;

public class PauseMenuManager : MonoBehaviour
{
    [Header("Settings Overlay")]
    [SerializeField] private GameObject _pauseCanvas;
    [SerializeField] private GameObject _settingsCanvas;

    [SerializeField] private GameObject _pauseOverlaySelectedFirst;
    [SerializeField] private GameObject _settingsOverlaySelectedFirst;
    // [SerializeField] private GameObject _backToMainMenuButton;

    private bool isPaused;
    // Start is called before the first frame update
    void Start()
    {
        _pauseCanvas.SetActive(false);
        _settingsCanvas.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(InputManager.Instance.PauseOpenAndCloceInput)
        {
            if(!isPaused)
            {
                Pause();
            }
            else
            {
                Unpause();
            }
        }
        
    }

    public void Pause()
    {
        isPaused = true;
        Time.timeScale = 0f;

        OpenPauseOverlay();
    }

    public void Unpause()
    {
        isPaused = false;
        Time.timeScale = 1f;

        ClosePauseOverlay();
    }

    private void OpenPauseOverlay()
    {
        _pauseCanvas.SetActive(true);
        _settingsCanvas.SetActive(false);

        EventSystem.current.SetSelectedGameObject(_pauseOverlaySelectedFirst);
    }

    private void OpenSettingsOverlayHandle()
    {
        _pauseCanvas.SetActive(false);
        _settingsCanvas.SetActive(true);

        EventSystem.current.SetSelectedGameObject(_settingsOverlaySelectedFirst);
    }

    private void ClosePauseOverlay()
    {
        _pauseCanvas.SetActive(false);
        _settingsCanvas.SetActive(false);

        EventSystem.current.SetSelectedGameObject(null);
    }

    public void OnResumePress()
    {
        Unpause();
    }

    public void OnSettingsPress()
    {
        OpenSettingsOverlayHandle();
    }

    public void OnSettingsBackPress()
    {
        OpenPauseOverlay();
    }

    public void OnBackToMainMenuPress()
    {
        SceneManager.LoadScene(0);
    }
}
