using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenuScript : MonoBehaviour
{
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.KeypadEnter)|| Input.GetKeyDown(KeyCode.Return)) //Numpad or main enter key
        {
            SceneManager.LoadScene("MainMenuSelection"); //SceneManager.LoadScene(1)
        }
    }
}
