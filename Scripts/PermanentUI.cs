using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PermanentUI : MonoBehaviour
{
    // Player stats
    public int cherries;
    public int health;
    public TextMeshProUGUI healthAmount;
    public TextMeshProUGUI cherryText;

    public static PermanentUI perm;

    private void Start()
    {
        DontDestroyOnLoad(gameObject);

        // Singleton
        if (!perm)
        {
            perm = this;
        }
        else
        {
            Destroy(gameObject);
        }

    }

    public void Reset()
    {
        cherries = 0;
        health = 3;
        healthAmount.text = health.ToString();
        cherryText.text = cherries.ToString();
    }

}
