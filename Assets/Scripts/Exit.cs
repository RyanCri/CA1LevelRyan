using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Exit : MonoBehaviour
{
    public GameObject InteractKey;


    void OnTriggerEnter (Collider other)
    {
        if (other.CompareTag("Player"))
        {
            InteractKey.SetActive(true);
        }
    }
    
    void OnTriggerStay (Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (Input.GetKeyDown(KeyCode.F))
            {
                SceneManager.LoadScene("End");
                
                Cursor.lockState = CursorLockMode.None;
                Cursor.visible = true;
            }
        }
    }

    void OnTriggerExit (Collider other)
    {
        if (other.CompareTag("Player"))
        {
            InteractKey.SetActive(false);
        }
    }
}
