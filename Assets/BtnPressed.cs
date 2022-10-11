using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BtnPressed : MonoBehaviour
{
    public GameObject LeftLight;
    public GameObject RightLight;
    public GameObject MyModelLights;
    public GameObject ModelLights;
    bool isOn = false;
 
 

    private void OnTriggerEnter(Collider collider)
    {
        if(isOn == false){
            LeftLight.GetComponent<Light>().intensity = 3;
            RightLight.GetComponent<Light>().intensity = 3;
            MyModelLights.GetComponent<Light>().intensity = 6;
            ModelLights.GetComponent<Light>().intensity = 6;
            isOn = true;
            }
        else {
            LeftLight.GetComponent<Light>().intensity = 0;
            RightLight.GetComponent<Light>().intensity = 0;
            MyModelLights.GetComponent<Light>().intensity = 0;
            ModelLights.GetComponent<Light>().intensity = 0;
            isOn = false;
        }

    }
}
