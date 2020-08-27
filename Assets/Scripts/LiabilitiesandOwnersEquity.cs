using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class LiabilitiesandOwnersEquity : MonoBehaviour
{
    //BALANCE SHEET

    public static class CurrentAssets
    {
        public static int Cash = TemplateData.CurrentAsset_Cash;
        public static int AccountsReceivable = TemplateData.CurrentAsset_AccountsReceivable;
        public static int Inventory = TemplateData.CurrentAsset_Inventory;
        public static int MiscellaneousCA = TemplateData.CurrentAsset_MiscellaneousCA;
        public static int ToCurrentAssets = Cash + MiscellaneousCA + AccountsReceivable + Inventory;
        public static int FixedAssets_NotFA = TemplateData.CurrentAsset_FixedAssets_NotFA;
    }

    public static class TotalAssets
    {
        public static int totalAssets = CurrentAssets.ToCurrentAssets + CurrentAssets.FixedAssets_NotFA;
    }

    public static class CurrentLiabilities_LessShorttermLoans
    {
        public static int AccountsPayables = TemplateData.CurrentLiabilities_LessShorttermLoans_AccountsPayables;
        public static int MiscellaneousCL = TemplateData.CurrentLiabilities_LessShorttermLoans_MiscellaneousCL;
        public static int TotalCL = AccountsPayables + MiscellaneousCL; 
    }

    public static class Borrowing
    {
        public static int Short_termLoans = TemplateData.Borrowing_Short_termLoans;
        public static int Long_termLoans = TemplateData.Borrowing_Long_termLoans;
        public static int TotalBorr = Short_termLoans + Long_termLoans;
    }

    public static class OwnersEquity
    {
        public static int IssuedCapital = TemplateData.OwnersEquity_IssuedCapital;
        public static int RetainedEarnings = TemplateData.OwnersEquity_RetainedEarnings;
        public static int TotalOE = IssuedCapital + RetainedEarnings;
    }

    public static class TotalLiabilitiesandOwnersEquity
    {
        public static int TotalLOE = CurrentLiabilities_LessShorttermLoans.TotalCL + Borrowing.TotalBorr + OwnersEquity.TotalOE;
    }

    public class ProfitandLossStatement
    {
        public static int Sales = TemplateData.ProfitandLossStatement_Sales;
        public static int OperatingExpenses = TemplateData.ProfitandLossStatement_OperatingExpenses;
        public static int EBIT_EarningsBeforeInterestandTax = Sales - OperatingExpenses;
        public static int Interest = TemplateData.ProfitandLossStatement_Interest;
        public static int EBT_EarningsBeforeTax = EBIT_EarningsBeforeInterestandTax - Interest;
        public static int Tax = TemplateData.ProfitandLossStatement_Tax;
        public static int EAT_EarningsAfterTax = EBT_EarningsBeforeTax - Tax;
        public static int Dividend = (int)(EAT_EarningsAfterTax * TemplateData.KeyFigures_DPO);
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
        getData();
        
        
    }

    private void Update()
    {
        CashText.text = CurrentAssets.Cash.ToString("n0").Replace(',', '.') + "";
        AccountsReceivableText.text = CurrentAssets.AccountsReceivable.ToString("n0").Replace(',', '.') + "";
        InventoryText.text = CurrentAssets.Inventory.ToString("n0").Replace(',', '.') + "";
        MiscellaneousCAText.text = CurrentAssets.MiscellaneousCA.ToString("n0").Replace(',', '.') + "";
        ToCurrentAssetsText.text = CurrentAssets.ToCurrentAssets.ToString("n0").Replace(',', '.') + "";

        FixedAssets_NotFAText.text = CurrentAssets.FixedAssets_NotFA.ToString("n0").Replace(',', '.') + "";
        totalAssetsText.text = TotalAssets.totalAssets.ToString("n0").Replace(',', '.') + "";

        AccountsPayablesText.text = CurrentLiabilities_LessShorttermLoans.AccountsPayables.ToString("n0").Replace(',', '.') + "";
        MiscellaneousCLText.text = CurrentLiabilities_LessShorttermLoans.MiscellaneousCL.ToString("n0").Replace(',', '.') + "";
        TotalCLText.text = CurrentLiabilities_LessShorttermLoans.TotalCL.ToString("n0").Replace(',', '.') + "";

        Short_termLoansText.text = Borrowing.Short_termLoans.ToString("n0").Replace(',', '.') + "";
        Long_termLoansText.text = Borrowing.Long_termLoans.ToString("n0").Replace(',', '.') + "";
        TotalBorrText.text = Borrowing.TotalBorr.ToString("n0").Replace(',', '.') + "";

        IssuedCapitalText.text = OwnersEquity.IssuedCapital.ToString("n0").Replace(',', '.') + "";
        RetainedEarningsText.text = OwnersEquity.RetainedEarnings.ToString("n0").Replace(',', '.') + "";
        TotalOEText.text = OwnersEquity.TotalOE.ToString("n0").Replace(',', '.') + "";

        TotalLOEText.text = TotalLiabilitiesandOwnersEquity.TotalLOE.ToString("n0").Replace(',', '.') + "";

        SalesText.text = ProfitandLossStatement.Sales.ToString("n0").Replace(',', '.') + "";
        OperatingExpensesText.text = ProfitandLossStatement.OperatingExpenses.ToString("n0").Replace(',', '.') + "";
        EBIT_EarningsBeforeInterestandTaxText.text = ProfitandLossStatement.EBIT_EarningsBeforeInterestandTax.ToString("n0").Replace(',', '.') + "";
        InterestText.text = ProfitandLossStatement.Interest.ToString("n0").Replace(',', '.') + "";
        EBT_EarningsBeforeTaxText.text = ProfitandLossStatement.EBT_EarningsBeforeTax.ToString("n0").Replace(',', '.') + "";
        TaxText.text = ProfitandLossStatement.Tax.ToString("n0").Replace(',', '.') + "";
        EAT_EarningsAfterTaxText.text = ProfitandLossStatement.EAT_EarningsAfterTax.ToString("n0").Replace(',', '.') + "";
        DividendText.text = ProfitandLossStatement.Dividend.ToString("n0").Replace(',', '.') + "";
        RE_RetainedEarningsText.text = ProfitandLossStatement.RE_RetainedEarnings.ToString("n0").Replace(',', '.') + "";
    }

    private void getData()
    {
        CurrentAssets.Cash = TemplateData.CurrentAsset_Cash;
        CurrentAssets.AccountsReceivable = TemplateData.CurrentAsset_AccountsReceivable;
        CurrentAssets.Inventory = TemplateData.CurrentAsset_Inventory;
        CurrentAssets.MiscellaneousCA = TemplateData.CurrentAsset_MiscellaneousCA;
        CurrentAssets.ToCurrentAssets = CurrentAssets.Cash + CurrentAssets.MiscellaneousCA + CurrentAssets.AccountsReceivable + CurrentAssets.Inventory;
        CurrentAssets.FixedAssets_NotFA = TemplateData.CurrentAsset_FixedAssets_NotFA;

        TotalAssets.totalAssets = CurrentAssets.ToCurrentAssets + CurrentAssets.FixedAssets_NotFA;

        CurrentLiabilities_LessShorttermLoans.AccountsPayables = TemplateData.CurrentLiabilities_LessShorttermLoans_AccountsPayables;
        CurrentLiabilities_LessShorttermLoans.MiscellaneousCL = TemplateData.CurrentLiabilities_LessShorttermLoans_MiscellaneousCL;
        CurrentLiabilities_LessShorttermLoans.TotalCL = CurrentLiabilities_LessShorttermLoans.AccountsPayables + CurrentLiabilities_LessShorttermLoans.MiscellaneousCL;

        Borrowing.Short_termLoans = TemplateData.Borrowing_Short_termLoans;
        Borrowing.Long_termLoans = TemplateData.Borrowing_Long_termLoans;
        Borrowing.TotalBorr = Borrowing.Short_termLoans + Borrowing.Long_termLoans;

        OwnersEquity.IssuedCapital = TemplateData.OwnersEquity_IssuedCapital;
        OwnersEquity.RetainedEarnings = TemplateData.OwnersEquity_RetainedEarnings;
        OwnersEquity.TotalOE = OwnersEquity.IssuedCapital + OwnersEquity.RetainedEarnings;

        TotalLiabilitiesandOwnersEquity.TotalLOE = CurrentLiabilities_LessShorttermLoans.TotalCL + Borrowing.TotalBorr + OwnersEquity.TotalOE;

        ProfitandLossStatement.Sales = TemplateData.ProfitandLossStatement_Sales;
        ProfitandLossStatement.OperatingExpenses = TemplateData.ProfitandLossStatement_OperatingExpenses;
        ProfitandLossStatement.EBIT_EarningsBeforeInterestandTax = ProfitandLossStatement.Sales - ProfitandLossStatement.OperatingExpenses;
        ProfitandLossStatement.Interest = TemplateData.ProfitandLossStatement_Interest;
        ProfitandLossStatement.EBT_EarningsBeforeTax = ProfitandLossStatement.EBIT_EarningsBeforeInterestandTax - ProfitandLossStatement.Interest;
        ProfitandLossStatement.Tax = TemplateData.ProfitandLossStatement_Tax;
        ProfitandLossStatement.EAT_EarningsAfterTax = ProfitandLossStatement.EBT_EarningsBeforeTax - ProfitandLossStatement.Tax;
        ProfitandLossStatement.Dividend = (int)(ProfitandLossStatement.EAT_EarningsAfterTax * KeyFigures.DPO);
        ProfitandLossStatement.RE_RetainedEarnings = ProfitandLossStatement.EAT_EarningsAfterTax - ProfitandLossStatement.Dividend;
}
}
