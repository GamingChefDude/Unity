using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class MainMenu : MonoBehaviour
{
    //trenger scene endring
    public Button playButton;
    public Button quitButton;

    public void Play()
    {
        Debug.Log("Spillet starter");
        SceneManager.LoadScene("Level 1");     
    }

    public void QuitButton()
    {
        Debug.Log("spillet lukkes");
        Application.Quit();
    }
}
