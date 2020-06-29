using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoundariesData : MonoBehaviour
{
    public static double Realistic_OPM = 0.09;
    public static double Realistic_Inc_FC = 0.1;
    public static double Realistic_Inc_WC = 0.25;
    public static double Ideal_Sales_Growth_Rate = 0.1;
    public static double WACC_Baseline = 0.1;
    public static double Factor_of_Sales_Growth = 0.025;
    public static double Impact_on_WACC = 0.01;
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
