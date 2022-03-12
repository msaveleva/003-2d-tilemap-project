using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstRoomSoundController : MonoBehaviour
{
    private AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.loop = true;
        audioSource.volume = 0.07f;
        audioSource.Play();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnDisable()
    {
        audioSource.Stop();
    }
}
