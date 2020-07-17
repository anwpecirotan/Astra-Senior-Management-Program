using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RetryHandler : MonoBehaviour
{
    public GameObject retryPanel;
    // Start is called before the first frame update
    void Start()
    {
        Invoke("RetryActive", 2f);
    }

    private void RetryActive()
    {
        retryPanel.SetActive(true);
    }
}
