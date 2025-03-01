﻿using UnityEngine;
using UnityEngine.UI;

public class PlayerAim : MonoBehaviour



{
    public Transform headPos;

    [Header("Audio")]
    public AudioSource audioSource;
    public AudioClip sonporte;
    public AudioClip Do;




    private void Update()
    {
        RaycastHit hit;
        if (Physics.Raycast(headPos.position, headPos.TransformDirection(Vector3.forward), out hit, Mathf.Infinity))
        {
            Debug.DrawRay(headPos.position, headPos.TransformDirection(Vector3.forward) * hit.distance, Color.yellow);

            float distance = Vector3.Distance(transform.position, hit.transform.position);
            if (distance <= 5f)
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    if (hit.transform.GetComponent<KeypadKey>() != null)
                    {
                        hit.transform.GetComponent<KeypadKey>().SendKey();
                    }

                    if (hit.transform.GetComponent<KeypadKey>() != null)
                    {
                        if (hit.transform.name == "p")
                        {

                            audioSource.PlayOneShot(Do);
                        }
                        
                    }

                    else if(hit.transform.name=="porte")
                    {
                        if (audioSource != null)
                        {
                            audioSource.PlayOneShot(sonporte);
                        }
                        hit.transform.GetComponent<DoorController>().OpenClose();
                    }
                    else if (hit.transform.name == "bouton")
                    {
                        if (audioSource != null)
                        {
                            audioSource.PlayOneShot(sonporte);
                        }
                        hit.transform.GetComponent<BoutonController>().Open();
                    }

                    else if (hit.transform.name == "bouton_S2")
                    {
                        
                        hit.transform.GetComponent<bouton_porte_s2>().Open_S2();
                    }
                    else if (hit.transform.name == "B")
                    {

                        hit.transform.GetComponent<CassageVITRE>().cassage();
                    }
                }
            }
        }
    }
}

