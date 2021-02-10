using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Menu : MonoBehaviour
{
    //This function loads the "game" scene.
    public void Play()
    {
        SceneManager.LoadSceneAsync("Game");
    }

    //This function closes the application.
    public void Quit()
    {
        Application.Quit();
    }
}
