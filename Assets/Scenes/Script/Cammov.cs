using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cammov : MonoBehaviour
{

    public float sensi = 1;
    Vector3 rotation = new Vector3(0, 0, 0);
    public GameObject perso;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        float yM = Input.GetAxis("Mouse Y");
        rotation.x -= yM * sensi;
        rotation.y = perso.transform.eulerAngles.y;
        transform.eulerAngles = rotation;



    }
}
