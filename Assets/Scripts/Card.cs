using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Card : MonoBehaviour
{
    public string tagId;
    public string id;
    public GameManager gameManager;
    public bool isMouseOver = false;
    public string descriptionString;
    public Text title, description;
    public Texture2D image;
    private Animator anim;
    public int idx;
    //public Text idxHitung;

    private void Start()
    {
        anim = GetComponent<Animator>();
       // idxHitung.text = "1/20";
        idx = 1;
    }

    private void OnMouseOver()
    {
        isMouseOver = true;
    }

    private void OnMouseExit()
    {
        isMouseOver = false;
    }

    public void InduceRight()
    {
        if (!GameManager.instance.waiting)
        {
            if (tagId == "Profit")
            {
                gameManager.AnswerTrue();
            }
            else
            {
                gameManager.AnswerFalse();
            }
            idx++;
          //  idxHitung.text = idx + "/20";
        }
        //anim.SetTrigger("Right");
    }

    public void InduceLeft()
    {
        if (!GameManager.instance.waiting)
        {
            if (tagId == "Growth")
            {
                gameManager.AnswerTrue();
            }
            else
            {
                gameManager.AnswerFalse();
            }
            idx++;
           // idxHitung.text = idx + "/20";
        }
        //anim.SetTrigger("Left");
    }

    //public void InduceUp()
    //{
    //    if (tagId == "Financing")
    //    {
    //        gameManager.AnswerTrue();
    //    }
    //    else
    //    {
    //        gameManager.AnswerFalse();
    //    }
    //    anim.SetTrigger("Up");
    //}

}
