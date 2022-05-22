using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorController : MonoBehaviour
{
    public bool lockedByPassword;

    public Animator anim;
    public AudioSource audioSource;
    public AudioClip openDoor;
  

    public void OpenClose()
    {
        if (lockedByPassword)
        {
            Debug.Log("Locked by password");
            return;
        }

        if (audioSource != null)
        {
            audioSource.PlayOneShot(openDoor);
        }

        anim.SetTrigger("Door");
    }

  

}
