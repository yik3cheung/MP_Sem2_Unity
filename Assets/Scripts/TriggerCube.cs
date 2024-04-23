using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TriggerCube : MonoBehaviour
{
    public AudioClip phoneRing;
    public GameObject ui;
    // Start is called before the first frame update
    void Start()
    {
        HideUI();
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
            Invoke("ShowUI",2);
        }
    }

    public void HideUI()
    {
        ui.SetActive(false);
        Cursor.lockState = CursorLockMode.None;
    }

    public void ShowUI()
    {
        ui.SetActive(true);
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    public void PressYes()
    {
        //HideUI();
        SceneManager.LoadScene("Classroom", LoadSceneMode.Single);
    }
}
