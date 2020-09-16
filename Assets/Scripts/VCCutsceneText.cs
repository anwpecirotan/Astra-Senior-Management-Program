using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class VCCutsceneText : MonoBehaviour
{
    public NarrativeController NarCon;
    public TextMeshProUGUI textDesc;

    
    void Update()
    {
        
        if(NarCon.idx == 4)
        {
            textDesc.gameObject.SetActive(true);
            textDesc.text = "Namun management perlu mempertimbangkan bahwa untuk setiap " +
                "kelipatan pertumbuhan sebesar" +
                " " +
                TemplateData.Factor_of_Sales_Growth*100 +
                "%," +
                " akan meningkatkan WACC sebesar " +
                TemplateData.Impact_on_WACC*100 +
                "%";
            print(TemplateData.Impact_on_WACC);
        }
        else
        {
            textDesc.gameObject.SetActive(false);
        }
    }
}
