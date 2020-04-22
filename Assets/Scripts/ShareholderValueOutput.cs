using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ShareholderValueOutput : MonoBehaviour
{
    public TextMeshProUGUI SalesGrowthRateText;
    // Start is called before the first frame update
    void Start()
    {
        SalesGrowthRateText.text = Mathf.Round((float)ValueDrivers.SalesGrowthRate * 100) + "%";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
