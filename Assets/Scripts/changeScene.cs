using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class changeScene : MonoBehaviour
{
    public GameObject InteractKey;

    public Object SceneToLoad;

    public LevelChanger targetScript;

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
                targetScript.FadeToLevel("Interior");
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
