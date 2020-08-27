using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HintHandler : MonoBehaviour
{
    public TextMeshProUGUI firstPageTop;
    public TextMeshProUGUI secara2, tarif3, roe4, igr5, sgr6,sgr62,dengan7;
    // Start is called before the first frame update
    void Start()
    {
        
        firstPageTop.text = "Berikut ini disajikan Neraca dan Penghasilan terbaru laporan sebuah perusahaan "
            +TemplateData.CompanyName +" di Indonesia";
     
        secara2.text = "Secara historis, perusahaan telah mengalami pertumbuhan rata-rata "
               + TemplateData.ValueDriver_SalesGrowthRate * 100 +
               "% per tahun, Margin laba usaha rata-rata selama "
               + TemplateData.ValueDriver_PlanningPeriod_Years + " tahun terakhir adalah "
               + TemplateData.ValueDriver_OperatingProfitMargin * 100 + "%. "
               + "\n\nDibandingkan dengan industri, tingkat pertumbuhan perusa-haan dan margin laba operasi " +
               "sedikit di bawah rata-rata industri masing-masing" + " 10% dan 9%."; // Ini apaan woy

        tarif3.text = "Tarif pajak tunai perusahaan adalah " +
            TemplateData.ValueDriver_CashTaxRate * 100 + "%," +
            " dan dengan stru-ktur permodalan saat ini,biaya rata-rata tertimbang modal (WACC) perusahaan sebesar "
            + TemplateData.WACC_Baseline * 100 + "%." +
            "\n\nInvestasi dalam Modal Tetap dan Modal Kerja juga ber-dasarkan catatan sejarah masing-masing adalah "
            + TemplateData.ValueDriver_IncrementalFixedCapitalInvestment * 100 + "% " +
            "dan "
            + TemplateData.ValueDriver_IncrementalWorkingCapitalInvestment * 100 + "%" +
            " dari penjualan tambahan.";

        roe4.text = "ROE perusahaan saat ini adalah "
            + System.Math.Round(KeyFigures.ROE * 100, 1) + "%" +
            " dan rasio utang terhadap ekuitas sebesar "
            + System.Math.Round(KeyFigures.debtOfEquityRatio * 100, 2) + "%" +
            ", yang relatif sehat." +
            "\n\nDPO merupakan kebijakan perusahaan tentang pembayaran dividen yang mencerminkan" +
            " persentase laba tahun berjalan yang dibayarkan sebagai dividen yaitu " +
            KeyFigures.DPO * 100 + "% " +
            "dari Laba Bersih. Rasio laba ditahan adalah persentase laba bersih tahun berjalan yang ditahan di perusahaan.";

        igr5.text = "IGR adalah cerminan dari kapasitas perusahaan untuk tumbuh dengan menggunakan dana internal" +
            " (tidak ada pinjaman atau ekuitas tambahan)." +
            " Berdasarkan angka terakhir IGR perusahaan sebesar " +
            (KeyFigures.IGR * 100).ToString("F1") + "%";

        sgr6.text = "SGR adalah tingkat pertumbuhan berkelanjutan perusahaan yaitu " +
            (KeyFigures.SGR * 100).ToString("F1") + "% " +
            "Artinya, perusahaan dapat tumbuh hingga " +
            TemplateData.WACC_Baseline * 100 + "%" +
            " tanpa memengaruhi rasio utang terhadap ekuitas.";
            
        sgr62.text =  "Oleh karena itu," +
            " manajemen merasa bahwa jika perusahaan tumbuh dalam SGR-nya, WACC " +
            "(biaya modal rata-rata tertimbang) akan tetap sama.\n\nManajemen memperkirakan dengan setiap kenaikan " +
            BoundariesData.Factor_of_Sales_Growth * 100 + "%" +
            " dari SGR-nya, WACC akan meningkat " +
            TemplateData.Impact_on_WACC * 100 + "%";

        dengan7.text = "Dengan pertimbangan bahwa salah satu tujuan utama perusahaan adalah untuk “memaksimalkan nilai pemegang saham”, " +
            "maka manajemen harus memutuskan bagaimana melanjutkan strategi bisnisnya selama " +
            TemplateData.ValueDriver_PlanningPeriod_Years +
            " tahun ke depan, dengan memperhatikan key value driver yang disajikan.";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
