using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelChanger : MonoBehaviour
{

    public Animator aniamtor;

    private string levelToLoad;

    public void FadeToLevel(string levelName)
    {
        levelToLoad = levelName;
        aniamtor.SetTrigger("FadeOut");

    }

    public void FadeOut()
    {
        aniamtor.SetTrigger("FadeOut");
    }

    public void OnFadeComplete()
    {
        SceneManager.LoadScene("DoorDimension");
        print(levelToLoad);
    }
}
