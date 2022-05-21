using UnityEngine;
using UnityEngine.UI;

public class PlayerAim : MonoBehaviour



{
    public Transform headPos;

    [Header("Audio")]
    public AudioSource audioSource;
    public AudioClip sonporte;
    

    private void Update()
    {
        RaycastHit hit;
        if (Physics.Raycast(headPos.position, headPos.TransformDirection(Vector3.forward), out hit, Mathf.Infinity))
        {
            Debug.DrawRay(headPos.position, headPos.TransformDirection(Vector3.forward) * hit.distance, Color.yellow);

            float distance = Vector3.Distance(transform.position, hit.transform.position);
            if (distance <= 1f)
            {
                if (Input.GetKeyDown(KeyCode.E))
                {
                    if (hit.transform.GetComponent<KeypadKey>() != null)
                    {
                        hit.transform.GetComponent<KeypadKey>().SendKey();
                    }
                    else if(hit.transform.name=="DoorMesh")
                    {
                        if (audioSource != null)
                        {
                            audioSource.PlayOneShot(sonporte);
                        }
                        hit.transform.GetComponent<DoorController>().OpenClose();
                    }
                }
            }
        }
    }
}

