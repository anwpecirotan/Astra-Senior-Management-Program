using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ProfitScoreHandler : MonoBehaviour
{
    public TextMeshProUGUI score;
    public TextMeshProUGUI descriptionText;
    // Start is called before the first frame update
    void Start()
    {
        score.text = (GameManager.score * 5).ToString();
        descriptionText.text = "SELAMAT..!!! Anda berhasil menjawab " + GameManager.score + ". pernyataan dengan tepat dari 20 inisiatif yang diberikan.";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
