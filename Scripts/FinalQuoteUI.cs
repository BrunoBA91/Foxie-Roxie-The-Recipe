using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FinalQuoteUI : MonoBehaviour
{
    [SerializeField] private GameObject finalQuoteText;
    [SerializeField] private GameObject anonymousText;
    [SerializeField] private GameObject suicideText;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        finalQuoteText.SetActive(true);
        anonymousText.SetActive(true);
        suicideText.SetActive(true);
        Invoke("DisableUIText", 10f);
    }

    private void DisableUIText()
    {
        finalQuoteText.SetActive(false);
        anonymousText.SetActive(false);
        suicideText.SetActive(false);
        Destroy(gameObject);
    }
}
