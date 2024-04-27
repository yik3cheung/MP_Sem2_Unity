using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndingText : MonoBehaviour
{
    public GameObject ui;
    public GameObject ui2;

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
            ShowUI();
        }
    }

    public void ShowUI()
    {
        ui.SetActive(false);
        ui2.SetActive(true);
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }
}

