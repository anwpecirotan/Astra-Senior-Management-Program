using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwipeLogic : MonoBehaviour
{
    public GameObject card;
    public Card cardLogic;
    private Vector2 initPos;
    public float speed = 1f;
    private bool change;
    Vector3 startTouchPosition, endTouchPosition;
    public GameManager gameManager;
    public Animator cardAnim;

    // Start is called before the first frame update
    void Start()
    {
        initPos = card.transform.position;
        change = false;
    }

    // Update is called once per frame
    void Update()
    {
        //if(Input.GetMouseButton(0) && cardLogic.isMouseOver)
        //{
        //    Vector2 pos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        //    card.transform.position = pos;
        //}
        //else
        //{
        //    card.transform.position = Vector2.MoveTowards(card.transform.position,initPos, speed);
        //}
        //if(card.transform.position.x > 1)
        //{
        //    if(!Input.GetMouseButton(0) && !change)
        //    {
        //        cardLogic.InduceRight();
        //        change = true;
        //    }
        //}
        //if (card.transform.position.x < -1)
        //{
        //    if (!Input.GetMouseButton(0) && !change)
        //    {
        //        cardLogic.InduceLeft();
        //        change = true;
        //    }
        //}

        //if (card.transform.position.y > 1f)
        //{
        //    if (!Input.GetMouseButton(0) && !change)
        //    {
        //        cardLogic.InduceUp();
        //        change = true;
        //    }
        //}
        

        if (card.transform.position.x == initPos.x && card.transform.position.y == initPos.y)
        {
            if (change)
            {
                gameManager.ShowCard();
            }
            change = false;
        }

        //if (!change)
        //{
        //    if (Input.GetMouseButtonDown(0))
        //    {
        //        startTouchPosition = Input.mousePosition;
        //    }

        //    if (Input.GetMouseButtonUp(0))
        //    {
        //        endTouchPosition = Input.mousePosition;
        //        if (endTouchPosition.y - startTouchPosition.y > 100 && !(endTouchPosition.x - startTouchPosition.x > 500 || endTouchPosition.x - startTouchPosition.x < -500))
        //        {
        //            cardLogic.InduceUp();
        //            change = true;
        //            return;
        //        }

        //        if (endTouchPosition.x - startTouchPosition.x > 50)
        //        {
        //            cardLogic.InduceRight();
        //            change = true;
        //            return;
        //        }

        //        if (endTouchPosition.x - startTouchPosition.x < -50)
        //        {
        //            cardLogic.InduceLeft();
        //            change = true;
        //            return;
        //        }
        //    }
        //}


    }

    public void ChangeCardRight()
    {
        if(!change)
        {
            cardLogic.InduceRight();
            change = true;
        }
    }

    public void ChangeCardLeft()
    {
        if (!change)
        {
            cardLogic.InduceLeft();
            change = true;
        }
    }
}
