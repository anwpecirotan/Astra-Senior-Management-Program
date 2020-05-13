using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BusinessValueAndShareholderValueWithPE_Ratio : MonoBehaviour
{
    public class ShareholdersValueAddedBasedOnMultiples
    {
        public static double PE_Ratio = 8;
        //public static double PVofContinuingValue = OperatingCashFlowsForecasts.Operations.NetOperatingProfitAfterTAX_NOPAT.ForecastPeriodYear5 *
        //                                           PE_Ratio;
        public static double PVofContinuingValue = 0;
    }
    

    public TextMeshProUGUI PE_RatioText, PVofContinuingValueText2;
    public TextMeshProUGUI CummulativePVofNetCashFlowsText, PVofContinuingValueText, BusinessValueText, AddNonOperatingAssetsText, CorporateValueText;
    public TextMeshProUGUI LessMarketValueOfDebtsText, ValueToShareholdersText, BookValueOfEquityText, ShareholdersValueAddedText;

    void Start()
    {
        
    }

    void Update()
    {
        double CummulativePVofNetCashFlows = OperatingCashFlowsForecasts.BaseCumulativeNCF;
        double PVofContinuingValue = OperatingCashFlowsForecasts.EndPeriodNOPAT * ShareholdersValueAddedBasedOnMultiples.PE_Ratio;
        double BusinessValue = CummulativePVofNetCashFlows + PVofContinuingValue;
        double AddNonOperatingAssets = 0;
        double CorporateValue = BusinessValue + AddNonOperatingAssets;
        double LessMarketValueOfDebts = KeyFigures.STLoans + KeyFigures.LTLoans;
        double ValueToShareholders = CorporateValue - LessMarketValueOfDebts;
        double BookValueOfEquity = KeyFigures.OwnersEquity;
        double ShareholdersValueAdded = ValueToShareholders - BookValueOfEquity;

        PE_RatioText.text = (int)ShareholdersValueAddedBasedOnMultiples.PE_Ratio + "$";
        CummulativePVofNetCashFlowsText.text = (int)CummulativePVofNetCashFlows + "$";
        PVofContinuingValueText.text = (int)PVofContinuingValue + "$";
        PVofContinuingValueText2.text = (int)PVofContinuingValue + "$";
        BusinessValueText.text = (int)BusinessValue + "$";
        AddNonOperatingAssetsText.text = (int)AddNonOperatingAssets + "$";
        CorporateValueText.text = (int)CorporateValue + "$";
        LessMarketValueOfDebtsText.text = (int)LessMarketValueOfDebts + "$";
        ValueToShareholdersText.text = (int)ValueToShareholders + "$";
        BookValueOfEquityText.text = (int)BookValueOfEquity + "$";
        ShareholdersValueAddedText.text = (int)ShareholdersValueAdded + "$";
    }
}
