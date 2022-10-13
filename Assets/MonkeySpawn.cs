using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MonkeySpawn : MonoBehaviour
{
    public AudioClip audio;
    public GameObject item;
    public GameObject spawnlocation;
    int count = 0;

    private void OnTriggerEnter(Collider collider)
    {
        if(count < 5){
        AudioSource.PlayClipAtPoint(audio, transform.position);
        Instantiate(item, spawnlocation.transform.position, Quaternion.identity);
        
        Debug.Log(item.transform.localPosition);
        Debug.Log(item.transform.localRotation);
        count++;
        }


    }
}
