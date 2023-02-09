using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchLevel : MonoBehaviour
{
    public void LoadGame()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

    public void QuitGame()
    {
        Application.Quit();
    }
}
