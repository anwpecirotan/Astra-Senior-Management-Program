using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class BusinessScoreHandler : MonoBehaviour
{
    public TextMeshProUGUI CummulativePVofNetCashFlowsText, PVofContinuingValueText, BusinessValueText, AddNonOperatingAssetsText, CorporateValueText;
    public TextMeshProUGUI LessMarketValueOfDebtsText, ValueToShareholdersText, BookValueOfEquityText, ShareholdersValueAddedText;
    public static double shareholderValueAdded;

    public TextMeshProUGUI SalesGrowthRateText, OPMText, IcrFixedText, IcrWorkText, WACCText, PlanningPeriod, CashTaxRate; 
    public TextMeshProUGUI NewSalesGrowthRateText, NewOPMText, NewIcrFixedText, NewIcrWorkText, NewWACCText, NewPlanningPeriod, NewCashTaxRate; 

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

        CummulativePVofNetCashFlowsText.text = CummulativePVofNetCashFlows.ToString("n0").Replace(',', '.') + "";
        PVofContinuingValueText.text = PVofContinuingValue.ToString("n0").Replace(',', '.') + "";
        BusinessValueText.text = BusinessValue.ToString("n0").Replace(',', '.') + "";
        AddNonOperatingAssetsText.text = AddNonOperatingAssets.ToString("n0").Replace(',', '.') + "";
        CorporateValueText.text = CorporateValue.ToString("n0").Replace(',', '.') + "";
        LessMarketValueOfDebtsText.text = LessMarketValueOfDebts.ToString("n0").Replace(',', '.') + "";
        ValueToShareholdersText.text = ValueToShareholders.ToString("n0").Replace(',', '.') + "";
        BookValueOfEquityText.text = BookValueOfEquity.ToString("n0").Replace(',', '.') + "";
        ShareholdersValueAddedText.text = ShareholdersValueAdded.ToString("n0").Replace(',', '.') + "";
        shareholderValueAdded = ShareholdersValueAdded;

        
        SalesGrowthRateText.text = (TemplateData.ValueDriver_SalesGrowthRate * 100).ToString("n1").Replace(',', '.') + "%";
        OPMText.text = (TemplateData.ValueDriver_OperatingProfitMargin * 100).ToString("n1").Replace(',', '.') + "%";
        IcrFixedText.text = (TemplateData.ValueDriver_IncrementalFixedCapitalInvestment * 100).ToString("n1").Replace(',', '.') + "%";
        IcrWorkText.text = (TemplateData.ValueDriver_IncrementalWorkingCapitalInvestment * 100).ToString("n1").Replace(',', '.') + "%";
        WACCText.text = (TemplateData.WACC_Baseline * 100).ToString("n1").Replace(',', '.') + "%";
        PlanningPeriod.text = (TemplateData.ValueDriver_PlanningPeriod_Years).ToString("n0").Replace(',', '.') + " years";
        CashTaxRate.text = (TemplateData.ValueDriver_CashTaxRate * 100).ToString("n1").Replace(',', '.') + "%";


        NewSalesGrowthRateText.text = (ValueDrivers.SalesGrowthRate * 100).ToString("n1").Replace(',', '.') + "%";
        NewOPMText.text = (ValueDrivers.OperatingProfitMargin * 100).ToString("n1").Replace(',', '.') + "%";
        NewIcrFixedText.text = (ValueDrivers.IncrementalFixedCapitalInvestment * 100).ToString("n1").Replace(',', '.') + "%";
        NewIcrWorkText.text = (ValueDrivers.IncrementalWorkingCapitalInvestment * 100).ToString("n1").Replace(',', '.') + "%";
        NewWACCText.text = (BoundariesData.WACC * 100).ToString("n1").Replace(',', '.') + "%";
        NewPlanningPeriod.text = (ValueDrivers.PlanningPeriod_Years).ToString("n0").Replace(',', '.') + " years";
        NewCashTaxRate.text = (ValueDrivers.CashTaxRate * 100).ToString("n1").Replace(',', '.') + "%";
    }
}
