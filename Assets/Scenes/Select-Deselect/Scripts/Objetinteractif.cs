using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Objetinteractif : MonoBehaviour
{
    [Header("Audio")]
    public AudioSource audioSource;
    public AudioClip audioDestroy;

    public void activerobjet()
    {
        if (audioSource != null)
        {
            audioSource.PlayOneShot(audioDestroy);

        }
        Destroy(gameObject);
    }
}
