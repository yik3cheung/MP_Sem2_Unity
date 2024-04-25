using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ClassroomNPCAnimator : MonoBehaviour
{

    public GameObject ui;
    public Animator animator;

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
        Debug.Log("NPC Hit");
        if(other.tag == "Player")
        {
            animator.SetTrigger("talk");
            Invoke("ShowUI",2);
        }
    }

    public void ShowUI()
    {
        ui.SetActive(true);
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
    }

    public void HideUI()
    {
        ui.SetActive(false);
        Cursor.lockState = CursorLockMode.Locked;
        Cursor.visible = false;
    }

    public void PressYes()
    {
        HideUI();
        SceneManager.LoadScene("Trans1", LoadSceneMode.Single);
    }
}
