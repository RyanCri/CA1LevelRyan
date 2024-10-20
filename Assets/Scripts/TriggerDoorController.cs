using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerDoorController : MonoBehaviour
{
    [SerializeField] private Animator myDoor = null;
    [SerializeField] private Animator myHandle = null;

    [SerializeField] private bool openTrigger = false;
    [SerializeField] private bool closeTrigger = false;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            if (openTrigger)
            {
                myDoor.Play("handle", 0, 0.0f);
                // myDoor.Play("door", 0, 0.0f);
                print("handle");
                // myHandle.play("handle", 0, 0.0f);
                // gameObject.SetActive(false);
            }
        }
    }
}
