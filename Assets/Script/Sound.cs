using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sound : MonoBehaviour
{
    public AudioClip winAudio;
    public AudioSource audioSource;

    
    public void PlayWinClip()
    {
        audioSource.PlayOneShot(winAudio);
    }
}
