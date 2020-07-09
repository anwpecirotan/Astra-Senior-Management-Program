using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class GameManager : MonoBehaviour
{
    public GameObject cardTemplate;
    public List<GameObject> cardList;
    public Card card;
    public Text title, description;
    public Image image;
    public Card cardBack;
    public Text titleBack, descriptionBack;
    public Image imageBack;
    public Image check, cross;
    public GameObject endPanel;
    public Text scoreText;
    public static int score;

    public static GameManager instance = null;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
        else if(instance != this)
        {
            Destroy(gameObject);
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        NextCard();
        ShowCard();
        score = 0;
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AnswerTrue()
    {
        check.gameObject.SetActive(true);
        Invoke("RemovedCheck", 1);
        Debug.Log("true");
        score += 1;
    }

    public void AnswerFalse()
    {
        cross.gameObject.SetActive(true);
        Invoke("RemovedCross", 1);
        Debug.Log("false");
    }

    public void ShowCard()
    {
        if (cardBack != null)
        {
            card.tagId = cardBack.tagId;
            title.text = titleBack.text;
            description.text = descriptionBack.text;
            image.color = imageBack.color;
            image.sprite = imageBack.sprite;
            NextCard();
        }
        else
        {
            Destroy(card.gameObject);
            EndGame();
        }
    }

    public void NextCard()
    {
        if (cardList.Count != 0)
        {
            int index = Random.Range(0, cardList.ToArray().Length);
            GameObject nextCardObject = cardList[index];
            Card nextCard = nextCardObject.GetComponent<Card>();
            cardBack.tagId = nextCard.tagId;
            titleBack.text = nextCard.title.text;
            descriptionBack.text = nextCard.description.text;
            imageBack.color = nextCard.image.color;
            imageBack.sprite = nextCard.image.sprite;
            cardList.Remove(cardList[index]);
        }
        else
        {
            Destroy(cardBack.gameObject);
        }
    }

    public void AddCard(string title,string description,Image image,string type)
    {
        Card currCard = cardTemplate.GetComponent<Card>();
        currCard.title.text = title;
        currCard.description.text = description;
        currCard.image = image;
        cardTemplate.tag = "Profit";
        cardList.Add(cardTemplate);
        //Instantiate(cardTemplate, card.transform.position, Quaternion.identity);
    }
    

    private void RemovedCheck()
    {
        check.gameObject.SetActive(false);
    }

    private void RemovedCross()
    {
        cross.gameObject.SetActive(false);
    }

    private void EndGame()
    {
        Time.timeScale = 0f;
        endPanel.SetActive(true);
        scoreText.text = scoreText.text + score;
    }
}
