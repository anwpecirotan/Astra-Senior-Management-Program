using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class InformationHolder : MonoBehaviour,IPointerEnterHandler
{
    public string information;

    public GameObject popupWindowObject;

    private void Start()
    {
        popupWindowObject.SetActive(false);
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        Debug.Log("test");
        InformationFormulaData.information = information;
    }

    
}
