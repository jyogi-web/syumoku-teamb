using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playSE : MonoBehaviour
{
    public AudioClip sound1;
    AudioSource audioSource;

    void sound_button_money () {
        audioSource = GetComponent<AudioSource>();
        audioSource.PlayOneShot(sound1);
    }
        
    
}

