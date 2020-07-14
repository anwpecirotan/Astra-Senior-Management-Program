using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CutsceneHandler : MonoBehaviour
{
    public GameObject skipButton;
    public GameObject nextButton;
    public int nextScene;
    public Image currentImage;
    public List<Sprite> spriteList;
    public Queue<Sprite> spriteQueue;
    // Start is called before the first frame update
    void Start()
    {
        spriteQueue = new Queue<Sprite>();
        foreach(Sprite sprite in spriteList)
        {
            spriteQueue.Enqueue(sprite);
        }
        currentImage.sprite = spriteQueue.Dequeue();
    }

    public void OnMouseDown()
    {
        Debug.Log("click");
        currentImage.sprite = spriteQueue.Dequeue();
        if (spriteQueue.Count == 0)
        {
            nextButton.SetActive(true);
            return;
        }
        if (spriteQueue.Count == 1)
        {
            skipButton.SetActive(false);
        }
    }

    public void Skip()
    {
        skipButton.SetActive(false);
        while(spriteQueue.Count != 1)
        {
            spriteQueue.Dequeue();
        }
        currentImage.sprite = spriteQueue.Dequeue();
        nextButton.SetActive(true);
    }
}
