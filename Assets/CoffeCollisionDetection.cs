using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoffeCollisionDetection : MonoBehaviour
{
    //public GameObject item;
    public AudioClip audio;
    // Start is called before the first frame update
    /*void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        OnTriggerEnter(GetComponent<Collider>());
    }
*/
    private void OnTriggerEnter(Collider collider)
    {
        //GameObject e = Instantiate(item) as GameObject;
        AudioSource.PlayClipAtPoint(audio, transform.position);
    }
}
