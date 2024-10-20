using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class camHolder : MonoBehaviour
{

    public LevelChanger targetScript;
    void LoadInterior()
    {
        SceneManager.LoadScene("Interior");
    }

    void FadeOut()
    {
        targetScript.FadeOut();
    }
}
