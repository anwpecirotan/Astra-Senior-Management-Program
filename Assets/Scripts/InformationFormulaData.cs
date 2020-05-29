using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InformationFormulaData : MonoBehaviour
{
    public static string information = "empty" ;
    public TextMeshProUGUI textUI;
    // Update is called once per frame
    void Update()
    {
        textUI.text = information; 
    }
}
