using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SfxCtrl : MonoBehaviour
{
    static AudioSource audioSource;
    public static AudioClip audioClip;
    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioClip = Resources.Load<AudioClip>("beep-sound");
    }

    public static void SoundPlay(){
        audioSource.PlayOneShot(audioClip);
    }
}
