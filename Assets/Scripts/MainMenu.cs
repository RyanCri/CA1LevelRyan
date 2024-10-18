using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SC_MainMenu : MonoBehaviour
{

    public GameObject MainMenu;
    public GameObject Credits;

    // Start is called before the first frame update
    void Start()
    {
        MainMenuButton();
    }

    public void StartButton()
    {
        print("yo");
        UnityEngine.SceneManagement.SceneManager.LoadScene("Testing");
    }

    public void CreditsButton()
    {
        MainMenu.SetActive(false);
        Credits.SetActive(true);
    }

    public void MainMenuButton()
    {
        MainMenu.SetActive(true);
        Credits.SetActive(false);
    }

    public void QuitButton()
    {
        Application.Quit();
    }
}
