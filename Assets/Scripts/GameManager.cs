using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public GameObject firstButton;
    // Start is called before the first frame update
    void Start()
    {
        firstButton.GetComponent<Selectable>().Select();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
