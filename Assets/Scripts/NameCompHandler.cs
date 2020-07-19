using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NameCompHandler : MonoBehaviour
{
    public TextMeshProUGUI nameText;
    // Start is called before the first frame update
    void Start()
    {
        nameText.text = TemplateData.CompanyName + " Company";
    }

    
}
