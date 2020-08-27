using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class NarationEditor : MonoBehaviour
{
    public TextMeshProUGUI secara2,tarif3,roe4,igr5,sgr6,dengan7;
    public void _OnButtonNextNarration()
    {
        gameObject.SetActive(false);
    }

    private void Start()
    {
        StartupText();

        print("Retained Earning Ratio : " + KeyFigures.retainEarningRatio);
        print("ROE : " + KeyFigures.ROE);
        print("Retained Earnings : " + LiabilitiesandOwnersEquity.ProfitandLossStatement.RE_RetainedEarnings);
        print("Total Assets : " + LiabilitiesandOwnersEquity.TotalAssets.totalAssets);
        print("Net Profit Retained : " + LiabilitiesandOwnersEquity.ProfitandLossStatement.RE_RetainedEarnings);
        print("EAT : " + LiabilitiesandOwnersEquity.ProfitandLossStatement.EAT_EarningsAfterTax);
        print("Dividend : " + LiabilitiesandOwnersEquity.ProfitandLossStatement.Dividend);
        print("DPO : " + KeyFigures.DPO);
    }

    private void Update()
    {
        
    }
    private void StartupText()
    {
        secara2.text = "Secara historis, perusahaan telah mengalami pertumbuhan rata-rata " 
            + TemplateData.ValueDriver_SalesGrowthRate * 100 + 
            "% per tahun, Margin laba usaha rata-rata selama " 
            + TemplateData.ValueDriver_PlanningPeriod_Years + " tahun terakhir adalah " 
            + TemplateData.ValueDriver_OperatingProfitMargin * 100 + "%. "
            + "Dibandingkan dengan industri, tingkat pertumbuhan perusahaan dan margin laba operasi " +
            "sedikit di bawah rata-rata industri masing-masing"+ " 10% dan 9%."; // Ini apaan woy

        tarif3.text = "Tarif pajak tunai perusahaan adalah " + 
            TemplateData.ValueDriver_CashTaxRate * 100 + "%," +
            " dan dengan struktur permodalan saat ini,biaya rata-rata tertimbang modal (WACC) perusahaan sebesar "
            + TemplateData.WACC_Baseline * 100 + "%." +
            "Investasi dalam Modal Tetap dan Modal Kerja juga berdasarkan catatan sejarah masing-masing adalah "
            + TemplateData.ValueDriver_IncrementalFixedCapitalInvestment * 100 + "% " +
            "dan "
            + TemplateData.ValueDriver_IncrementalWorkingCapitalInvestment * 100 + "%" +
            " dari penjualan tambahan.";

        roe4.text = "ROE perusahaan saat ini adalah " 
            + System.Math.Round(KeyFigures.ROE * 100, 1) + "%" +
            " dan rasio utang terhadap ekuitas sebesar "
            + System.Math.Round(KeyFigures.debtOfEquityRatio * 100, 2) + "%" +
            ", yang relatif sehat."+
            "\nDPO merupakan kebijakan perusahaan tentang pembayaran dividen yang mencerminkan" +
            " persentase laba tahun berjalan yang dibayarkan sebagai dividen yaitu " +
            (KeyFigures.DPO*100) + "% " +
            "dari Laba Bersih. Rasio laba ditahan adalah persentase laba bersih tahun berjalan yang ditahan di perusahaan.";

        igr5.text = "IGR adalah cerminan dari kapasitas perusahaan untuk tumbuh dengan menggunakan dana internal" +
            " (tidak ada pinjaman atau ekuitas tambahan)." +
            " Berdasarkan angka terakhir IGR perusahaan sebesar " +
           (KeyFigures.IGR * 100).ToString("F2")+ "%";
           

        sgr6.text = "SGR adalah tingkat pertumbuhan berkelanjutan perusahaan yaitu " +
            (KeyFigures.SGR * 100).ToString("F1") + "% "  +
            "Artinya, perusahaan dapat tumbuh hingga " +
            TemplateData.WACC_Baseline * 100 + "%" +
            " tanpa memengaruhi rasio utang terhadap ekuitas. Oleh karena itu," +
            " manajemen merasa bahwa jika perusahaan tumbuh dalam SGR-nya, WACC " +
            "(biaya modal rata-rata tertimbang) akan tetap sama. Manajemen memperkirakan dengan setiap kenaikan " +
            BoundariesData.Factor_of_Sales_Growth * 100 +"%" +
            " dari SGR-nya, WACC akan meningkat " +
            TemplateData.Impact_on_WACC * 100 + "%";

        dengan7.text = "Dengan pertimbangan bahwa salah satu tujuan utama perusahaan adalah untuk “memaksimalkan nilai pemegang saham”, " +
            "maka manajemen harus memutuskan bagaimana melanjutkan strategi bisnisnya selama " +
            TemplateData.ValueDriver_PlanningPeriod_Years +
            " tahun ke depan, dengan memperhatikan key value driver yang disajikan.";

    }
}
