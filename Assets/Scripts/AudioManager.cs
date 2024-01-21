using System.Collections;
using System.Collections.Generic;
using UnityEngine;
[RequireComponent(typeof(AudioSource))]

public class AudioManager : MonoBehaviour
{
    private AudioSource m_AudioSource;
    // Start is called before the first frame update
    void Start()
    {
        m_AudioSource = GetComponent<AudioSource>();    
    }

    public void PlaySS(AudioClip audio)
    {
        m_AudioSource.PlayOneShot(audio);
    }
}
