using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
public class ButtonUpDownValueDrivers : MonoBehaviour
{
    public float valueChange;
    public Slider theSliderChanges;
    public bool isClicked;

    public float maxTimer, moveTimer, fasterTimer;
    public void _OnButtonDown()
    {
        isClicked = true;
    }

    public void _OnButtonUp()
    {
        isClicked = false;
        theSliderChanges.value += valueChange;
        moveTimer = 0;
        fasterTimer = 0;
    }
    

  
    private void Update()
    {
        if (isClicked)
        {
            moveTimer += Time.deltaTime;
            fasterTimer += Time.deltaTime;
        }
        
        if(fasterTimer>= 1f)
        {
            if (moveTimer >= 0.1f)
            theSliderChanges.value += valueChange;
        }
            
        else if (moveTimer >= maxTimer)
        {
            theSliderChanges.value += valueChange;
            moveTimer = 0;
        }
    }

}
