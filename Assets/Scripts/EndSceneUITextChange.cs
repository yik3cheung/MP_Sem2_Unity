using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndSceneUI : MonoBehaviour
{
    public GameObject ui;
    public GameObject uitext1;
    public GameObject uitext2;

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
        Debug.Log("Trigger Hit");
        if(other.tag == "Player")
        {
            Invoke("ChangeText",2);
        }
    }

    private void ChangeText()
    {
        
    }
}
