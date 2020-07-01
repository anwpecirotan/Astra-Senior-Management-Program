using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ValueCreationInput : MonoBehaviour
{
    public Slider SalesGrowthRateSlider;
    public Slider OperatingProfitMarginSlider;
    public Slider IncrementalFixedCapitalInvestmentSlider;
    public Slider IncrementalWorkingCapitalInvestmentSlider;

    public TextMeshProUGUI SalesGrowthRateText;
    public TextMeshProUGUI OperatingProfitMarginText;
    public TextMeshProUGUI IncrementalFixedCapitalInvestmentText;
    public TextMeshProUGUI IncrementalWorkingCapitalInvestmentText;
    // Start is called before the first frame update
    void Start()
    {
        SalesGrowthRateSlider.value = (float)TemplateData.ValueDriver_SalesGrowthRate * 200;
        OperatingProfitMarginSlider.value = (float)TemplateData.ValueDriver_OperatingProfitMargin * 200;
        IncrementalFixedCapitalInvestmentSlider.value = (float)TemplateData.ValueDriver_IncrementalFixedCapitalInvestment * 200;
        IncrementalWorkingCapitalInvestmentSlider.value = (float)TemplateData.ValueDriver_IncrementalWorkingCapitalInvestment * 200;
    }

    // Update is called once per frame
    void Update()
    {

        SalesGrowthRateText.text = System.Math.Round(SalesGrowthRateSlider.value /2 , 1) + " %";
        OperatingProfitMarginText.text = System.Math.Round(OperatingProfitMarginSlider.value / 2, 1)  + " %";
        IncrementalFixedCapitalInvestmentText.text = System.Math.Round(IncrementalFixedCapitalInvestmentSlider.value / 2, 1)  + " %";
        IncrementalWorkingCapitalInvestmentText.text = System.Math.Round(IncrementalWorkingCapitalInvestmentSlider.value / 2, 1)  + " %";
    }

    public void Submit()
    {
        ValueDrivers.SalesGrowthRate = SalesGrowthRateSlider.value / 200;
        ValueDrivers.OperatingProfitMargin = OperatingProfitMarginSlider.value / 200;
        ValueDrivers.IncrementalFixedCapitalInvestment = IncrementalFixedCapitalInvestmentSlider.value / 200;
        ValueDrivers.IncrementalWorkingCapitalInvestment = IncrementalWorkingCapitalInvestmentSlider.value / 200;
    }
}
