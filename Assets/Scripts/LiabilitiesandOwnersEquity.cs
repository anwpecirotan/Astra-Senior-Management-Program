using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LiabilitiesandOwnersEquity : MonoBehaviour
{
    //BALANCE SHEET

    public class CurrentAssets
    {
        public static int Cash = 170;
        public int AccountsReceivable = 2820;
        public int Inventory = 4000;
        public static int MiscellaneousCA = 510;
        public static int ToCurrentAssets = Cash + MiscellaneousCA;
        public static int FixedAssets_NotFA = 2500;
    }

    public class TotalAssets
    {
        public int totalAssets = CurrentAssets.ToCurrentAssets + CurrentAssets.FixedAssets_NotFA;
    }

    public class CurrentLiabilities_LessShorttermLoans
    {
        public static int AccountsPayables = 2750;
        public static int MiscellaneousCL = 500;
        public static int TotalCL = AccountsPayables + MiscellaneousCL; 
    }

    public class Borrowing
    {
        public static int Short_termLoans = 1000;
        public static int Long_termLoans = 1544;
        public static int TotalBorr = Short_termLoans + Long_termLoans;
    }

    public class OwnersEquity
    {
        public static int IssuedCapital = 1980;
        public static int RetainedEarnings = 2226;
        public static int TotalOE = IssuedCapital + RetainedEarnings;
    }

    public class TotalLiabilitiesandOwnersEquity
    {
        public int TotalLOE = CurrentLiabilities_LessShorttermLoans.TotalCL + Borrowing.TotalBorr + OwnersEquity.TotalOE;
    }

    public class ProfitandLossStatement
    {
        public static int Sales = 12500;
        public static int OperatingExpenses = 11500;
        public static int EBIT_EarningsBeforeInterestandTax = Sales - OperatingExpenses;
        public static int Interest = 192;
        public static int EBT_EarningsBeforeTax = EBIT_EarningsBeforeInterestandTax - Interest;
        public static int Tax = 202;
        public static int EAT_EarningsAfterTax = EBT_EarningsBeforeTax - Tax;
        public static int Dividend = 0;
        public static int RE_RetainedEarnings = EAT_EarningsAfterTax - Dividend;
    }


    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
