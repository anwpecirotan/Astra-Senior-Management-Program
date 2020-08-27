using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using SimpleJSON;
using UnityEngine.UI;
using TMPro;
public class PnGRequest : MonoBehaviour
{

    public TMP_InputField userField;
    public TMP_InputField passwordField;
    public TextMeshProUGUI feedbackMessage;
    public ProfitContainer pContainer;
    public GrowthContainer gContainer;
    public GameObject loadingPanel;

    public GameObject userErrorPanel;
    private bool pReady, gReady;
    public Button button;

    // private readonly string baseWebURL = "http://dev.accelist.com:9192/";

    private readonly string baseWebURL = "https://app-asrmp-admin-001.azurewebsites.net/";

    public string user_cont, pass_cont, token, employee_id, full_name;

    private void Start()
    {
        pReady = false;
        gReady = false;
        GrowthContainer.Clear();
        ProfitContainer.Clear();
    }

    private void Update()
    {
        if(pReady && gReady)
        {
            button.LoadSceneNumber(1);
            loadingPanel.SetActive(false);
        }
    }

    public struct User
    {
        public string UserId;
        public string Password;
    }
    public void _OnButtonSignIn()
    {
        StartCoroutine(SignIn(userField.text, passwordField.text));
    }
    public void _OnButtonViewPassword()
    {
        if (passwordField.contentType == TMP_InputField.ContentType.Password)
        {
            passwordField.contentType = TMP_InputField.ContentType.Standard;
        }
        else
        {
            passwordField.contentType = TMP_InputField.ContentType.Password;
        }

        passwordField.ActivateInputField();
    }
    public IEnumerator SignIn(string username, string password)
    {
        userErrorPanel.SetActive(false);
        loadingPanel.SetActive(true);
        var user = new User
        {
            UserId = username,
            Password = password
        };
        var body = JsonUtility.ToJson(user);
        string webURL = baseWebURL + "api/v1/login/loginess";
        UnityWebRequest request = UnityWebRequest.Post(webURL, body);
        byte[] jsonToSend = new System.Text.UTF8Encoding().GetBytes(body);
        request.uploadHandler = new UploadHandlerRaw(jsonToSend);
        request.downloadHandler = new DownloadHandlerBuffer();
        request.SetRequestHeader("Content-Type", "application/json");
        //request.SetRequestHeader("Access-Control-Allow-Credentials", "true");
        //request.SetRequestHeader("Access-Control-Allow-Headers", "Accept, X-Access-Token, X-Application-Name, X-Request-Sent-Time");
        //request.SetRequestHeader("Access-Control-Allow-Methods", "GET, POST, OPTIONS");
        request.SetRequestHeader("Access-Control-Allow-Origin", "*");
        feedbackMessage.text = "Loading...";

        yield return request.SendWebRequest();

        if (request.isNetworkError || request.isHttpError)
        {
            loadingPanel.SetActive(false);

            Debug.Log(request.error);
            if (request.error == "Failed to receive data" || request.error == "HTTP/1.1 404 Not Found")
            {
                feedbackMessage.text = request.error;
                StartCoroutine(SignIn(userField.text, passwordField.text));
            }

            else if (request.error == "HTTP/1.1 400 Bad Request")
            {
                userErrorPanel.SetActive(true);
            }

            
        }
        else
        {
            Debug.Log(request.downloadHandler.text);
            JSONNode allToken = JSON.Parse(request.downloadHandler.text);
            user_cont = username;
            pass_cont = password;
            token = allToken["token"];
            employee_id = allToken["employee_id"];
            full_name = allToken["full_name"];

            

            StartCoroutine(GetProfitInisiative());
            StartCoroutine(GetGrowthInisiative());
            yield return feedbackMessage.text = "All Done";
        }
    }

    public IEnumerator GetProfitInisiative()
    {
        string webURL = baseWebURL + "api/v3/game2/get-profit2";// + "?UserId=" + user_cont + "&password=" + pass_cont; 
        UnityWebRequest requestProfitInisiative = UnityWebRequest.Get(webURL);
        requestProfitInisiative.SetRequestHeader("Authorization", "Bearer " + token);
        yield return requestProfitInisiative.SendWebRequest();

        if (requestProfitInisiative.isNetworkError || requestProfitInisiative.isHttpError)
        {
            Debug.LogError(requestProfitInisiative.error);
            yield break;
        }
        else
        {
            
            string jsonRaw = "{\"dummy\":\"dummy\",\"results\":" + requestProfitInisiative.downloadHandler.text + '}';
            JSONNode profitList = JSON.Parse(jsonRaw);
            JSONNode profitNameList = profitList["results"];
            

            for (int i = 0, j = 10-1; i < 10; i++, j--)
            {
                ProfitContainer.description[j] = profitNameList[i]["description"];
                ProfitContainer.initiativeId[j] = profitNameList[i]["initiativeId"];
                ProfitContainer.category[j] = profitNameList[i]["category"];
                UnityWebRequest imageRequest = UnityWebRequestTexture.GetTexture(baseWebURL + "images/" + profitNameList[i]["imagePath"]);
                yield return imageRequest.SendWebRequest();
                if (imageRequest.isNetworkError || imageRequest.isHttpError)
                {
                    Debug.LogError(imageRequest.error);
                    if (imageRequest.error == "Failed to receive data" || imageRequest.error == "HTTP/1.1 404 Not Found")
                    {
                        feedbackMessage.text = imageRequest.error;
                        StartCoroutine(SignIn(userField.text, passwordField.text));
                    }

                    else if (imageRequest.error == "HTTP/1.1 400 Bad Request")
                    {
                        userErrorPanel.SetActive(true);
                        StartCoroutine(SignIn(userField.text, passwordField.text));
                    }
                    
                    yield break;
                }
                ProfitContainer.imageRaw[j] = DownloadHandlerTexture.GetContent(imageRequest);
                print(ProfitContainer.description[j] + " Added!");
            }
            feedbackMessage.text = "loaded";
            pReady = true;
        }
    }

    public IEnumerator GetGrowthInisiative()
    {
        string webURL = baseWebURL + "api/v3/game2/get-growth2";// + "?UserId=" + user_cont + "&password=" + pass_cont;
        UnityWebRequest requestGrowthInisiative = UnityWebRequest.Get(webURL);
        requestGrowthInisiative.SetRequestHeader("Authorization", "Bearer " + token);
        yield return requestGrowthInisiative.SendWebRequest();

        if (requestGrowthInisiative.isNetworkError || requestGrowthInisiative.isHttpError)
        {
            Debug.LogError(requestGrowthInisiative.error);
            yield break;
        }
        else
        {

            string jsonRaw = "{\"dummy\":\"dummy\",\"results\":" + requestGrowthInisiative.downloadHandler.text + '}';
            JSONNode growthList = JSON.Parse(jsonRaw);
            JSONNode growthNameList = growthList["results"];


            for (int i = 0, j = 10 - 1; i < 10; i++, j--)
            {
                GrowthContainer.description[j] = growthNameList[i]["description"];
                GrowthContainer.initiativeId[j] = growthNameList[i]["initiativeId"];
                GrowthContainer.category[j] = growthNameList[i]["category"];
                UnityWebRequest imageRequest = UnityWebRequestTexture.GetTexture(baseWebURL + "images/" + growthNameList[i]["imagePath"]);
                yield return imageRequest.SendWebRequest();
                if (imageRequest.isNetworkError || imageRequest.isHttpError)
                {
                    Debug.LogError(imageRequest.error);
                   if(imageRequest.error == "HTTP/1.1 404 Not Found")
                    {
                        feedbackMessage.text = imageRequest.error;
                        StartCoroutine(SignIn(userField.text, passwordField.text));
                    }
                    yield break;
                }
                GrowthContainer.imageRaw[j] = DownloadHandlerTexture.GetContent(imageRequest);
                print(GrowthContainer.description[j] + " Added!");
            }
            feedbackMessage.text = "loaded";
            gReady = true;
        }
    }

}
