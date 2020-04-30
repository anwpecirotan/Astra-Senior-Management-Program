using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class WACC : MonoBehaviour
{
    //WACC[] Funds = new WACC[3];
    public  class Funds
    {

        

        public static class ShorttermLoans
        {
            public static int dollarSL = LiabilitiesandOwnersEquity.Borrowing.Short_termLoans;
            public static double Weights = ((double)dollarSL / (LiabilitiesandOwnersEquity.Borrowing.TotalBorr + LiabilitiesandOwnersEquity.OwnersEquity.TotalOE))* 100;
            public static double Cost = 0.09 * 100;
            public static double AfterTaxCost = Cost * (100 - ValueDrivers.CashTaxRate *100)/100;
            public static double WeightedCost = AfterTaxCost * Weights/100;
        }

        public static class LongtermLoans
        {
            public static int dollarLL = LiabilitiesandOwnersEquity.Borrowing.Long_termLoans;
            public static double Weights = ((double)dollarLL / (LiabilitiesandOwnersEquity.Borrowing.TotalBorr + LiabilitiesandOwnersEquity.OwnersEquity.TotalOE)) * 100;
            public static double Cost = 0.1 * 100;
            public static double AfterTaxCost = Cost * (100 - ValueDrivers.CashTaxRate * 100) /100;
            public static double WeightedCost = AfterTaxCost * Weights / 100;
        }

        public static class OwnersEquity
        {
            public static int dollarOE = LiabilitiesandOwnersEquity.OwnersEquity.TotalOE;
            public static double Weights = ((double)dollarOE / (LiabilitiesandOwnersEquity.Borrowing.TotalBorr + LiabilitiesandOwnersEquity.OwnersEquity.TotalOE)) *100;
            public static double Cost = 0.12 * 100;
            public static double AfterTaxCost = Cost * (100 - ValueDrivers.CashTaxRate * 100) /100;
            public static double WeightedCost = AfterTaxCost * Weights / 100;
        }

        public static class WACCTotal
        {
            public static int totalDollar = ShorttermLoans.dollarSL + LongtermLoans.dollarLL + OwnersEquity.dollarOE;
            public static double TotalWeights = 100;
            public static double TotalWeightedCost = ShorttermLoans.WeightedCost + LongtermLoans.WeightedCost + OwnersEquity.WeightedCost;
        }
    }

    public TextMeshProUGUI dollarSLText, WeightsSLText, CostSLText, AfterTaxCostSLText, WeightedCostSLText;
    public TextMeshProUGUI dollarLLText, WeightsLLText, CostLLText, AfterTaxCostLLText, WeightedCostLLText;
    public TextMeshProUGUI dollarOEText, WeightsOEText, CostOEText, AfterTaxCostOEText, WeightedCostOEText;
    public TextMeshProUGUI totalDollarText, TotalWeightsText, TotalWeightedCostText;

    void Start()
    {
        dollarSLText.text = Funds.ShorttermLoans.dollarSL + "$";
        WeightsSLText.text = System.Math.Round(Funds.ShorttermLoans.Weights, 2) + "%";
        CostSLText.text = System.Math.Round(Funds.ShorttermLoans.Cost, 2) + "%";
        AfterTaxCostSLText.text = System.Math.Round(Funds.ShorttermLoans.AfterTaxCost, 2) + "%";
        WeightedCostSLText.text = System.Math.Round(Funds.ShorttermLoans.WeightedCost, 2) + "%";

        dollarLLText.text = Funds.LongtermLoans.dollarLL + "$";
        WeightsLLText.text = System.Math.Round(Funds.LongtermLoans.Weights, 2) + "%";
        CostLLText.text = System.Math.Round(Funds.LongtermLoans.Cost, 2) + "%";
        AfterTaxCostLLText.text = System.Math.Round(Funds.LongtermLoans.AfterTaxCost, 2) + "%";
        WeightedCostLLText.text = System.Math.Round(Funds.LongtermLoans.WeightedCost, 2) + "%";

        dollarOEText.text = Funds.OwnersEquity.dollarOE + "$";
        WeightsOEText.text = System.Math.Round(Funds.OwnersEquity.Weights, 2) + "%";
        CostOEText.text = System.Math.Round(Funds.OwnersEquity.Cost, 2) + "%";
        AfterTaxCostOEText.text = System.Math.Round(Funds.OwnersEquity.AfterTaxCost, 2) + "%";
        WeightedCostOEText.text = System.Math.Round(Funds.OwnersEquity.WeightedCost, 2) + "%";

        totalDollarText.text = Funds.WACCTotal.totalDollar + "$";
        TotalWeightsText.text = System.Math.Round(Funds.WACCTotal.TotalWeights, 2) + "%";
        TotalWeightedCostText.text = System.Math.Round(Funds.WACCTotal.TotalWeightedCost, 2) + "%";
    }

    void Update()
    {
        
    }
}
