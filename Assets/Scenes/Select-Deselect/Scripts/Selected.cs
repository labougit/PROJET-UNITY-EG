using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Selected : MonoBehaviour
{


    LayerMask mask;
    public float distance = 50f;

    //Partie affichage text

    public Texture2D point;
    public GameObject TextDetect;
    GameObject Recofinal = null;


    // Start is called before the first frame update
    void Start()
    {
        mask = LayerMask.GetMask("Raycast Detect");
        TextDetect.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

        //Raycast ( origine, direction, out hit, distance, masque)
        RaycastHit hit;

        if(Physics.Raycast(transform.position,transform.TransformDirection(Vector3.forward),out hit, distance,mask))
        {
            Deselect();
            SelectedObject(hit.transform);


            if(hit.collider.tag == "Objet interactif")
            {

                if(Input.GetKeyDown(KeyCode.E))
                {
                    hit.collider.transform.GetComponent<Objetinteractif>().activerobjet();


                }


            }
            Debug.DrawRay(transform.position, transform.TransformDirection(Vector3.forward) * distance, Color.red);

            if (hit.collider.tag == "door")
            {

                if (Input.GetKeyDown(KeyCode.E))
                {
                    hit.collider.transform.GetComponent<SystemDoor>().ChangeDoorState();


                }


            }

            if (hit.collider.tag == "doorluke")
            {

                if (Input.GetKeyDown(KeyCode.E))
                {
                    hit.collider.transform.GetComponent<DoorController>().OpenClose();


                }


            }
        }
        else
        {
            Deselect();
        }
    }

    void SelectedObject(Transform transform)
    {

        transform.GetComponent<MeshRenderer>().material.color = Color.green;
        Recofinal = transform.gameObject;
    }

    void Deselect()
    {
        if(Recofinal)
        {
            Recofinal.GetComponent<Renderer>().material.color = Color.white;
            Recofinal = null;
        }
    }

    //Affichage panel
    void ONGUI()
    {
        Rect rect = new Rect(Screen.width / 2, Screen.height / 2, 50f, 50f);
        GUI.DrawTexture(rect, point);

        if (Recofinal)
        {
            TextDetect.SetActive(true);
        }
        else
        {
            TextDetect.SetActive(false);
        }
    }


}
