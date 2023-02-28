using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BGController : MonoBehaviour
{
    private AudioSource audioSource;

    void Start()
    {
        // Lấy AudioSource của GameObject
        audioSource = GetComponent<AudioSource>();

        // Phát nhạc
        audioSource.Play();
    }

    public void StopMusic()
    {
        // Dừng nhạc
        audioSource.Stop();
    }
    public void PlayMusic()
    {
        // Phát nhạc
        audioSource.Play();
    }

}



