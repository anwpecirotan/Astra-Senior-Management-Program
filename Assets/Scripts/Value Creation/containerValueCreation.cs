using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class containerValueCreation : MonoBehaviour
{
    public string ValueCreationId;
    public string CompanyName;

    //initial value
    public double ValueDriver_SalesGrowthRate = 0;
    public double ValueDriver_OperatingProfitMargin = 0;
    public double ValueDriver_CashTaxRate = 0;
    public double ValueDriver_IncrementalFixedCapitalInvestment = 0;
    public double ValueDriver_IncrementalWorkingCapitalInvestment = 0;
    public int ValueDriver_PlanningPeriod_Years = 0;


    //balance sheet
    public int CurrentAsset_Cash = 0;
    public int CurrentAsset_AccountsReceivable = 0;
    public int CurrentAsset_Inventory = 0;
    public int CurrentAsset_MiscellaneousCA = 0;
    public int CurrentAsset_FixedAssets_NotFA = 0;

    public int CurrentLiabilities_LessShorttermLoans_AccountsPayables = 0;
    public int CurrentLiabilities_LessShorttermLoans_MiscellaneousCL = 0;

    public int Borrowing_Short_termLoans = 0;
    public int Borrowing_Long_termLoans = 0;

    public int OwnersEquity_IssuedCapital = 0;
    public int OwnersEquity_RetainedEarnings = 0;

    //profit & loss statement
    public int ProfitandLossStatement_Sales = 0;
    public int ProfitandLossStatement_OperatingExpenses = 0;
    public int ProfitandLossStatement_Interest = 0;
    public int ProfitandLossStatement_Tax = 0;
    //public  int ProfitandLossStatement_Dividend = 182;
    public double KeyFigures_DPO = 0;

    //supporting variables
    public double Funds_ShorttermLoans_Cost = 0;
    public double Funds_LongtermLoans_Cost = 0;
    public double Funds_OwnersEquity_Cost = 0;

    public double AverageEconomicGrowth = 0;

    public double Realistic_OPM = 0;
    public double Realistic_Inc_FC = 0;
    public double Realistic_Inc_WC = 0;
    public double Ideal_Sales_Growth_Rate = 0;
    public double WACC_Baseline = 0;
    public double Factor_of_Sales_Growth = 0;
    public double Impact_on_WACC = 0;

    public void ExportContent()
    {
        TemplateData.CompanyName = CompanyName;

        TemplateData.ValueDriver_SalesGrowthRate = ValueDriver_SalesGrowthRate;
        TemplateData.ValueDriver_OperatingProfitMargin = ValueDriver_OperatingProfitMargin;
        TemplateData.ValueDriver_CashTaxRate = ValueDriver_CashTaxRate;
        TemplateData.ValueDriver_IncrementalFixedCapitalInvestment = ValueDriver_IncrementalFixedCapitalInvestment;
        TemplateData.ValueDriver_IncrementalWorkingCapitalInvestment = ValueDriver_IncrementalWorkingCapitalInvestment;
        TemplateData.ValueDriver_PlanningPeriod_Years = ValueDriver_PlanningPeriod_Years;

        TemplateData.CurrentLiabilities_LessShorttermLoans_AccountsPayables = CurrentLiabilities_LessShorttermLoans_AccountsPayables;
        TemplateData.CurrentLiabilities_LessShorttermLoans_MiscellaneousCL = CurrentLiabilities_LessShorttermLoans_MiscellaneousCL;

        TemplateData.Borrowing_Short_termLoans = Borrowing_Short_termLoans;
        TemplateData.Borrowing_Long_termLoans = Borrowing_Long_termLoans;

        TemplateData.OwnersEquity_IssuedCapital = OwnersEquity_IssuedCapital;
        TemplateData.OwnersEquity_RetainedEarnings = OwnersEquity_RetainedEarnings;

        TemplateData.ProfitandLossStatement_Sales = ProfitandLossStatement_Sales;
        TemplateData.ProfitandLossStatement_OperatingExpenses = ProfitandLossStatement_OperatingExpenses;
        TemplateData.ProfitandLossStatement_Interest = ProfitandLossStatement_Interest;
        TemplateData.ProfitandLossStatement_Tax = ProfitandLossStatement_Tax;
        TemplateData.KeyFigures_DPO = KeyFigures_DPO;
        TemplateData.Funds_ShorttermLoans_Cost = Funds_ShorttermLoans_Cost;
        TemplateData.Funds_LongtermLoans_Cost = Funds_LongtermLoans_Cost;
        TemplateData.Funds_OwnersEquity_Cost = Funds_OwnersEquity_Cost;

        TemplateData.AverageEconomicGrowth = AverageEconomicGrowth;

        TemplateData.Realistic_OPM = Realistic_OPM;
        TemplateData.Realistic_Inc_FC = Realistic_Inc_FC;
        TemplateData.Realistic_Inc_WC = Realistic_Inc_WC;
        TemplateData.Ideal_Sales_Growth_Rate = Ideal_Sales_Growth_Rate;
        TemplateData.WACC_Baseline = WACC_Baseline;
        TemplateData.Factor_of_Sales_Growth = Factor_of_Sales_Growth;
        TemplateData.Impact_on_WACC = Impact_on_WACC;
    }
}
