using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameOverSoundController : MonoBehaviour
{
    private AudioSource audioSource;
    
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        // audioSource.PlayDelayed(0.2f);
        audioSource.Play();
        Debug.Log("Game Over scene has been shown");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
