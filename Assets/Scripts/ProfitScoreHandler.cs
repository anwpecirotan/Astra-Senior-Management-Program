using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ProfitScoreHandler : MonoBehaviour
{
    public TextMeshProUGUI score;
    // Start is called before the first frame update
    void Start()
    {
        score.text = GameManager.score + "/20";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
