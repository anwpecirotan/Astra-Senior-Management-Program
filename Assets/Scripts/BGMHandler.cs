using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BGMHandler : MonoBehaviour
{
    //public GameObject onBut, offBut;
    //public AudioSource audio;

    public static BGMHandler instance = null;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
    }
    // Start is called before the first frame update
    void Start()
    {
        DontDestroyOnLoad(gameObject);
    }

    private void Update()
    {
        if(SceneManager.GetActiveScene().buildIndex == 5)
        {
            Destroy(gameObject);
        }
    }

    //public void Update()
    //{
    //    if(audio.isPlaying)
    //    {
    //        onBut.SetActive(true);
    //        offBut.SetActive(false);
    //    }
    //}

}
