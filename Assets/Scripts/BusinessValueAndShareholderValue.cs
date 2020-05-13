using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BusinessValueAndShareholderValue : MonoBehaviour
{
    //public static double CummulativePVofNetCashFlows = OperatingCashFlowsForecasts.NetCashFlows_FreeCashFlows.CummulativePresentValueNCF.BaseFigures;
    //public static double PVofContinuingValue = OperatingCashFlowsForecasts.NetCashFlows_FreeCashFlows.PVofContinuingValue.BaseFigures;
    //public static double BusinessValue = CummulativePVofNetCashFlows + PVofContinuingValue;
    //public static double AddNonOperatingAssets = 0;
    //public static double CorporateValue = BusinessValue + AddNonOperatingAssets;
    //public static double LessMarketValueOfDebts = KeyFigures.STLoans + KeyFigures.LTLoans;
    //public static double ValueToShareholders = CorporateValue - LessMarketValueOfDebts;
    //public static double BookValueOfEquity = KeyFigures.OwnersEquity;
    //public static double ShareholdersValueAdded = ValueToShareholders - BookValueOfEquity;

    public TextMeshProUGUI CummulativePVofNetCashFlowsText, PVofContinuingValueText, BusinessValueText, AddNonOperatingAssetsText, CorporateValueText;
    public TextMeshProUGUI LessMarketValueOfDebtsText, ValueToShareholdersText, BookValueOfEquityText, ShareholdersValueAddedText;

    void Start()
    {
        
    }

    void Update()
    {
        double CummulativePVofNetCashFlows = OperatingCashFlowsForecasts.BaseCumulativeNCF;
        double PVofContinuingValue = OperatingCashFlowsForecasts.NetCashFlows_FreeCashFlows.PVofContinuingValue.BaseFigures;
        double BusinessValue = CummulativePVofNetCashFlows + PVofContinuingValue;
        double AddNonOperatingAssets = 0;
        double CorporateValue = BusinessValue + AddNonOperatingAssets;
        double LessMarketValueOfDebts = KeyFigures.STLoans + KeyFigures.LTLoans;
        double ValueToShareholders = CorporateValue - LessMarketValueOfDebts;
        double BookValueOfEquity = KeyFigures.OwnersEquity;
        double ShareholdersValueAdded = ValueToShareholders - BookValueOfEquity;

        CummulativePVofNetCashFlowsText.text = (int)CummulativePVofNetCashFlows + "$";
        PVofContinuingValueText.text = (int)PVofContinuingValue + "$";
        BusinessValueText.text = (int)BusinessValue + "$";
        AddNonOperatingAssetsText.text = (int)AddNonOperatingAssets + "$";
        CorporateValueText.text = (int)CorporateValue + "$";
        LessMarketValueOfDebtsText.text = (int)LessMarketValueOfDebts + "$";
        ValueToShareholdersText.text = (int)ValueToShareholders + "$";
        BookValueOfEquityText.text = (int)BookValueOfEquity + "$";
        ShareholdersValueAddedText.text = (int)ShareholdersValueAdded + "$";
    }
}
