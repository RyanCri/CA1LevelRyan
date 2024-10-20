using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class doorCutscene : MonoBehaviour
{
    public Animator myDoor;

    public Animator camHolder;
    void Start()
    {
        myDoor.Play("handle", 0, 0.0f);
    }



}
