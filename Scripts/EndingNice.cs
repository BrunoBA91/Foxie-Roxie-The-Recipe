using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndingNice : MonoBehaviour
{
    [SerializeField] private AudioSource endingScreenMusic;

    // Start is called before the first frame update
    void Start()
    {
        AudioListener.pause = false;
        endingScreenMusic.Play();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.Quit();
        }
    }
}
