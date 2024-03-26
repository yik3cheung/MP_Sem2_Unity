using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhoneBehaviour : MonoBehaviour
{
    public AudioClip phoneRing;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log ("Running");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void onTriggerEnter(Collider other)
    {
        if(other.tag == "Player")
        {
          gameObject.GetComponent<AudioSource>().PlayOneShot(phoneRing);
        }
    }
}
