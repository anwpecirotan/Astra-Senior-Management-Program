using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class KeyFigures : MonoBehaviour
{
    public static int FixedAssets = LiabilitiesandOwnersEquity.CurrentAssets.FixedAssets_NotFA;
    public static int CurrentAssets = LiabilitiesandOwnersEquity.CurrentAssets.ToCurrentAssets;
    public static int CurrentLiabilities_LessSTLoans = LiabilitiesandOwnersEquity.CurrentLiabilities_LessShorttermLoans.TotalCL;
    public static int STLoans = LiabilitiesandOwnersEquity.Borrowing.Short_termLoans;
    public static int LTLoans = LiabilitiesandOwnersEquity.Borrowing.Long_termLoans;
    public static int OwnersEquity = LiabilitiesandOwnersEquity.OwnersEquity.TotalOE;
    public static int NetWorkingCapital_NWC = CurrentAssets - CurrentLiabilities_LessSTLoans;
    public static int NWC = NetWorkingCapital_NWC;
    public static int FA = FixedAssets;
    public static int OperatingAssets = NWC + FA;
    public static int InvestedCapital_CapitalEmployed = STLoans + OwnersEquity + LTLoans;

    public static double ROE = (double)LiabilitiesandOwnersEquity.ProfitandLossStatement.EAT_EarningsAfterTax / LiabilitiesandOwnersEquity.OwnersEquity.TotalOE;
    public static double debtOfEquityRatio = (double)LiabilitiesandOwnersEquity.Borrowing.TotalBorr / LiabilitiesandOwnersEquity.OwnersEquity.TotalOE;
    public static double DPO = TemplateData.KeyFigures_DPO;
    public static double retainEarningRatio = (double)LiabilitiesandOwnersEquity.ProfitandLossStatement.RE_RetainedEarnings / LiabilitiesandOwnersEquity.ProfitandLossStatement.EAT_EarningsAfterTax;
    public static double IGR = (double)LiabilitiesandOwnersEquity.ProfitandLossStatement.RE_RetainedEarnings / LiabilitiesandOwnersEquity.TotalAssets.totalAssets;
    public static double SGR = ROE * retainEarningRatio;

    public TextMeshProUGUI FixedAssetsText, NetWorkingCapital_NWCText, CurrentAssetsText, CurrentLiabilities_LessSTLoansText;
    public TextMeshProUGUI OperatingAssetsText, NWCText, FAText, InvestedCapital_CapitalEmployedText;
    public TextMeshProUGUI STLoansText, LTLoansText, OwnersEquityText;
    public TextMeshProUGUI ROEText, debtOfEquityRatioText, DPOText;
    public TextMeshProUGUI retainEarningRatioText, IGRText, SGRText;

    void Start()
    {
        getData();
    }

    private void Update()
    {
        FixedAssetsText.text = FixedAssets.ToString("n0").Replace(',', '.') + "";
        NetWorkingCapital_NWCText.text = NetWorkingCapital_NWC.ToString("n0").Replace(',', '.') + "";
        CurrentAssetsText.text = CurrentAssets.ToString("n0").Replace(',', '.') + "";
        CurrentLiabilities_LessSTLoansText.text = CurrentLiabilities_LessSTLoans.ToString("n0").Replace(',', '.') + "";
        OperatingAssetsText.text = OperatingAssets.ToString("n0").Replace(',', '.') + "";
        NWCText.text = NWC.ToString("n0").Replace(',', '.') + "";
        FAText.text = FA.ToString("n0").Replace(',', '.') + "";
        InvestedCapital_CapitalEmployedText.text = InvestedCapital_CapitalEmployed.ToString("n0").Replace(',', '.') + "";
        STLoansText.text = STLoans.ToString("n0").Replace(',', '.') + "";
        LTLoansText.text = LTLoans.ToString("n0").Replace(',', '.') + "";
        OwnersEquityText.text = OwnersEquity.ToString("n0").Replace(',', '.') + "";

        ROEText.text = System.Math.Round(ROE * 100, 2) + "%";
        debtOfEquityRatioText.text = System.Math.Round(debtOfEquityRatio * 100, 2) + "%";
        DPOText.text = System.Math.Round(DPO * 100, 2) + "%";
        retainEarningRatioText.text = System.Math.Round(retainEarningRatio * 100, 2) + "%";
        IGRText.text = System.Math.Round(IGR * 100, 2) + "%";
        SGRText.text = System.Math.Round(SGR * 100, 2) + "%";
    }

    private void getData()
    {
        FixedAssets = LiabilitiesandOwnersEquity.CurrentAssets.FixedAssets_NotFA;
        CurrentAssets = LiabilitiesandOwnersEquity.CurrentAssets.ToCurrentAssets;
        CurrentLiabilities_LessSTLoans = LiabilitiesandOwnersEquity.CurrentLiabilities_LessShorttermLoans.TotalCL;
        STLoans = LiabilitiesandOwnersEquity.Borrowing.Short_termLoans;
        LTLoans = LiabilitiesandOwnersEquity.Borrowing.Long_termLoans;
        OwnersEquity = LiabilitiesandOwnersEquity.OwnersEquity.TotalOE;
        NetWorkingCapital_NWC = CurrentAssets - CurrentLiabilities_LessSTLoans;
        NWC = NetWorkingCapital_NWC;
        FA = FixedAssets;
        OperatingAssets = NWC + FA;
        InvestedCapital_CapitalEmployed = STLoans + OwnersEquity + LTLoans;

        ROE = (double)LiabilitiesandOwnersEquity.ProfitandLossStatement.EAT_EarningsAfterTax / LiabilitiesandOwnersEquity.OwnersEquity.TotalOE;
        debtOfEquityRatio = (double)LiabilitiesandOwnersEquity.Borrowing.TotalBorr / LiabilitiesandOwnersEquity.OwnersEquity.TotalOE;
        DPO = TemplateData.KeyFigures_DPO;
        retainEarningRatio = (double)LiabilitiesandOwnersEquity.ProfitandLossStatement.RE_RetainedEarnings / LiabilitiesandOwnersEquity.ProfitandLossStatement.EAT_EarningsAfterTax;
        IGR = (double)LiabilitiesandOwnersEquity.ProfitandLossStatement.RE_RetainedEarnings / LiabilitiesandOwnersEquity.TotalAssets.totalAssets;
        SGR = ROE * retainEarningRatio;
}
}
