using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class piano_touche : MonoBehaviour
{
    public string key;

    public void SendKey()
    {
        this.transform.GetComponentInParent<KeypadController>().PasswordEntry(key);
    }
}
