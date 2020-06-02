using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class InformationFormulaData : MonoBehaviour
{
    public static string informationHover = "empty" ;
    public static string title = "empty";
    public static string description = "empty";
    public TextMeshProUGUI textUI,titleText,descriptionText;
    // Update is called once per frame
    void Update()
    {
        textUI.text = informationHover;
        titleText.text = title;
        descriptionText.text = description;
    }
}
