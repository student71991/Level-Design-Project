using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{

    public void PlayGame()
    {
        SceneManager.LoadScene("MainProject");
    }

    public void Quit()
    {
        Application.Quit();
        Debug.Log("The Player Has Now Quit The Game");
    }

}
