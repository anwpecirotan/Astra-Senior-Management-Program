﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Networking;
using SimpleJSON;
using UnityEngine.UI;
using TMPro;

public class ValueCreationRequest : MonoBehaviour
{
    public TMP_InputField userField;
    public TMP_InputField passwordField;
    public TMP_Dropdown templateListDropDown;
    public TextMeshProUGUI dropDownDefault;

    public GameObject TemplateCanvas;
    public Button button;

    public containerValueCreation containerVC;

    public TextMeshProUGUI feedbackMessage;

    private readonly string baseWebURL = "http://dev.accelist.com:9192/";

    public string user_cont, pass_cont,token,employee_id,full_name;

    private void Start()
    {
        templateListDropDown.ClearOptions();
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
    public IEnumerator SignIn(string username,string password)
    {
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
        feedbackMessage.text = "Loading...";

        yield return request.SendWebRequest();
        
        if (request.isNetworkError || request.isHttpError)
        {
            feedbackMessage.text = "Invalid Username or Password";
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

        yield return user_cont;
        StartCoroutine(ShowAllTemplateList());

        }
       

    }  
    public IEnumerator ShowAllTemplateList()
    {
        TemplateCanvas.SetActive(true);
        string webURL = baseWebURL + "api/v2/game/get-value-creation?UserId="+ user_cont+"&password="+pass_cont;
        UnityWebRequest templateRequestList = UnityWebRequest.Get(webURL);
        yield return templateRequestList.SendWebRequest();

        if (templateRequestList.isNetworkError || templateRequestList.isHttpError)
        {
            Debug.LogError(templateRequestList.error);
            yield break;
        }
        else
        {
            print("loaded");
        }
        string jsonRaw = "{\"dummy\":\"dummy\",\"results\":" + templateRequestList.downloadHandler.text + '}';
        JSONNode templateList = JSON.Parse(jsonRaw);
        print(templateList);
        JSONNode templateNameList = templateList["results"];
        string[] arrayOfName = new string[templateNameList.Count];
        templateListDropDown.ClearOptions();
        dropDownDefault.text = "Select Industry";
        templateListDropDown.options.Add(new TMP_Dropdown.OptionData() { text = "Select Industry" });
        for (int i = 0, j = templateNameList.Count - 1; i < templateNameList.Count; i++, j--)
        {
            arrayOfName[j] = templateNameList[i]["templateName"];
            print(arrayOfName[j]);
            templateListDropDown.options.Add(new TMP_Dropdown.OptionData() { text = arrayOfName[j] });
        }

        feedbackMessage.text = "Data Request Done!";
    }

    public void _OnButtonPickTemplate()
    {
        if(templateListDropDown.options[templateListDropDown.value].text != "Select Industry")
        StartCoroutine(PickTemplate(templateListDropDown.options[templateListDropDown.value].text));
        else
        {
            feedbackMessage.text = "Please Select Industry";
        }
    }
    public IEnumerator PickTemplate(string templateName)
    {
        string webURL = baseWebURL + "api/v2/game/get-valuecreation/"+templateName+"?UserId=" + user_cont + "&password=" + pass_cont;
        UnityWebRequest templateRequestList = UnityWebRequest.Get(webURL);
        yield return templateRequestList.SendWebRequest();
        if (templateRequestList.isNetworkError || templateRequestList.isHttpError)
        {
            Debug.LogError(templateRequestList.error);
            yield break;
        }
        else
        {
            string jsonRaw = templateRequestList.downloadHandler.text;

            jsonRaw = jsonRaw.Substring(1, jsonRaw.Length - 2);
            print(jsonRaw);

            JSONNode detailsTemplate = JSON.Parse(jsonRaw);
   
            containerVC.ValueCreationId = detailsTemplate["valueCreationId"];
            containerVC.CompanyName = detailsTemplate["templateName"];
            //===============================================================

            containerVC.ValueDriver_SalesGrowthRate = detailsTemplate["valueDriverSalesGrowthRate"];
            containerVC.ValueDriver_OperatingProfitMargin = detailsTemplate["valueDriverOperatingProfitMargin"];
            containerVC.ValueDriver_CashTaxRate = detailsTemplate["valueDriverCashTaxRate"];
            containerVC.ValueDriver_IncrementalFixedCapitalInvestment = detailsTemplate["valueDriverIncFixedCapitalInvestment"];
            containerVC.ValueDriver_IncrementalWorkingCapitalInvestment = detailsTemplate["valueDriverIncWorkingCapitalInvestment"];
            containerVC.ValueDriver_PlanningPeriod_Years = detailsTemplate["valueDriverPlanningPeriodYears"];
            
            //================================================================

            containerVC.CurrentAsset_Cash = detailsTemplate["currentAssetCash"];
            containerVC.CurrentAsset_AccountsReceivable = detailsTemplate["currentAssetAccountsReceivable"];
            containerVC.CurrentAsset_Inventory = detailsTemplate["currentAssetInventory"];
            containerVC.CurrentAsset_MiscellaneousCA = detailsTemplate["currentAssetMiscellaneousCA"];
            containerVC.CurrentAsset_FixedAssets_NotFA = detailsTemplate["currentAssetFixedAssetsNotFA"];

            //=================================================================

            containerVC.CurrentLiabilities_LessShorttermLoans_AccountsPayables = detailsTemplate["currentLiabilitiesLessShorttermLoansAccountsPayables"];
            containerVC.CurrentLiabilities_LessShorttermLoans_MiscellaneousCL = detailsTemplate["currentLiabilitiesLessShorttermLoansMiscellaneousCL"];
            
            //=================================================================

            containerVC.Borrowing_Short_termLoans = detailsTemplate["borrowingShorttermLoans"];
            containerVC.Borrowing_Long_termLoans = detailsTemplate["borrowingLong_ermLoans"];

            //=================================================================

            containerVC.OwnersEquity_IssuedCapital = detailsTemplate["ownersEquityIssuedCapital"];
            containerVC.OwnersEquity_RetainedEarnings = detailsTemplate["ownersEquityRetainedEarnings"];

            //=================================================================

            containerVC.ProfitandLossStatement_Sales = detailsTemplate["profitandLossStatementSales"];
            containerVC.ProfitandLossStatement_OperatingExpenses = detailsTemplate["profitandLossStatementOperatingExpenses"];
            containerVC.ProfitandLossStatement_Interest = detailsTemplate["profitandLossStatementInterest"];
            containerVC.ProfitandLossStatement_Tax = detailsTemplate["profitandLossStatementTax"];

        
            containerVC.KeyFigures_DPO = detailsTemplate["keyFiguresDPO"];
            //=================================================================

            containerVC.Funds_ShorttermLoans_Cost = detailsTemplate["fundsShorttermLoansCost"];
            containerVC.Funds_LongtermLoans_Cost = detailsTemplate["fundsLongtermLoansCost"];
            containerVC.Funds_OwnersEquity_Cost = detailsTemplate["fundsOwnersEquityCost"];

            //=================================================================

            containerVC.AverageEconomicGrowth = detailsTemplate["averageEconomicGrowth"];

            //=================================================================

            containerVC.Realistic_OPM = detailsTemplate["realisticOPM"];
            containerVC.Realistic_Inc_FC = detailsTemplate["realisticIncFC"];
            containerVC.Realistic_Inc_WC = detailsTemplate["realisticIncWC"];
            containerVC.Ideal_Sales_Growth_Rate = detailsTemplate["idealSalesGrowthRate"];
            containerVC.WACC_Baseline = detailsTemplate["waccBaseline"];
            containerVC.Factor_of_Sales_Growth = detailsTemplate["factorOfSalesGrowth"];
            containerVC.Impact_on_WACC = detailsTemplate["impactOnWACC"];

            containerVC.ExportContent();
            //button.LoadSceneNumber(1);

        }

    }

}
