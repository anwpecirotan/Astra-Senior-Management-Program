using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class ValueCreationInput : MonoBehaviour
{
    public Slider SalesGrowthRateSlider;
    public Slider OperatingProfitMarginSlider;
    public Slider CashTaxRateSlider;
    public Slider IncrementalFixedCapitalInvestmentSlider;
    public Slider IncrementalWorkingCapitalInvestmentSlider;
    public Slider CostofCapitalSlider;
    public TMP_InputField PlanningPeriod_YearsSlider;

    public TextMeshProUGUI SalesGrowthRateText;
    public TextMeshProUGUI OperatingProfitMarginText;
    public TextMeshProUGUI CashTaxRateText;
    public TextMeshProUGUI IncrementalFixedCapitalInvestmentText;
    public TextMeshProUGUI IncrementalWorkingCapitalInvestmentText;
    public TextMeshProUGUI CostofCapitalText;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {

        SalesGrowthRateText.text =Mathf.Round(SalesGrowthRateSlider.value *100) + " %";
        OperatingProfitMarginText.text = Mathf.Round(OperatingProfitMarginSlider.value * 100)  + " %";
        CashTaxRateText.text = Mathf.Round(CashTaxRateSlider.value * 100)  + " %";
        IncrementalFixedCapitalInvestmentText.text = Mathf.Round(IncrementalFixedCapitalInvestmentSlider.value * 100)  + " %";
        IncrementalWorkingCapitalInvestmentText.text = Mathf.Round(IncrementalWorkingCapitalInvestmentSlider.value * 100)  + " %";
        CostofCapitalText.text = Mathf.Round(CostofCapitalSlider.value * 100) + " %";

    }

    public void Submit()
    {
        ValueDrivers.SalesGrowthRate = SalesGrowthRateSlider.value;
        ValueDrivers.OperatingProfitMargin = OperatingProfitMarginSlider.value;
        ValueDrivers.CashTaxRate = CashTaxRateSlider.value;
        ValueDrivers.IncrementalFixedCapitalInvestment = IncrementalFixedCapitalInvestmentSlider.value;
        ValueDrivers.IncrementalWorkingCapitalInvestment = IncrementalWorkingCapitalInvestmentSlider.value;
        ValueDrivers.CostofCapital = CostofCapitalSlider.value;
        ValueDrivers.PlanningPeriod_Years = int.Parse(PlanningPeriod_YearsSlider.text);
    }
}
