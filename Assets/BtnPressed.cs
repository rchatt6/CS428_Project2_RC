using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BtnPressed : MonoBehaviour
{
    public GameObject LeftLight;
    public GameObject RightLight;
    public GameObject MyModelLights;
    public GameObject ModelLights;
 
 

    private void OnTriggerEnter(Collider collider)
    {
        LeftLight.GetComponent<Light>().intensity = 3;
        RightLight.GetComponent<Light>().intensity = 3;
        MyModelLights.GetComponent<Light>().intensity = 3;
        ModelLights.GetComponent<Light>().intensity = 4;

    }
}
