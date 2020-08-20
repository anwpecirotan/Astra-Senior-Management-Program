using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class PreviousNextScripts : MonoBehaviour
{
    public int idxShow;
   // public GameObject buttonNext, buttonPrevious;
    public GameObject[] image;

    private void Start()
    {
        idxShow = 0;
        Check();
    }

    public void _OnButtonClose()
    {
        gameObject.SetActive(false);
    }
    public void _OnButtonNext()
    {
        if (idxShow >= image.Length-1)
        {
            _OnButtonClose();
        }
        else
        {
            image[idxShow].SetActive(false);
            image[idxShow + 1].SetActive(true);
            idxShow++;
        }

    }

    public void _OnButtonPrevious()
    {
        if (idxShow >= 0)
        {
            image[idxShow].SetActive(false);
            image[idxShow -1].SetActive(true);
            idxShow--;

        }
    }

    public void Check()
    {
        //for(int i=0; i < image.Length; i++)
        //{
        //    if (idxShow == i)
        //    {
        //        image[i].SetActive(true);
        //    }
        //}

    }
}
