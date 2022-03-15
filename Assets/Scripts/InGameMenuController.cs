using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InGameMenuController : MonoBehaviour
{
    private PlayerController playerControllerScript;
    private PlayerAudioController playerAudioControllerScript;
    private PlayerAnimController playerAnimControllerScript;
    
    private bool isInGameMenuShown = false;
    // Start is called before the first frame update
    void Start()
    {
        playerControllerScript = GetComponent<PlayerController>();
        playerAudioControllerScript = GetComponent<PlayerAudioController>();
        playerAnimControllerScript = GetComponent<PlayerAnimController>();
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
        
        pauseGame(show);
    }

    private void pauseGame(bool pause)
    {
        Time.timeScale = pause ? 0 : 1;
        
        playerControllerScript.enabled = !pause;
        playerAudioControllerScript.enabled = !pause;
        playerAnimControllerScript.enabled = !pause;
    }
}
