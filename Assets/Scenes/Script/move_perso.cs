using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class move_perso : MonoBehaviour
{

    public float vitesse = 2.0f;
    Vector3 deplacement = new Vector3(0f, 0f, 0f);
    public float sensi = 1;

    Vector3 rotation = new Vector3(0, 0, 0);

    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    // Update is called once per frame
    void Update()
    {
        float inputX = Input.GetAxis("Horizontal");
        float inputY = Input.GetAxis("Vertical");

        GetComponent<Rigidbody>().velocity = (inputY * vitesse * transform.forward) + (inputX * vitesse * transform.right);

        if (Input.GetKey(KeyCode.Space))
        {

            Cursor.lockState = CursorLockMode.None;

        }

        float xM = Input.GetAxis("Mouse X");
        rotation.y += xM * sensi;
        transform.eulerAngles = rotation;

    }





}
