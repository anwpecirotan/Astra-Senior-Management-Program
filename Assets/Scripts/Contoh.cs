using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using SimpleJSON;
using UnityEngine.UI;
using TMPro;
public class Contoh : MonoBehaviour
{
    public TextMeshProUGUI feedbackText;
    public RawImage image;
    public void _OnButtonProfit()
    {
        StartCoroutine(GetProfitInisiative());
    }
    public IEnumerator GetProfitInisiative()
    {
        string webURL = "http://dev.accelist.com:9192/" + "api/v2/game/get-profit" + "?UserId=USER0002&password=lele123";
        UnityWebRequest requestProfitInisiative = UnityWebRequest.Get(webURL);
        yield return requestProfitInisiative.SendWebRequest();

        if (requestProfitInisiative.isNetworkError || requestProfitInisiative.isHttpError)
        {
            Debug.LogError(requestProfitInisiative.error);
            feedbackText.text = requestProfitInisiative.error;
            yield break;
        }
        else
        {

            string jsonRaw = "{\"dummy\":\"dummy\",\"results\":" + requestProfitInisiative.downloadHandler.text + '}';
            JSONNode profitList = JSON.Parse(jsonRaw);
            JSONNode profitNameList = profitList["results"];


            for (int i = 0, j = 10 - 1; i < 10; i++, j--)
            {
                feedbackText.text += profitNameList[i]["description"];
                feedbackText.text += profitNameList[i]["initiativeId"];
                feedbackText.text += profitNameList[i]["category"];
                UnityWebRequest imageRequest = UnityWebRequestTexture.GetTexture("http://dev.accelist.com:9192/" + "images/" + profitNameList[i]["imagePath"]);
                yield return imageRequest.SendWebRequest();
                if (imageRequest.isNetworkError || imageRequest.isHttpError)
                {
                    Debug.LogError(imageRequest.error);
                    yield break;
                }
                image.texture = DownloadHandlerTexture.GetContent(imageRequest);
                //print(pContainer.description[j] + " Added!");
            }
            feedbackText.text += "loaded";
        }
    }
}
