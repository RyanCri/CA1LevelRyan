using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Interact : MonoBehaviour
{
    public GameObject InteractKey;

    public AudioSource InteracterSound;

    public GameObject Exit;

    // public AudioClip pick_up;

    public GameObject Item;


    // void Start()
    // {
    //     InteracterSound.GetComponent<AudioSource>();
    //     InteracterSound.clip = pick_up;
    // }

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
                Item.SetActive(false);
                InteracterSound.Play();
                Exit.SetActive(true);
                print("check");
                // gameObject.SetActive(false);
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
