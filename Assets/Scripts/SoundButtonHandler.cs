using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SoundButtonHandler : MonoBehaviour
{
    private RectTransform rect;

    private void Start()
    {
        rect = GetComponent<RectTransform>();
    }
    // Update is called once per frame
    void Update()
    {
        if(SceneManager.GetActiveScene().buildIndex == 2)
        {
            rect.localPosition = new Vector2(-500, rect.localPosition.y);
        }
        else
        {
            rect.localPosition = new Vector2(-630, rect.localPosition.y);
        }
    }
}
