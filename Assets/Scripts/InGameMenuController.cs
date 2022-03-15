using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InGameMenuController : MonoBehaviour
{
    private bool isInGameMenuShown = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            isInGameMenuShown = !isInGameMenuShown;
            ShowInGameMenu(isInGameMenuShown);
        }
    }

    private void ShowInGameMenu(bool show)
    {
        if (show)
        {
            Debug.Log("Shown");
        }
        else
        {
            Debug.Log("Hidden");
        }
    }
}
