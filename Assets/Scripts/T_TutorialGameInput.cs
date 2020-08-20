using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class T_TutorialGameInput : MonoBehaviour
{
    public int idxShow;
    public TextMeshProUGUI percentageSliderValue;
    public Slider sliderValue;
    public GameObject[] tutorialImage;
    

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void CloseTutorial()
    {
        gameObject.SetActive(false);
    }

    public void NextTutorial()
    {
        if (idxShow < 2)
        {
            tutorialImage[idxShow].SetActive(false);
            tutorialImage[idxShow + 1].SetActive(true);
            idxShow++;
        }
        else
        {
            CloseTutorial();
        }
    }

    public void PrevTutorial()
    {
        if(idxShow > 0)
        {
            tutorialImage[idxShow].SetActive(false);
            tutorialImage[idxShow - 1].SetActive(true);
            idxShow--;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (idxShow == 0)

            percentageSliderValue.text = (sliderValue.value / 2) + "%";

    }

    

}
