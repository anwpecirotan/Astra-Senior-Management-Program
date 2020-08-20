using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;

public class ValueCreationInput : MonoBehaviour
{
    public Slider SalesGrowthRateSlider;
    

    public Slider OperatingProfitMarginSlider;
    public Slider IncrementalFixedCapitalInvestmentSlider;
    public Slider IncrementalWorkingCapitalInvestmentSlider;
    public Slider WACCSlider;
    public Slider TaxSlider;

    public TextMeshProUGUI SalesGrowthRateText;
    public TextMeshProUGUI OperatingProfitMarginText;
    public TextMeshProUGUI IncrementalFixedCapitalInvestmentText;
    public TextMeshProUGUI IncrementalWorkingCapitalInvestmentText;
    public TextMeshProUGUI WACCText;
    public TextMeshProUGUI TaxText;
    // Start is called before the first frame update
    void Start()
    {
        ValueDrivers.SalesGrowthRate = 0;
        ValueDrivers.OperatingProfitMargin = 0;
        ValueDrivers.IncrementalFixedCapitalInvestment = 0;
        ValueDrivers.IncrementalWorkingCapitalInvestment = 0;

        SalesGrowthRateSlider.value = (float)TemplateData.ValueDriver_SalesGrowthRate * 200;
        OperatingProfitMarginSlider.value = (float)TemplateData.ValueDriver_OperatingProfitMargin * 200;
        IncrementalFixedCapitalInvestmentSlider.value = (float)TemplateData.ValueDriver_IncrementalFixedCapitalInvestment * 200;
        IncrementalWorkingCapitalInvestmentSlider.value = (float)TemplateData.ValueDriver_IncrementalWorkingCapitalInvestment * 200;
        WACCSlider.value = (float)BoundariesData.WACC * 200;
        TaxSlider.value = (float)TemplateData.ValueDriver_CashTaxRate * 200;
    }

    // Update is called once per frame
    void Update()
    {
        ValueDrivers.SalesGrowthRate = SalesGrowthRateSlider.value / 200;
        WACCSlider.value = (float)BoundariesData.WACC * 200;
        SalesGrowthRateText.text = System.Math.Round(SalesGrowthRateSlider.value /2 , 1) + " %";
        OperatingProfitMarginText.text = System.Math.Round(OperatingProfitMarginSlider.value / 2, 1)  + " %";
        IncrementalFixedCapitalInvestmentText.text = System.Math.Round(IncrementalFixedCapitalInvestmentSlider.value / 2, 1)  + " %";
        IncrementalWorkingCapitalInvestmentText.text = System.Math.Round(IncrementalWorkingCapitalInvestmentSlider.value / 2, 1)  + " %";
        WACCText.text = System.Math.Round(WACCSlider.value / 2, 1)  + " %";
        TaxText.text = System.Math.Round(TaxSlider.value / 2, 1)  + " %";
        //Debug.Log(ValueDrivers.SalesGrowthRate);
    }

  

    public void Submit()
    {
        ValueDrivers.SalesGrowthRate = SalesGrowthRateSlider.value / 200;
        ValueDrivers.OperatingProfitMargin = OperatingProfitMarginSlider.value / 200;
        ValueDrivers.IncrementalFixedCapitalInvestment = IncrementalFixedCapitalInvestmentSlider.value / 200;
        ValueDrivers.IncrementalWorkingCapitalInvestment = IncrementalWorkingCapitalInvestmentSlider.value / 200;
    }
}
