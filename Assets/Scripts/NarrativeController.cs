using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class NarrativeController : MonoBehaviour
{


    public Image imageContainer;
    public GameObject btnPrev, btnNext;
    public Sprite[] allImage;

    public int idx;
    void Start()
    {
        idx = 0;
        ShowImage(0);
        CheckIdx();

    }

    public void _ButtonNext()
    {
        idx++;
        ShowImage(idx);
        CheckIdx();
    }

    public void _ButtonPrev()
    {
        idx--;
        ShowImage(idx);
        CheckIdx();

    }

    private void CheckIdx()
    {
        if (idx <= 0)
        {
            btnPrev.SetActive(false);
        }
        else if (idx >= allImage.Length - 1)
        {
            btnNext.SetActive(false);
            //Ganti kalau udah next langsung mari mulai
        }
        else
        {
            btnPrev.SetActive(true);
            btnNext.SetActive(true);
        }
    }
    private void ShowImage(int number)
    {
        imageContainer.sprite = allImage[number];
    }

    
    void Update()
    {
        
    }
}
