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

    public TextMeshProUGUI FixedAssetsText, NetWorkingCapital_NWCText, CurrentAssetsText, CurrentLiabilities_LessSTLoansText;
    public TextMeshProUGUI OperatingAssetsText, NWCText, FAText, InvestedCapital_CapitalEmployedText;
    public TextMeshProUGUI STLoansText, LTLoansText, OwnersEquityText;

    void Start()
    {
        FixedAssetsText.text = FixedAssets + "$";
        NetWorkingCapital_NWCText.text = NetWorkingCapital_NWC + "$";
        CurrentAssetsText.text = CurrentAssets + "$";
        CurrentLiabilities_LessSTLoansText.text = CurrentLiabilities_LessSTLoans + "$";
        OperatingAssetsText.text = OperatingAssets + "$";
        NWCText.text = NWC + "$";
        FAText.text = FA + "$";
        InvestedCapital_CapitalEmployedText.text = InvestedCapital_CapitalEmployed + "$";
        STLoansText.text = STLoans + "$";
        LTLoansText.text = LTLoans + "$";
        OwnersEquityText.text = OwnersEquity + "$";
    }

    void Update()
    {
        
    }
}
