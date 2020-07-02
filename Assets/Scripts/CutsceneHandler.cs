using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class CutsceneHandler : MonoBehaviour
{
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
        if (spriteQueue.Count == 0)
        {
            SceneManager.LoadScene(nextScene);
            return;
        }
        currentImage.sprite = spriteQueue.Dequeue();
    }
}
