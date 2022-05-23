using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bouton_porte_s2 : MonoBehaviour
{
  
    public porte_salle_2_ouverture v1;
    public porte_salle_2_ouverture v2;
    public porte_salle_2_ouverture v3;
    public porte_salle_2_ouverture v4;
    public porte_salle_2_ouverture v5;
    public porte_salle_2_ouverture v6;
    public porte_salle_2_ouverture v7;
    public porte_salle_2_ouverture v8;
    public porte_salle_2_ouverture v9;
    public porte_salle_2_ouverture v10;
    public porte_salle_2_ouverture v11;
    public porte_salle_2_ouverture v12;
    public porte_salle_2_ouverture v13;
    public porte_salle_2_ouverture v14;
    public porte_salle_2_ouverture v15;
    public porte_salle_2_ouverture v16;
    public porte_salle_2_ouverture v17;
    public porte_salle_2_ouverture v18;
    public porte_salle_2_ouverture v19;
    public porte_salle_2_ouverture v20;
    public porte_salle_2_ouverture v21;
    public porte_salle_2_ouverture v22;
    public porte_salle_2_ouverture v23;
    public porte_salle_2_ouverture v24;
    

    public AudioSource audioSource;
    public AudioClip openDoorS2;


    public void Open_S2()
    {

        if (audioSource != null)
        {
            audioSource.PlayOneShot(openDoorS2);
        }


        for (float i = 0f; i <= 1f; i += 0.001f)
        {
            v1.transform.localPosition = new Vector3(v1.transform.localPosition.x,
                v1.transform.localPosition.y +0.001f,
                v1.transform.localPosition.z);

            v2.transform.localPosition = new Vector3(v2.transform.localPosition.x,
                    v2.transform.localPosition.y +0.001f,
                    v2.transform.localPosition.z);

            v3.transform.localPosition = new Vector3(v3.transform.localPosition.x,
                    v3.transform.localPosition.y +0.001f,
                    v3.transform.localPosition.z);

            v4.transform.localPosition = new Vector3(v4.transform.localPosition.x,
                   v4.transform.localPosition.y +0.001f,
                   v4.transform.localPosition.z);
            v5.transform.localPosition = new Vector3(v5.transform.localPosition.x,
                   v5.transform.localPosition.y +0.001f,
                   v5.transform.localPosition.z);
            v6.transform.localPosition = new Vector3(v6.transform.localPosition.x,
                   v6.transform.localPosition.y +0.001f,
                   v6.transform.localPosition.z);
            v7.transform.localPosition = new Vector3(v7.transform.localPosition.x,
                   v7.transform.localPosition.y +0.001f,
                   v7.transform.localPosition.z);
            v8.transform.localPosition = new Vector3(v8.transform.localPosition.x,
                   v8.transform.localPosition.y +0.001f,
                   v8.transform.localPosition.z);
            v9.transform.localPosition = new Vector3(v9.transform.localPosition.x,
                   v9.transform.localPosition.y +0.001f,
                   v9.transform.localPosition.z);
            v10.transform.localPosition = new Vector3(v10.transform.localPosition.x,
                   v10.transform.localPosition.y +0.001f,
                   v10.transform.localPosition.z);
            v11.transform.localPosition = new Vector3(v11.transform.localPosition.x,
                   v11.transform.localPosition.y +0.001f,
                   v11.transform.localPosition.z);
            v12.transform.localPosition = new Vector3(v12.transform.localPosition.x,
                   v12.transform.localPosition.y +0.001f,
                   v12.transform.localPosition.z);
            v13.transform.localPosition = new Vector3(v13.transform.localPosition.x,
                   v13.transform.localPosition.y +0.001f,
                   v13.transform.localPosition.z);
            v14.transform.localPosition = new Vector3(v14.transform.localPosition.x,
                   v14.transform.localPosition.y +0.001f,
                   v14.transform.localPosition.z);
            v15.transform.localPosition = new Vector3(v15.transform.localPosition.x,
                   v15.transform.localPosition.y +0.001f,
                   v15.transform.localPosition.z);
            v16.transform.localPosition = new Vector3(v16.transform.localPosition.x,
                   v16.transform.localPosition.y +0.001f,
                   v16.transform.localPosition.z);
            v17.transform.localPosition = new Vector3(v17.transform.localPosition.x,
                   v17.transform.localPosition.y +0.001f,
                   v17.transform.localPosition.z);
            v18.transform.localPosition = new Vector3(v18.transform.localPosition.x,
                   v18.transform.localPosition.y +0.001f,
                   v18.transform.localPosition.z);
            v19.transform.localPosition = new Vector3(v19.transform.localPosition.x,
                   v19.transform.localPosition.y +0.001f,
                   v19.transform.localPosition.z);
            v20.transform.localPosition = new Vector3(v20.transform.localPosition.x,
                   v20.transform.localPosition.y +0.001f,
                   v20.transform.localPosition.z);
            v21.transform.localPosition = new Vector3(v21.transform.localPosition.x,
                   v21.transform.localPosition.y +0.001f,
                   v21.transform.localPosition.z);
            v22.transform.localPosition = new Vector3(v22.transform.localPosition.x,
                   v22.transform.localPosition.y +0.001f,
                   v22.transform.localPosition.z);
            v23.transform.localPosition = new Vector3(v23.transform.localPosition.x,
                   v23.transform.localPosition.y +0.001f,
                   v23.transform.localPosition.z);
            v24.transform.localPosition = new Vector3(v24.transform.localPosition.x,
                 v24.transform.localPosition.y +0.001f,
                 v24.transform.localPosition.z);

            

        }


    }
}
