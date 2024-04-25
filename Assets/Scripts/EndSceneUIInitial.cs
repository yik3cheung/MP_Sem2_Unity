using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EndSceneUIInitial : MonoBehaviour
{
    public GameObject ui;
    public GameObject uitext1;
    public GameObject uitext2;
    public GameObject uitext3;

    // Start is called before the first frame update
    void Start()
    {
        ui.SetActive(false);
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
        ui.SetActive(true);
        uitext1.SetActive(true);
        uitext2.SetActive(false);
        uitext3.SetActive(false);
    }
}

