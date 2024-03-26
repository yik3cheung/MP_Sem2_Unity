using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerCube : MonoBehaviour
{
    public AudioClip phoneRing;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter (Collider other)
    {
        Debug.Log("Cube Hit");
        if(other.tag == "Player")
        {
            gameObject.GetComponent<AudioSource>().PlayOneShot(phoneRing);
        }
    }
}
