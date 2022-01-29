using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartScreen : MonoBehaviour
{
    [SerializeField] private AudioSource startScreenMusic;

    private void Start()
    {
        if (SceneManager.GetActiveScene().name == "StartScreen")
        {
            AudioListener.pause = false;
            startScreenMusic.Play();
        }
    }

    public void LoadLevel()
    {
        startScreenMusic.Stop();
        SceneManager.LoadScene("Level");
    }

    public void ExitGame()
    {
        Application.Quit();
    }
}
