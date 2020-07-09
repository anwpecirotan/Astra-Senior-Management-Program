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
    public TextMeshProUGUI scoreDescriptionText;

    private void Start()
    {
        currentScore = Score.A;
        scoreText.text = "A";
        scoreDescriptionText.text = "SELAMAT..!!! Anda berhasil meningkatkan nilai perusahaan dari 4390. menjaadi " +(int) BusinessValueAndShareholderValue.shareholderValueAdded +  ".";
        if (ValueDrivers.OperatingProfitMargin > BoundariesData.Realistic_OPM || ValueDrivers.IncrementalFixedCapitalInvestment < BoundariesData.Realistic_Inc_FC || ValueDrivers.IncrementalWorkingCapitalInvestment < BoundariesData.Realistic_Inc_WC)
        {
            currentScore = Score.C;
            scoreText.text = "C";
            scoreDescriptionText.text = "Inisiatif Anda tidak realistis";
        }
        else if(OperatingCashFlowsForecasts.NetCashFlows_FreeCashFlows.CummulativePresentValueNCF.BaseFigures < 0)
        {
            currentScore = Score.C;
            scoreText.text = "C";
            scoreDescriptionText.text = "Inisiatif Anda tidak realistis";
        }
        else if(BusinessValueAndShareholderValue.shareholderValueAdded < standardScore)
        {
            currentScore = Score.B;
            scoreText.text = "B";
            scoreDescriptionText.text = "Sayang sekali, inisiatif Anda menurunkan nilai perusahaan dari 4390. menjaadi "+ (int)BusinessValueAndShareholderValue.shareholderValueAdded + ".";
        }
        else if(BusinessValueAndShareholderValue.shareholderValueAdded == standardScore)
        {
            currentScore = Score.B;
            scoreText.text = "B";
            scoreDescriptionText.text = "Sayang sekali, tidak ada perubahan dari inisiatif yang Anda buat";
        }
    }
}
