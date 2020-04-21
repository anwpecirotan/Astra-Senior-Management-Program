using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BusinessValueAndShareholderValue : MonoBehaviour
{
    public static double CummulativePVofNetCashFlows = OperatingCashFlowsForecasts.NetCashFlows_FreeCashFlows.CummulativePresentValueNCF.BaseFigures;
    public static double PVofContinuingValue = OperatingCashFlowsForecasts.NetCashFlows_FreeCashFlows.PVofContinuingValue.BaseFigures;
    public static double BusinessValue = CummulativePVofNetCashFlows + PVofContinuingValue;
    public static double AddNonOperatingAssets = 0;
    public static double CorporateValue = BusinessValue + AddNonOperatingAssets;
    public static double LessMarketValueOfDebts = KeyFigures.STLoans + KeyFigures.LTLoans;
    public static double ValueToShareholders = CorporateValue - LessMarketValueOfDebts;
    public static double BookValueOfEquity = KeyFigures.OwnersEquity;
    public static double ShareholdersValueAdded = ValueToShareholders - BookValueOfEquity;

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
