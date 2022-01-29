using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    [Header("Reference Size")]
    public float width;        // Width of the game in units
    public float height;    // Width of the game in units

    public float pixelsPerUnit;        // PPU

    [Header(" ")]
    public bool detectFullscreenMode = false;    // Should the script re-trigger when the game is sent into fullscreen mode? (ie: in WebGL browser)

    private bool lastFullscreenState = false;


    void Awake()
    {
        SetSizer();
    }

    void SetSizer()
    {
        float aspectRatio = (float)Screen.width / (float)Screen.height;
        float newCameraHeight = (width / pixelsPerUnit) / aspectRatio;
        float targetAspectRatio = width / height;

        if (aspectRatio < targetAspectRatio)
            GetComponent<Camera>().orthographicSize = newCameraHeight / 2f;

        lastFullscreenState = Screen.fullScreen;
    }

    public Transform player;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (detectFullscreenMode)
        {
            if (Screen.fullScreen != lastFullscreenState)
                SetSizer();
        }

        transform.position = new Vector3(player.position.x, player.position.y, transform.position.z);    
    }
}
