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
    public GameObject valueDriverGO;
    public GameObject financialStatement;
    public GameObject hint;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    public void NextTutorial()
    {
        if (idxShow < 2)
        {
            idxShow++;
        }
    }

    public void PrevTutorial()
    {
        if(idxShow > 0)
        {
            idxShow--;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (idxShow == 0)
        {

            valueDriverGO.SetActive(true);
            financialStatement.SetActive(false);
            hint.SetActive(false);
            percentageSliderValue.text = (sliderValue.value/2) + "%";

        }

        else if (idxShow == 1)
        {
            valueDriverGO.SetActive(false);
            financialStatement.SetActive(true);
            hint.SetActive(false);
        }

        else if (idxShow == 2)
        {
            valueDriverGO.SetActive(false);
            financialStatement.SetActive(false);
            hint.SetActive(true);
        }

    }
}
