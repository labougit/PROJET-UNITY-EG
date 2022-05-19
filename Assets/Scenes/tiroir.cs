using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class tiroir : MonoBehaviour
{
    public bool tiroirouvert = false;
    public float doorOpenAngle = 95f;
    public float doorCloseAngle = 0.0f;


    public float smooth = 3.0f;

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





    // Update is called once per frame
    void Update()
    {
        if(tiroirouvert )
        {
            Quaternion targetRotation = Quaternion.Euler(0, doorOpenAngle, 0);
            transform.localRotation = Quaternion.Slerp(transform.localRotation, targetRotation, smooth * Time.deltaTime);
        }
        else
        {
            Quaternion targetRotation2 = Quaternion.Euler(0, doorCloseAngle, 0);
            transform.localRotation = Quaternion.Slerp(transform.localRotation, targetRotation2, smooth * Time.deltaTime);
        }
       
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