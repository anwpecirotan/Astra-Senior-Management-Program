using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;

public class InformationHolder : MonoBehaviour,IPointerEnterHandler
{
    public string information,title,description;

    public GameObject popupWindowObject,clickPanel;

    private void Start()
    {
        //popupWindowObject.SetActive(false);
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        InformationFormulaData.informationHover = information;
    }

    public void OnClick()
    {
        clickPanel.SetActive(true);
        InformationFormulaData.title = title;
        InformationFormulaData.description = description;
    }
}
