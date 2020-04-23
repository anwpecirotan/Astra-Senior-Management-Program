using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LiabilitiesandOwnersEquity : MonoBehaviour
{
    //BALANCE SHEET

    public static class CurrentAssets
    {
        public static int Cash = 170;
        public static int AccountsReceivable = 2820;
        public static int Inventory = 4000;
        public static int MiscellaneousCA = 510;
        public static int ToCurrentAssets = Cash + MiscellaneousCA + AccountsReceivable + Inventory;
        public static int FixedAssets_NotFA = 2500;
    }

    public static class TotalAssets
    {
        public static int totalAssets = CurrentAssets.ToCurrentAssets + CurrentAssets.FixedAssets_NotFA;
    }

    public static class CurrentLiabilities_LessShorttermLoans
    {
        public static int AccountsPayables = 2750;
        public static int MiscellaneousCL = 500;
        public static int TotalCL = AccountsPayables + MiscellaneousCL; 
    }

    public static class Borrowing
    {
        public static int Short_termLoans = 1000;
        public static int Long_termLoans = 1544;
        public static int TotalBorr = Short_termLoans + Long_termLoans;
    }

    public static class OwnersEquity
    {
        public static int IssuedCapital = 1980;
        public static int RetainedEarnings = 2226;
        public static int TotalOE = IssuedCapital + RetainedEarnings;
    }

    public static class TotalLiabilitiesandOwnersEquity
    {
        public static int TotalLOE = CurrentLiabilities_LessShorttermLoans.TotalCL + Borrowing.TotalBorr + OwnersEquity.TotalOE;
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

    public TextMeshProUGUI CashText, AccountsReceivableText, InventoryText, MiscellaneousCAText, ToCurrentAssetsText;
    public TextMeshProUGUI FixedAssets_NotFAText, totalAssetsText;
    public TextMeshProUGUI AccountsPayablesText, MiscellaneousCLText, TotalCLText;
    public TextMeshProUGUI Short_termLoansText, Long_termLoansText, TotalBorrText;
    public TextMeshProUGUI IssuedCapitalText, RetainedEarningsText, TotalOEText;
    public TextMeshProUGUI TotalLOEText;

    public TextMeshProUGUI SalesText, OperatingExpensesText, EBIT_EarningsBeforeInterestandTaxText, InterestText;
    public TextMeshProUGUI EBT_EarningsBeforeTaxText, TaxText, EAT_EarningsAfterTaxText, DividendText, RE_RetainedEarningsText;


    void Start()
    {
        CashText.text = CurrentAssets.Cash + "$";
        AccountsReceivableText.text = CurrentAssets.AccountsReceivable + "$";
        InventoryText.text = CurrentAssets.Inventory + "$";
        MiscellaneousCAText.text = CurrentAssets.MiscellaneousCA + "$";
        ToCurrentAssetsText.text = CurrentAssets.ToCurrentAssets + "$";

        FixedAssets_NotFAText.text = CurrentAssets.FixedAssets_NotFA + "$";
        totalAssetsText.text = TotalAssets.totalAssets + "$";

        AccountsPayablesText.text = CurrentLiabilities_LessShorttermLoans.AccountsPayables + "$";
        MiscellaneousCLText.text = CurrentLiabilities_LessShorttermLoans.MiscellaneousCL + "$";
        TotalCLText.text = CurrentLiabilities_LessShorttermLoans.TotalCL + "$";

        Short_termLoansText.text = Borrowing.Short_termLoans + "$";
        Long_termLoansText.text = Borrowing.Long_termLoans + "$";
        TotalBorrText.text = Borrowing.TotalBorr + "$";

        IssuedCapitalText.text = OwnersEquity.IssuedCapital + "$";
        RetainedEarningsText.text = OwnersEquity.RetainedEarnings + "$";
        TotalOEText.text = OwnersEquity.TotalOE + "$";

        TotalLOEText.text = TotalLiabilitiesandOwnersEquity.TotalLOE + "$";

        SalesText.text = ProfitandLossStatement.Sales + "$";
        OperatingExpensesText.text = ProfitandLossStatement.OperatingExpenses + "$";
        EBIT_EarningsBeforeInterestandTaxText.text = ProfitandLossStatement.EBIT_EarningsBeforeInterestandTax + "$";
        InterestText.text = ProfitandLossStatement.Interest + "$";
        EBT_EarningsBeforeTaxText.text = ProfitandLossStatement.EBT_EarningsBeforeTax + "$";
        TaxText.text = ProfitandLossStatement.Tax + "$";
        EAT_EarningsAfterTaxText.text = ProfitandLossStatement.EAT_EarningsAfterTax + "$";
        DividendText.text = ProfitandLossStatement.Dividend + "$";
        RE_RetainedEarningsText.text = ProfitandLossStatement.RE_RetainedEarnings + "$";
        
    }

    void Update()
    {
        
    }
}
