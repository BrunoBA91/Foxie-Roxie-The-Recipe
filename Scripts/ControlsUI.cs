using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlsUI : MonoBehaviour
{
    private bool controlsExplained = false;

    [SerializeField] private GameObject controlsUI;

    // Start is called before the first frame update
    void Start()
    {
        if (!controlsExplained)
        {
            controlsExplained = true;
            Invoke("DisableControlsUICanvas", 5f);
        }
    }

    public void DisableControlsUICanvas()
    {
        controlsUI.GetComponent<Canvas>().enabled = false;
    }
}
