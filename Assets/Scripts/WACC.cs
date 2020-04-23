using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class WACC : MonoBehaviour
{
    //WACC[] Funds = new WACC[3];
    public  class Funds
    {

        public static class WACCTotal
        {
            public static int totalDollar = LiabilitiesandOwnersEquity.Borrowing.TotalBorr + LiabilitiesandOwnersEquity.OwnersEquity.TotalOE;
            public static double TotalWeights = ShorttermLoans.Weights + LongtermLoans.Weights + OwnersEquity.Weights;
            public static double TotalWeightedCost = ShorttermLoans.WeightedCost + LongtermLoans.WeightedCost + OwnersEquity.WeightedCost;
        }

        public static class ShorttermLoans
        {
            public static int dollarSL = LiabilitiesandOwnersEquity.Borrowing.Short_termLoans;
            public static double Weights = dollarSL / WACCTotal.totalDollar;
            public static double Cost = 0.09;
            public static double AfterTaxCost = Cost * (1 - ValueDrivers.CashTaxRate);
            public static double WeightedCost = AfterTaxCost * Weights;
        }

        public static class LongtermLoans
        {
            public static int dollarLL = LiabilitiesandOwnersEquity.Borrowing.Long_termLoans;
            public static double Weights = dollarLL / WACCTotal.totalDollar;
            public static double Cost = 0.1;
            public static double AfterTaxCost = Cost * (1 - ValueDrivers.CashTaxRate);
            public static double WeightedCost = AfterTaxCost * Weights;
        }

        public static class OwnersEquity
        {
            public static int dollarOE = LiabilitiesandOwnersEquity.OwnersEquity.TotalOE;
            public static double Weights = dollarOE / WACCTotal.totalDollar;
            public static double Cost = 0.12;
            public static double AfterTaxCost = Cost * (1 - ValueDrivers.CashTaxRate);
            public static double WeightedCost = AfterTaxCost * Weights;
        }
    }

    public TextMeshProUGUI dollarSLText, WeightsSLText, CostSLText, AfterTaxCostSLText, WeightedCostSLText;
    public TextMeshProUGUI dollarLLText, WeightsLLText, CostLLText, AfterTaxCostLLText, WeightedCostLLText;
    public TextMeshProUGUI dollarOEText, WeightsOEText, CostOEText, AfterTaxCostOEText, WeightedCostOEText;
    public TextMeshProUGUI totalDollarText, TotalWeightsText, TotalWeightedCostText;

    void Start()
    {
        dollarSLText.text = Funds.ShorttermLoans.dollarSL + "$";
        WeightsSLText.text = System.Math.Round(Funds.ShorttermLoans.Weights,2) + "%";
        CostSLText.text = System.Math.Round(Funds.ShorttermLoans.Cost,2) + "%";
        AfterTaxCostSLText.text = System.Math.Round(Funds.ShorttermLoans.AfterTaxCost,2) + "%";
        WeightedCostSLText.text = System.Math.Round(Funds.ShorttermLoans.WeightedCost,2) + "%";

        dollarLLText.text = Funds.LongtermLoans.dollarLL + "$";
        WeightsLLText.text = System.Math.Round(Funds.LongtermLoans.Weights, 2) + "%";
        CostLLText.text = System.Math.Round(Funds.LongtermLoans.Cost, 2) + "%";
        AfterTaxCostLLText.text = System.Math.Round(Funds.LongtermLoans.AfterTaxCost, 2) + "%";
        WeightedCostLLText.text = System.Math.Round(Funds.LongtermLoans.WeightedCost, 2) + "%";

        dollarOEText.text = Funds.LongtermLoans.dollarLL + "$";
        WeightsOEText.text = System.Math.Round(Funds.LongtermLoans.Weights, 2) + "%";
        CostOEText.text = System.Math.Round(Funds.LongtermLoans.Cost, 2) + "%";
        AfterTaxCostOEText.text = System.Math.Round(Funds.LongtermLoans.AfterTaxCost, 2) + "%";
        WeightedCostOEText.text = System.Math.Round(Funds.LongtermLoans.WeightedCost, 2) + "%";

        totalDollarText.text = Funds.WACCTotal.totalDollar + "$";
        TotalWeightsText.text = System.Math.Round(Funds.WACCTotal.TotalWeights, 2) + "%";
        TotalWeightedCostText.text = System.Math.Round(Funds.WACCTotal.TotalWeightedCost, 2) + "%";
    }

    void Update()
    {
        
    }
}
