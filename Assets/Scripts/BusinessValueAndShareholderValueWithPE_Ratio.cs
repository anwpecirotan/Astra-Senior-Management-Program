using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BusinessValueAndShareholderValuesWithPE_Ratio : MonoBehaviour
{
    public class ShareholdersValueAddedBasedOnMultiples
    {
        public static double PE_Ratio = 8;
        public static double PVofContinuingValue = OperatingCashFlowsForecasts.Operations.NetOperatingProfitAfterTAX_NOPAT.ForecastPeriodYear5 *
                                                   PE_Ratio;
    }

    public static double CummulativePVofNetCashFlows = OperatingCashFlowsForecasts.NetCashFlows_FreeCashFlows.CummulativePresentValueNCF.BaseFigures;
    public static double PVofContinuingValue = ShareholdersValueAddedBasedOnMultiples.PVofContinuingValue;
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
