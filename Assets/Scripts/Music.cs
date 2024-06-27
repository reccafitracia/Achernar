using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.Video;

public class Music : MonoBehaviour
{
    [SerializeField] private AudioSource musicSource;
    public AudioClip Desa;
    public AudioClip River;
    public AudioClip Factory;
    public AudioClip MainMenu;

    private static Music instance;

    private void Awake()
    {
        if (instance != null && instance != this)
        {
            Destroy(gameObject);
            return;
        }

        instance = this;
        DontDestroyOnLoad(gameObject);
    }

    void Start()
    {
        // Memutuskan lagu berdasarkan scene yang aktif saat dimulai
        PlayMusicForScene(SceneManager.GetActiveScene().buildIndex);
    }

    private void OnEnable()
    {
        // Mendaftarkan pendengar untuk event scene loaded
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        // Memutuskan lagu berdasarkan scene yang baru dimuat
        PlayMusicForScene(scene.buildIndex);
    }

    void PlayMusicForScene(int sceneBuildIndex)
    {
        // Memutuskan lagu berdasarkan sceneBuildIndex
        if (sceneBuildIndex == 2)
        {
            // Memainkan lagu gameplay jika di scene 4
            if (musicSource.clip != Desa)
            {
                musicSource.clip = Desa;
                musicSource.Play();
            }
        }
        else if (sceneBuildIndex == 3 || sceneBuildIndex == 5  || sceneBuildIndex == 6 || sceneBuildIndex == 7 )
        {
            // Memainkan lagu default jika di scene 0 atau 1
            if (musicSource.clip != River)
            {
                musicSource.clip = River;
                musicSource.Play();
            }
        }
        else if (sceneBuildIndex == 4)
        {
            // Memainkan lagu default jika di scene 0 atau 1
            if (musicSource.clip != Factory)
            {
                musicSource.clip = Factory;
                musicSource.Play();
            }
        }
        else if (sceneBuildIndex == 0 || sceneBuildIndex == 1)
        {
            // Memainkan lagu default jika di scene 0 atau 1
            if (musicSource.clip != MainMenu)
            {
                musicSource.clip = MainMenu;
                musicSource.Play();
            }
        }
        else
        {
            // Stop musik untuk scene lainnya
            DontDestroyOnLoad(gameObject);
        }
    }

    void OnVideoStart(VideoPlayer vp)
    {
        // Berhenti musik saat video dimulai
        if (musicSource.isPlaying)
        {
            musicSource.Pause();
        }
    }

    void OnVideoEnd(VideoPlayer vp)
    {
        // Lanjutkan musik saat video selesai diputar
        if (!musicSource.isPlaying)
        {
            musicSource.Play();
        }
    }
}
