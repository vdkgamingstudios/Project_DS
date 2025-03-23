using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    //Original Code to go to the next scene in the game based on the scene order
    //public void StartGame()
    //{
    //    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    //}

    //Selecting the Race Scene
    public void RaceSceneSelect()
    {
        SceneManager.LoadScene("RaceTest");
    }

    //Selecting the Arena Scene
    public void ArenaSceneSelect()
    {
        SceneManager.LoadScene("ArenaTest");
    }

    //Quitting the game
    public void QuitGame()
    {
        Debug.Log("Quitting Game...");
        Application.Quit();
    }
}
