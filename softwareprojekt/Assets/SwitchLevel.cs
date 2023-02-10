using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchLevel : MonoBehaviour
{
    public void LoadScene(int a)
    {
        SceneManager.LoadScene(a);
    }
    
    public void BackToMenu()
    {
        SceneManager.LoadScene(0);
    }


    public void QuitGame()
    {
        Application.Quit();
    }
}
