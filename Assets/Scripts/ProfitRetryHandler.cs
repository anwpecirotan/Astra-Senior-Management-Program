using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProfitRetryHandler : MonoBehaviour
{
    public GameObject retryPanel;
    public GameObject retryButton;
    // Start is called before the first frame update
    void Start()
    {
        //Invoke("RetryActive", 2f);
    }

    public void RetryActive()
    {
        retryPanel.SetActive(true);
        retryButton.SetActive(false);
    }

    public void RetryClose()
    {
        retryPanel.SetActive(false);
        retryButton.SetActive(true);
    }

    //private void LoadSceneScore()
    //{
    //    SceneManager.LoadScene(5);
    //}
}
