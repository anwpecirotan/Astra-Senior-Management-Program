using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TemplateData : MonoBehaviour
{
    public static int CurrentAsset_Cash = 170;
    public static int CurrentAsset_AccountsReceivable = 2820;
    public static int CurrentAsset_Inventory = 4000;
    public static int CurrentAsset_MiscellaneousCA = 510;
    public static int CurrentAsset_FixedAssets_NotFA = 2500;

    public static int CurrentLiabilities_LessShorttermLoans_AccountsPayables = 2750;
    public static int CurrentLiabilities_LessShorttermLoans_MiscellaneousCL = 500;

    public static int Borrowing_Short_termLoans = 1000;
    public static int Borrowing_Long_termLoans = 1544;

    public static int OwnersEquity_IssuedCapital = 1980;
    public static int OwnersEquity_RetainedEarnings = 2226;

    public static int ProfitandLossStatement_Sales = 12500;
    public static int ProfitandLossStatement_OperatingExpenses = 11500;
    public static int ProfitandLossStatement_Interest = 192;
    public static int ProfitandLossStatement_Tax = 202;
    public static int ProfitandLossStatement_Dividend = 182;

    public static double Funds_ShorttermLoans_Cost = 0.09;
    public static double Funds_LongtermLoans_Cost = 0.1;
    public static double Funds_OwnersEquity_Cost = 0.12;
    
    public static double AverageEconomicGrowth = 0.03;

    public static double Realistic_OPM = 0.09;
    public static double Realistic_Inc_FC = 0.1;
    public static double Realistic_Inc_WC = 0.25;
    public static double Ideal_Sales_Growth_Rate = 0.1;
    public static double WACC_Baseline = 0.1;
    public static double Factor_of_Sales_Growth = 0.025;
    public static double Impact_on_WACC = 0.01;

    public static double ValueDriver_SalesGrowthRate = 0.075;
    public static double ValueDriver_OperatingProfitMargin = 0.08;
    public static double ValueDriver_CashTaxRate = 0.25;
    public static double ValueDriver_IncrementalFixedCapitalInvestment = 0.2;
    public static double ValueDriver_IncrementalWorkingCapitalInvestment = 0.34;
    public static int ValueDriver_PlanningPeriod_Years = 5;
}
