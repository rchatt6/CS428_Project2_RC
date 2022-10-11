using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BtnPressed : MonoBehaviour
{
    public GameObject LeftLight;
    public GameObject RightLight;
 
 

    private void OnTriggerEnter(Collider collider)
    {
        LeftLight.GetComponent<Light>().intensity = 3;
        RightLight.GetComponent<Light>().intensity = 3;

    }
}
