using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CassageVITRE : MonoBehaviour
{

    public vitre vitre;
    [Header("Audio")]
    public AudioSource audioSource;
    public AudioClip audioDestroy;
    public void cassage()
    {
        audioSource.PlayOneShot(audioDestroy);
        for (float i = 0f; i <= 30f; i += 0.01f)
        {
            vitre.transform.localPosition = new Vector3(vitre.transform.localPosition.x,
                vitre.transform.localPosition.y + 0.001f,
                vitre.transform.localPosition.z);
            
        }


    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
