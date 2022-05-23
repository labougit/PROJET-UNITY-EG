using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoutonController : MonoBehaviour
{
    public VolletDistance vollet1;
    public VolletDistance vollet2;
    public VolletDistance vollet3;

    public AudioSource audioSource;
    public AudioClip openDoor;


    public void Open()
    {
      
        if (audioSource != null)
        {
            audioSource.PlayOneShot(openDoor);
        }
        
            
            for (float i = 0f; i <= 1f; i += 0.1f)
            {
                vollet1.transform.localPosition = new Vector3(vollet1.transform.localPosition.x-0.001f,
                    vollet1.transform.localPosition.y,
                    vollet1.transform.localPosition.z);

            vollet2.transform.localPosition = new Vector3(vollet2.transform.localPosition.x-0.001f,
                    vollet2.transform.localPosition.y ,
                    vollet2.transform.localPosition.z);

            vollet3.transform.localPosition = new Vector3(vollet3.transform.localPosition.x-0.001f,
                    vollet3.transform.localPosition.y,
                    vollet3.transform.localPosition.z);

        }
            
       
    }

    
}
