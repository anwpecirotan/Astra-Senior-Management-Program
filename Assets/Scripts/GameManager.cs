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
    public Text title;
    public TextMeshProUGUI description;
    public Image image;
    public Card cardBack;
    public Text titleBack, descriptionBack;
    public Image imageBack;
    public GameObject check, cross;
    public GameObject MainText;
    public GameObject endPanel;
    public Text scoreText;
    public bool waiting;
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
        waiting = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void AnswerTrue()
    {
        if (!waiting)
        {
            check.SetActive(true);
            MainText.SetActive(false);
            Invoke("RemovedCheck", 2);
            Debug.Log("true");
            score += 1;
            Invoke("ShowCard", 2);
        }
    }

    public void AnswerFalse()
    {
        if (!waiting)
        {
            cross.SetActive(true);
            MainText.SetActive(false);
            Invoke("RemovedCross", 2);
            Debug.Log("false");
            Invoke("ShowCard", 2);
        }
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

    public void AddProfitCard(string title,string description,Image image)
    {
        Card currCard = cardTemplate.GetComponent<Card>();
        currCard.title.text = title;
        currCard.description.text = description;
        currCard.image = image;
        cardTemplate.tag = "Profit";
        cardList.Add(cardTemplate);
        //Instantiate(cardTemplate, card.transform.position, Quaternion.identity);
    }

    public void AddGrowthCard(string title, string description, Image image)
    {
        Card currCard = cardTemplate.GetComponent<Card>();
        currCard.title.text = title;
        currCard.description.text = description;
        currCard.image = image;
        cardTemplate.tag = "Growth";
        cardList.Add(cardTemplate);
        //Instantiate(cardTemplate, card.transform.position, Quaternion.identity);
    }

    private void RemovedCheck()
    {
        check.gameObject.SetActive(false);
        MainText.SetActive(true);
    }

    private void RemovedCross()
    {
        cross.gameObject.SetActive(false);
        MainText.SetActive(true);
    }

    private void EndGame()
    {
        Time.timeScale = 0f;
        endPanel.SetActive(true);
        scoreText.text = scoreText.text + score;
    }
}
