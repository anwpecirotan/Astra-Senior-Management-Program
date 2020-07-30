using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TutorialHandler : MonoBehaviour
{
    public GameObject canvas;
    public GameObject hint;
    public void OnMouseDown()
    {
        hint.SetActive(true);
        Destroy(canvas);
    }
}
