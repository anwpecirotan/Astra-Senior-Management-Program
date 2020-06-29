using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class ScoreHandler : MonoBehaviour
{
    public enum Score
    {
        A,
        B,
        C
    }

    private Score currentScore;
    public int standardScore;
    public TextMeshProUGUI scoreText;

    private void Start()
    {
        currentScore = Score.A;
        scoreText.text = "A";
        if(ValueDrivers.OperatingProfitMargin > BoundariesData.Realistic_OPM || ValueDrivers.IncrementalFixedCapitalInvestment < BoundariesData.Realistic_Inc_FC || ValueDrivers.IncrementalWorkingCapitalInvestment < BoundariesData.Realistic_Inc_WC)
        {
            currentScore = Score.C;
            scoreText.text = "C";
        }
        else if(OperatingCashFlowsForecasts.NetCashFlows_FreeCashFlows.CummulativePresentValueNCF.BaseFigures < 0)
        {
            currentScore = Score.C;
            scoreText.text = "C";
        }
        else if(BusinessValueAndShareholderValue.shareholderValueAdded < standardScore)
        {
            currentScore = Score.B;
            scoreText.text = "B";
        }
    }
}
