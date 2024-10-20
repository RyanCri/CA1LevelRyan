using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelChanger : MonoBehaviour
{

    public Animator aniamtor;

    private string levelToLoad;

    // Update is called once per frame
    void Update()
    {
        
    }

    public void FadeToLevel(string levelName)
    {
        levelToLoad = levelName;
        aniamtor.SetTrigger("FadeOut");

    }

    public void OnFadeComplete()
    {
        SceneManager.LoadScene(levelToLoad);
    }
}
