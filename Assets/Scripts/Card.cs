using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Card : MonoBehaviour
{
    public string tagId;
    public GameManager gameManager;
    public bool isMouseOver = false;
    public Text title, description;
    public Image image;
    private Animator anim;

    private void Start()
    {
        anim = GetComponent<Animator>();
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
        if(tagId == "Profit")
        {
            gameManager.AnswerTrue();
        }
        else
        {
            gameManager.AnswerFalse();
        }
        //anim.SetTrigger("Right");
    }

    public void InduceLeft()
    {
        if (tagId == "Growth")
        {
            gameManager.AnswerTrue();
        }
        else
        {
            gameManager.AnswerFalse();
        }
        //anim.SetTrigger("Left");
    }

    public void InduceUp()
    {
        if (tagId == "Financing")
        {
            gameManager.AnswerTrue();
        }
        else
        {
            gameManager.AnswerFalse();
        }
        anim.SetTrigger("Up");
    }

}
