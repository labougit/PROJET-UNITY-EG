using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tiroir : MonoBehaviour
{
    public bool tiroirouvert = false;
   

    public float smooth = 3.0f;
    public Animator anim;
    public AudioClip opentiroir;
    public AudioClip closetiroir;


    // Start is called before the first frame update
    void Start()
    {
       
    }

    public void ChangeDoorState()
    {
        tiroirouvert = !tiroirouvert ;

    }


    public void OpenClose()
    {
       

        anim.SetTrigger("tiroir");
    }





    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "triggertiroir")
        {
            AudioSource.PlayClipAtPoint(closetiroir, transform.position, 1);
        }
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.tag == "triggertiroir")
        {
            AudioSource.PlayClipAtPoint(opentiroir, transform.position, 1);
        }
    }


}