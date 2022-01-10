using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

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
    public bool opmR, fixR, capR,salesR;
    public TextMeshProUGUI nonRealistic, underLineRealistic;

    private void Start()
    {

        //DontDestroyOnLoad(gameObject);
        currentScore = Score.A;
        scoreText.text = "A";
        scoreDescriptionText.text = "SELAMAT..!!! Anda berhasil meningkatkan nilai perusahaan dari "+ (int)CountStandard.BaseCumulativeNCF + ". menjadi " +(int) BusinessValueAndShareholderValue.shareholderValueAdded +  ".";
        if (ValueDrivers.OperatingProfitMargin > (BoundariesData.Realistic_OPM + 0.001f) || ValueDrivers.IncrementalFixedCapitalInvestment < BoundariesData.Realistic_Inc_FC - 0.001f || ValueDrivers.IncrementalWorkingCapitalInvestment < BoundariesData.Realistic_Inc_WC - 0.001f || OperatingCashFlowsForecasts.NetCashFlows_FreeCashFlows.CummulativePresentValueNCF.BaseFigures < 0)
        {
            currentScore = Score.C;
            scoreText.text = "C";
            scoreDescriptionText.text = "Inisiatif Anda tidak realistis (Penjelasan pada halaman berikutnya)";
            if (ValueDrivers.OperatingProfitMargin > (BoundariesData.Realistic_OPM + 0.001f))
            {
                opmR = true;

            }

            if (ValueDrivers.IncrementalFixedCapitalInvestment < BoundariesData.Realistic_Inc_FC - 0.001f)
            {
                fixR = true;
            }

            if (ValueDrivers.IncrementalWorkingCapitalInvestment < BoundariesData.Realistic_Inc_WC - 0.001f)
            {
                capR = true;
            }

            if(OperatingCashFlowsForecasts.NetCashFlows_FreeCashFlows.CummulativePresentValueNCF.BaseFigures < 0)
            {
                salesR = true;
            }
            scoreDescriptionText.text += ".";
            imgA.SetActive(false);
            imgC.SetActive(true);
        }
        else if(BusinessValueAndShareholderValue.shareholderValueAdded < (int)CountStandard.BaseCumulativeNCF)
        {
            currentScore = Score.B;
            scoreText.text = "B";
            scoreDescriptionText.text = "Sayang sekali, inisiatif Anda menurunkan nilai perusahaan dari " + (int)CountStandard.BaseCumulativeNCF + ". menjadi " + (int)BusinessValueAndShareholderValue.shareholderValueAdded + ".";
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

        if(SceneManager.GetActiveScene().name == "ScoringSS")
        {
            if (BusinessValueAndShareholderValue.shareholderValueAdded > (int)CountStandard.BaseCumulativeNCF)
            {
                nonRealistic.text = "SELAMAT..!!! Anda berhasil meningkatkan nilai perusahaan dari " + (int)CountStandard.BaseCumulativeNCF + ". menjadi " + (int)BusinessValueAndShareholderValue.shareholderValueAdded + ".";
            }
            if (BusinessValueAndShareholderValue.shareholderValueAdded < (int)CountStandard.BaseCumulativeNCF)
            {
                nonRealistic.text = "Sayang sekali, inisiatif Anda menurunkan nilai perusahaan dari " + (int)CountStandard.BaseCumulativeNCF + ". menjadi " + (int)BusinessValueAndShareholderValue.shareholderValueAdded + ".";

            }
            if ((int)BusinessValueAndShareholderValue.shareholderValueAdded == (int)CountStandard.BaseCumulativeNCF)
            {
                nonRealistic.text = "Sayang sekali, tidak ada perubahan dari inisiatif yang Anda buat";
            }
            if (ValueDrivers.OperatingProfitMargin > (BoundariesData.Realistic_OPM + 0.001f) || ValueDrivers.IncrementalFixedCapitalInvestment < BoundariesData.Realistic_Inc_FC - 0.001f || ValueDrivers.IncrementalWorkingCapitalInvestment < BoundariesData.Realistic_Inc_WC - 0.001f || OperatingCashFlowsForecasts.NetCashFlows_FreeCashFlows.CummulativePresentValueNCF.BaseFigures < 0)
            {
                nonRealistic.text = "";
                if (salesR || opmR || fixR || capR)
                {
                    underLineRealistic.gameObject.SetActive(true);
                }
                if (salesR)
                {
                    nonRealistic.text += "- Cummulative PV of Net Cash Flows mencapai " + OperatingCashFlowsForecasts.NetCashFlows_FreeCashFlows.CummulativePresentValueNCF.BaseFigures.ToString("F2") + "\n";
                }
                if (opmR)
                {
                    nonRealistic.text += "- Operating Profit Margin melebihi batas wajar\n";
                }

                if (fixR)
                {
                    nonRealistic.text += "- Incremental Fixed Capital dibawah batas wajar\n";
                }

                if (capR)
                {
                    nonRealistic.text += "- Incremental Working Capital dibawah batas wajar\n";
                }
            }
        }
    }
}
