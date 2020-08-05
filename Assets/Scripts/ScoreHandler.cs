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
    public GameObject imgA, imgB, imgC;

    private void Start()
    {
        currentScore = Score.A;
        scoreText.text = "A";
        scoreDescriptionText.text = "SELAMAT..!!! Anda berhasil meningkatkan nilai perusahaan dari "+ (int)CountStandard.BaseCumulativeNCF + ". menjaadi " +(int) BusinessValueAndShareholderValue.shareholderValueAdded +  ".";
        if (ValueDrivers.OperatingProfitMargin > (BoundariesData.Realistic_OPM + 0.001f) || ValueDrivers.IncrementalFixedCapitalInvestment < BoundariesData.Realistic_Inc_FC - 0.001f || ValueDrivers.IncrementalWorkingCapitalInvestment < BoundariesData.Realistic_Inc_WC - 0.001f)
        {
            currentScore = Score.C;
            scoreText.text = "C";
            scoreDescriptionText.text = "Inisiatif Anda tidak realistis";
            imgA.SetActive(false);
            imgC.SetActive(true);
        }
        else if(OperatingCashFlowsForecasts.NetCashFlows_FreeCashFlows.CummulativePresentValueNCF.BaseFigures < 0)
        {
            currentScore = Score.C;
            scoreText.text = "C";
            scoreDescriptionText.text = "Inisiatif Anda tidak realistis";
            imgA.SetActive(false);
            imgC.SetActive(true);
        }
        else if(BusinessValueAndShareholderValue.shareholderValueAdded < (int)CountStandard.BaseCumulativeNCF)
        {
            currentScore = Score.B;
            scoreText.text = "B";
            scoreDescriptionText.text = "Sayang sekali, inisiatif Anda menurunkan nilai perusahaan dari " + (int)CountStandard.BaseCumulativeNCF + ". menjaadi " + (int)BusinessValueAndShareholderValue.shareholderValueAdded + ".";
            imgA.SetActive(false);
            imgB.SetActive(true);
        }
        else if((int)BusinessValueAndShareholderValue.shareholderValueAdded == (int)CountStandard.BaseCumulativeNCF)
        {
            currentScore = Score.B;
            scoreText.text = "B";
            scoreDescriptionText.text = "Sayang sekali, tidak ada perubahan dari inisiatif yang Anda buat";
            imgA.SetActive(false);
            imgB.SetActive(true);
        }
    }
}
