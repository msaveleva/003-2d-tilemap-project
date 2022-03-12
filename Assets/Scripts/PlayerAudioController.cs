using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAudioController : MonoBehaviour
{
    private AudioSource audioSource;
    private bool isWalking = false;

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");
        isWalking = x != 0 || y != 0;

        if (isWalking)
        {
            audioSource.Play();
        }
        else
        {
            audioSource.Stop();
        }
    }
}
