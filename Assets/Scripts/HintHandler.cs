using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class HintHandler : MonoBehaviour
{
    public TextMeshProUGUI firstPageTop;
    public TextMeshProUGUI firstPageBottom;
    public TextMeshProUGUI secondPage;
    public TextMeshProUGUI thirdPage;
    public TextMeshProUGUI fourthPage;
    // Start is called before the first frame update
    void Start()
    {
        firstPageTop.text = "Berikut ini disajikan Neraca dan Penghasilan terbaru laporan sebuah perusahaan " +TemplateData.CompanyName +" di Indonesia";
        firstPageBottom.text = "Secara historis, perusahaan telah mengalami pertumbuhan rata-rata " + TemplateData.ValueDriver_SalesGrowthRate * 100 + "% per tahun, margin laba operasionalnya rata-rata selama " + TemplateData.ValueDriver_PlanningPeriod_Years + " tahun terakhir adalah " + TemplateData.ValueDriver_OperatingProfitMargin * 100 + "%. ";
        secondPage.text = "Tarif pajak tunai perusahaan adalah "+TemplateData.ValueDriver_CashTaxRate*100+"%, dan dengan struktur modal saat ini, biaya rata-rata modal tertimbang (WACC) adalah "+TemplateData.WACC_Baseline*100+"%. Investasi dalam Modal Tetap dan Modal Kerja juga berdasarkan catatan sejarah masing-masing sebesar "+TemplateData.ValueDriver_IncrementalFixedCapitalInvestment*100+"% dan "+TemplateData.ValueDriver_IncrementalWorkingCapitalInvestment*100+"% dari penjualan tambahan.";
        thirdPage.text = "ROE perusahaan saat ini adalah "+ System.Math.Round(KeyFigures.ROE*100,2)+"% dan rasio utang terhadap ekuitas adalah "+ System.Math.Round(KeyFigures.debtOfEquityRatio*100, 2) + "%, yang relatif sehat.";
        fourthPage.text = "IGR adalah gambaran dari kapasitas perusahaan untuk tumbuh dengan menggunakan dana internal (tidak ada pinjaman atau ekuitas tambahan). Berdasarkan angka terbaru, IGR perusahaan adalah "+ System.Math.Round(KeyFigures.IGR*100,2)+"%.";
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
