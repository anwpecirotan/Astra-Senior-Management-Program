using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class BGMHandler : MonoBehaviour
{
    public GameObject onBut, offBut;
    public GameObject moveCoor;
    public GameObject moveCoor2;
    bool move;
    
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
        //imDouble = false;
    }

    private void Update()
    {
        if(SceneManager.GetActiveScene().buildIndex == 5 || SceneManager.GetActiveScene().name == "ProfitLogin")
        {
            Destroy(gameObject);
        }
        if (SceneManager.GetActiveScene().name == "ProfitGame" && !move)
        {
            onBut.transform.position = new Vector2(moveCoor.transform.position.x,moveCoor.transform.position.y);
            offBut.transform.position = new Vector2(moveCoor.transform.position.x, moveCoor.transform.position.y);
            move = true;
        }
        if(SceneManager.GetActiveScene().name == "ProfitScore" && move)
        {
            onBut.transform.position = new Vector2(moveCoor2.transform.position.x, moveCoor2.transform.position.y);
            offBut.transform.position = new Vector2(moveCoor2.transform.position.x, moveCoor2.transform.position.y);
            move = false;
           
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
