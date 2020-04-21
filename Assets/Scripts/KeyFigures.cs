using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KeyFigures : MonoBehaviour
{
    public static int FixedAssets = LiabilitiesandOwnersEquity.CurrentAssets.FixedAssets_NotFA;
    public static int NetWorkingCapital_NWC = CurrentAssets - CurrentLiabilities_LessSTLoans;
    public static int CurrentAssets = LiabilitiesandOwnersEquity.CurrentAssets.ToCurrentAssets;
    public static int CurrentLiabilities_LessSTLoans = LiabilitiesandOwnersEquity.CurrentLiabilities_LessShorttermLoans.TotalCL;
    public static int OperatingAssets = NWC + FA;
    public static int NWC = NetWorkingCapital_NWC;
    public static int FA = FixedAssets;
    public static int InvestedCapital_CapitalEmployed = STLoans + OwnersEquity;
    public static int STLoans = LiabilitiesandOwnersEquity.Borrowing.Short_termLoans;
    public static int LTLoans = LiabilitiesandOwnersEquity.Borrowing.Long_termLoans;
    public static int OwnersEquity = LiabilitiesandOwnersEquity.OwnersEquity.TotalOE;


    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
