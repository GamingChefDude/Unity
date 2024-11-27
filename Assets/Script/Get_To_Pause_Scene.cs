using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class get_to_pause_scene : MonoBehaviour
{
    //trenger scene endring
    public Button pauseButton;
    

    public void Pause()
    {
        Debug.Log("Pause Menu");
        SceneManager.LoadScene("PauseScene");     
    }
}
