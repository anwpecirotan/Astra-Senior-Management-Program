using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class RetryHandler : MonoBehaviour
{
    //public GameObject retryPanel;
    //public GameObject retryButton;
    // Start is called before the first frame update
    void Start()
    {
       // Invoke("LoadSceneScore", 5f);
    }

    //public void RetryActive()
    //{
    //    retryPanel.SetActive(true);
    //    retryButton.SetActive(false);
    //}

    //public void RetryClose()
    //{
    //    retryPanel.SetActive(false);
    //    retryButton.SetActive(true);
    //}

    private void LoadSceneScore()
    {
        SceneManager.LoadScene(5);
    }
}
