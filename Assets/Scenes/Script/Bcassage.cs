using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bcassage : MonoBehaviour
{
    public CassageVITRE vitre;
    [Header("Audio")]
    public AudioSource audioSource;
    public AudioClip audioDestroy;
    public void cassage()
    {
        Destroy(vitre);


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
