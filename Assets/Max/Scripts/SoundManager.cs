using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    [SerializeField] private AudioSource audioSource;
    [SerializeField] private AudioClip narrationClip;

    public void StartNarration()
    {
        audioSource.PlayOneShot(narrationClip);
    }
}
