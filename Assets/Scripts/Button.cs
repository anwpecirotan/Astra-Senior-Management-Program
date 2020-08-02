using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Button : MonoBehaviour
{
    public void LoadSceneNumber(int sceneNumber)
    {
        SceneManager.LoadScene(sceneNumber);
    }

    public void ExitGame()
    {
        Application.Quit();
    }

    public void DelayedLoadSceneNumber()
    {
        Invoke("LoadFirstScene",2f);
    }

    private void LoadFirstScene()
    {
        SceneManager.LoadScene(0);
    }
}
