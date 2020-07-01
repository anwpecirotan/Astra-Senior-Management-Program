using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoundariesData : MonoBehaviour
{
    public static double Realistic_OPM = TemplateData.Realistic_OPM;
    public static double Realistic_Inc_FC = TemplateData.Realistic_Inc_FC;
    public static double Realistic_Inc_WC = TemplateData.Realistic_Inc_WC;
    public static double Ideal_Sales_Growth_Rate = TemplateData.Ideal_Sales_Growth_Rate;
    public static double WACC_Baseline = TemplateData.WACC_Baseline;
    public static double Factor_of_Sales_Growth = TemplateData.Factor_of_Sales_Growth;
    public static double Impact_on_WACC = TemplateData.Impact_on_WACC;
    public static double WACC = ValueDrivers.SalesGrowthRate > Ideal_Sales_Growth_Rate ? WACC_Count() : WACC_Baseline;

    public static double WACC_Count()
    {
        double currentWACC = WACC_Baseline;
        double currentSalesGrowth = ValueDrivers.SalesGrowthRate - Ideal_Sales_Growth_Rate;
        while(currentSalesGrowth >= Factor_of_Sales_Growth)
        {
            currentWACC += 0.01;
            currentSalesGrowth -= Factor_of_Sales_Growth;
        }
        return currentWACC;
    }
}
