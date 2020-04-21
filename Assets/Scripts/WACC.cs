using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WACC : MonoBehaviour
{
    //WACC[] Funds = new WACC[3];
    public class Funds
    {
        public class ShorttermLoans
        {
            public static int dollarSL = LiabilitiesandOwnersEquity.Borrowing.Short_termLoans;
            public static double Weights = dollarSL / WACCTotal.totalDollar;
            public static double Cost = 0.09;
            public static double AfterTaxCost = Cost * (1 - ValueDrivers.CashTaxRate);
            public static double WeightedCost = AfterTaxCost * Weights;
        }

        public class LongtermLoans
        {
            public static int dollarLL = LiabilitiesandOwnersEquity.Borrowing.Long_termLoans;
            public static double Weights = dollarLL / WACCTotal.totalDollar;
            public static double Cost = 0.1;
            public static double AfterTaxCost = Cost * (1 - ValueDrivers.CashTaxRate);
            public static double WeightedCost = AfterTaxCost * Weights;
        }

        public class OwnersEquity
        {
            public static int dollarOE = LiabilitiesandOwnersEquity.OwnersEquity.TotalOE;
            public static double Weights = dollarOE / WACCTotal.totalDollar;
            public static double Cost = 0.12;
            public static double AfterTaxCost = Cost * (1 - ValueDrivers.CashTaxRate);
            public static double WeightedCost = AfterTaxCost * Weights;
        }

        public class WACCTotal
        {
            public static int totalDollar = LiabilitiesandOwnersEquity.Borrowing.Short_termLoans;
            public static double TotalWeights = ShorttermLoans.Weights + LongtermLoans.Weights + OwnersEquity.Weights;
            public static double TotalWeightedCost = ShorttermLoans.WeightedCost + LongtermLoans.WeightedCost + OwnersEquity.WeightedCost;
        }
    }
    


    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
