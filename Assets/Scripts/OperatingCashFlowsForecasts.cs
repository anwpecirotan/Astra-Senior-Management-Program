using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class OperatingCashFlowsForecasts : MonoBehaviour
{
    public class Operations
    {
        public class Sales
        {
            public static double BaseFigures = LiabilitiesandOwnersEquity.ProfitandLossStatement.Sales;
            public static double ForecastPeriodYear1 = BaseFigures * (1 + (ValueDrivers.SalesGrowthRate));
            //public static double ForecastPeriodYear2 = ForecastPeriodYear1 * (1 + (ValueDrivers.SalesGrowthRate * 100));
            //public static double ForecastPeriodYear3 = ForecastPeriodYear2 * (1 + (ValueDrivers.SalesGrowthRate * 100));
            //public static double ForecastPeriodYear4 = ForecastPeriodYear3 * (1 + (ValueDrivers.SalesGrowthRate * 100));
            //public static double ForecastPeriodYear5 = ForecastPeriodYear4 * (1 + (ValueDrivers.SalesGrowthRate * 100));
        }

        public class OperatingProfitMargin
        {
            public static double BaseFigures = Sales.BaseFigures * ValueDrivers.OperatingProfitMargin;
            public static double ForecastPeriodYear1 = Sales.ForecastPeriodYear1 * ValueDrivers.OperatingProfitMargin;
            //public static double ForecastPeriodYear2 = Sales.ForecastPeriodYear2 * ValueDrivers.OperatingProfitMargin;
            //public static double ForecastPeriodYear3 = Sales.ForecastPeriodYear3 * ValueDrivers.OperatingProfitMargin;
            //public static double ForecastPeriodYear4 = Sales.ForecastPeriodYear4 * ValueDrivers.OperatingProfitMargin;
            //public static double ForecastPeriodYear5 = Sales.ForecastPeriodYear5 * ValueDrivers.OperatingProfitMargin;
        }

        public class Tax25Percent
        {
            public static double ForecastPeriodYear1 = OperatingProfitMargin.ForecastPeriodYear1 * ValueDrivers.CashTaxRate;
            //public static double ForecastPeriodYear2 = OperatingProfitMargin.ForecastPeriodYear2 * ValueDrivers.CashTaxRate;
            //public static double ForecastPeriodYear3 = OperatingProfitMargin.ForecastPeriodYear3 * ValueDrivers.CashTaxRate;
            //public static double ForecastPeriodYear4 = OperatingProfitMargin.ForecastPeriodYear4 * ValueDrivers.CashTaxRate;
            //public static double ForecastPeriodYear5 = OperatingProfitMargin.ForecastPeriodYear5 * ValueDrivers.CashTaxRate;
        }

        public class NetOperatingProfitAfterTAX_NOPAT
        {
            public static double ForecastPeriodYear1 = OperatingProfitMargin.ForecastPeriodYear1 - Tax25Percent.ForecastPeriodYear1;
            //public static double ForecastPeriodYear2 = OperatingProfitMargin.ForecastPeriodYear2 - Tax25Percent.ForecastPeriodYear2;
            //public static double ForecastPeriodYear3 = OperatingProfitMargin.ForecastPeriodYear3 - Tax25Percent.ForecastPeriodYear3;
            //public static double ForecastPeriodYear4 = OperatingProfitMargin.ForecastPeriodYear4 - Tax25Percent.ForecastPeriodYear4;
            //public static double ForecastPeriodYear5 = OperatingProfitMargin.ForecastPeriodYear5 - Tax25Percent.ForecastPeriodYear5;
        }
    }

    public class CapitalInvestments_FixedAssets
    {
        public class Balance
        {
            public static double BaseFigures = KeyFigures.FixedAssets;
            public static double ForecastPeriodYear1 = Operations.Sales.ForecastPeriodYear1 * ValueDrivers.IncrementalFixedCapitalInvestment;
            //public static double ForecastPeriodYear2 = Operations.Sales.ForecastPeriodYear2 * ValueDrivers.IncrementalFixedCapitalInvestment;
            //public static double ForecastPeriodYear3 = Operations.Sales.ForecastPeriodYear3 * ValueDrivers.IncrementalFixedCapitalInvestment;
            //public static double ForecastPeriodYear4 = Operations.Sales.ForecastPeriodYear4 * ValueDrivers.IncrementalFixedCapitalInvestment;
            //public static double ForecastPeriodYear5 = Operations.Sales.ForecastPeriodYear5 * ValueDrivers.IncrementalFixedCapitalInvestment;
        }

        public class CashFlows
        {
            public static double ForecastPeriodYear1 = Balance.BaseFigures - Balance.ForecastPeriodYear1;
            //public static double ForecastPeriodYear2 = Balance.ForecastPeriodYear1 - Balance.ForecastPeriodYear2;
            //public static double ForecastPeriodYear3 = Balance.ForecastPeriodYear2 - Balance.ForecastPeriodYear3;
            //public static double ForecastPeriodYear4 = Balance.ForecastPeriodYear3 - Balance.ForecastPeriodYear4;
            //public static double ForecastPeriodYear5 = Balance.ForecastPeriodYear4 - Balance.ForecastPeriodYear5;
        }
    }

    public class NetWorkingCapitalInvestments
    {
        public class Balance
        {
            public static double BaseFigures = KeyFigures.NWC;
            public static double ForecastPeriodYear1 = Operations.Sales.ForecastPeriodYear1 * ValueDrivers.IncrementalWorkingCapitalInvestment;
            //public static double ForecastPeriodYear2 = Operations.Sales.ForecastPeriodYear2 * ValueDrivers.IncrementalWorkingCapitalInvestment;
            //public static double ForecastPeriodYear3 = Operations.Sales.ForecastPeriodYear3 * ValueDrivers.IncrementalWorkingCapitalInvestment;
            //public static double ForecastPeriodYear4 = Operations.Sales.ForecastPeriodYear4 * ValueDrivers.IncrementalWorkingCapitalInvestment;
            //public static double ForecastPeriodYear5 = Operations.Sales.ForecastPeriodYear5 * ValueDrivers.IncrementalWorkingCapitalInvestment;
        }

        public class CashFlows
        {
            public static double ForecastPeriodYear1 = Balance.BaseFigures - Balance.ForecastPeriodYear1;
            //public static double ForecastPeriodYear2 = Balance.ForecastPeriodYear1 - Balance.ForecastPeriodYear2;
            //public static double ForecastPeriodYear3 = Balance.ForecastPeriodYear2 - Balance.ForecastPeriodYear3;
            //public static double ForecastPeriodYear4 = Balance.ForecastPeriodYear3 - Balance.ForecastPeriodYear4;
            //public static double ForecastPeriodYear5 = Balance.ForecastPeriodYear4 - Balance.ForecastPeriodYear5;
        }
    }

    public class NetCashFlows_FreeCashFlows
    {
        public static double ForecastPeriodYear1 = Operations.NetOperatingProfitAfterTAX_NOPAT.ForecastPeriodYear1 + 
                                                   CapitalInvestments_FixedAssets.CashFlows.ForecastPeriodYear1 +
                                                   NetWorkingCapitalInvestments.CashFlows.ForecastPeriodYear1;
        //public static double ForecastPeriodYear2 = Operations.NetOperatingProfitAfterTAX_NOPAT.ForecastPeriodYear2 +
        //                                           CapitalInvestments_FixedAssets.CashFlows.ForecastPeriodYear2 +
        //                                           NetWorkingCapitalInvestments.CashFlows.ForecastPeriodYear2;
        //public static double ForecastPeriodYear3 = Operations.NetOperatingProfitAfterTAX_NOPAT.ForecastPeriodYear3 +
        //                                           CapitalInvestments_FixedAssets.CashFlows.ForecastPeriodYear3 +
        //                                           NetWorkingCapitalInvestments.CashFlows.ForecastPeriodYear3;
        //public static double ForecastPeriodYear4 = Operations.NetOperatingProfitAfterTAX_NOPAT.ForecastPeriodYear4 +
        //                                           CapitalInvestments_FixedAssets.CashFlows.ForecastPeriodYear4 +
        //                                           NetWorkingCapitalInvestments.CashFlows.ForecastPeriodYear4;
        //public static double ForecastPeriodYear5 = Operations.NetOperatingProfitAfterTAX_NOPAT.ForecastPeriodYear5 +
        //                                           CapitalInvestments_FixedAssets.CashFlows.ForecastPeriodYear5 +
        //                                           NetWorkingCapitalInvestments.CashFlows.ForecastPeriodYear5;

        public class PresentValueFactor
        {
            public static double BaseFigures = BoundariesData.WACC;
            public static double ForecastPeriodYear1 = 1 / (1 + BaseFigures);
            //public static double ForecastPeriodYear2 = ForecastPeriodYear1 / (1 + BaseFigures);
            //public static double ForecastPeriodYear3 = ForecastPeriodYear2 / (1 + BaseFigures);
            //public static double ForecastPeriodYear4 = ForecastPeriodYear3 / (1 + BaseFigures);
            //public static double ForecastPeriodYear5 = ForecastPeriodYear4 / (1 + BaseFigures);
        }

        public class PresentValueOfNetCashFlows
        {
            public static double ForecastPeriodYear1 = NetCashFlows_FreeCashFlows.ForecastPeriodYear1 * NetCashFlows_FreeCashFlows.PresentValueFactor.ForecastPeriodYear1;
            //public static double ForecastPeriodYear2 = NetCashFlows_FreeCashFlows.ForecastPeriodYear2 * NetCashFlows_FreeCashFlows.PresentValueFactor.ForecastPeriodYear2;
            //public static double ForecastPeriodYear3 = NetCashFlows_FreeCashFlows.ForecastPeriodYear3 * NetCashFlows_FreeCashFlows.PresentValueFactor.ForecastPeriodYear3;
            //public static double ForecastPeriodYear4 = NetCashFlows_FreeCashFlows.ForecastPeriodYear4 * NetCashFlows_FreeCashFlows.PresentValueFactor.ForecastPeriodYear4;
            //public static double ForecastPeriodYear5 = NetCashFlows_FreeCashFlows.ForecastPeriodYear5 * NetCashFlows_FreeCashFlows.PresentValueFactor.ForecastPeriodYear5;
        }

        public class CummulativePresentValueNCF
        {
            public static double BaseFigures = PresentValueOfNetCashFlows.ForecastPeriodYear1;
            //                                     + PresentValueOfNetCashFlows.ForecastPeriodYear2 +
            //                                   PresentValueOfNetCashFlows.ForecastPeriodYear3 + PresentValueOfNetCashFlows.ForecastPeriodYear4 +
            //                                   PresentValueOfNetCashFlows.ForecastPeriodYear5;
        }

        public class ContinuingValue
        {
            public class NetOperatingProfitAfterTax_NOPAT
            {
                public static double ForecastPeriodYear1 = Operations.NetOperatingProfitAfterTAX_NOPAT.ForecastPeriodYear1;
                //public static double ForecastPeriodYear2 = Operations.NetOperatingProfitAfterTAX_NOPAT.ForecastPeriodYear2;
                //public static double ForecastPeriodYear3 = Operations.NetOperatingProfitAfterTAX_NOPAT.ForecastPeriodYear3;
                //public static double ForecastPeriodYear4 = Operations.NetOperatingProfitAfterTAX_NOPAT.ForecastPeriodYear4;
                //public static double ForecastPeriodYear5 = Operations.NetOperatingProfitAfterTAX_NOPAT.ForecastPeriodYear5;
            }

            public static double BaseFigures = BoundariesData.WACC;
            public static double ForecastPeriodYear1 = NetOperatingProfitAfterTax_NOPAT.ForecastPeriodYear1 / BaseFigures;
            //public static double ForecastPeriodYear2 = NetOperatingProfitAfterTax_NOPAT.ForecastPeriodYear2 / BaseFigures;
            //public static double ForecastPeriodYear3 = NetOperatingProfitAfterTax_NOPAT.ForecastPeriodYear3 / BaseFigures;
            //public static double ForecastPeriodYear4 = NetOperatingProfitAfterTax_NOPAT.ForecastPeriodYear4 / BaseFigures;
            //public static double ForecastPeriodYear5 = NetOperatingProfitAfterTax_NOPAT.ForecastPeriodYear5 / BaseFigures;
        }

        public class PVofContinuingValue
        {
            //public static double BaseFigures = ContinuingValue.ForecastPeriodYear5 * PresentValueFactor.ForecastPeriodYear5;
            public static double BaseFigures = 0;
        }
    }

    public TextMeshProUGUI BaseSalesText, BaseOperatingProfitText, BaseCIBalanceText, BaseNWCBalanceText;
    public TextMeshProUGUI BasePresentValueText, BaseCumulativeNCFText, BaseContinuingValueText, BasePVContinuingText;

    private int FirstSales, FirstOperatingProfit, FirstTax, FirstNOPAT, FirstCIBalance, FirstCICashFlow;
    private int FirstNWCBalance, FirstNWCCashFlow, FirstContinueNOPAT;
    private double FirstPresentValueCashFlow, FirstPresentValue, FirstFreeCashFlow, FirstContinuingValue;
    public static double BaseCumulativeNCF;
    public static int EndPeriodNOPAT;
    public static double StandardCumulativeNCF;

    public GameObject ForecastPeriodYear,content,changeable;

    void Start()
    {
        BaseCumulativeNCF = 0;
        StandardCumulativeNCF = 0;

        FirstSales = 0;
        FirstTax = 0;
        FirstNOPAT = 0;
        FirstCIBalance = 0;
        FirstCICashFlow = 0;
        FirstNWCBalance = 0;
        FirstNWCCashFlow = 0;
        FirstContinueNOPAT = 0;
        FirstPresentValueCashFlow = 0;
        FirstPresentValue = 0;
        FirstFreeCashFlow = 0;
        FirstContinuingValue = 0;

        Operations.Sales.BaseFigures = LiabilitiesandOwnersEquity.ProfitandLossStatement.Sales;
        Operations.Sales.ForecastPeriodYear1 = Operations.Sales.BaseFigures * (1 + (ValueDrivers.SalesGrowthRate));
        Operations.OperatingProfitMargin.BaseFigures = LiabilitiesandOwnersEquity.ProfitandLossStatement.Sales * ValueDrivers.OperatingProfitMargin;
        Operations.OperatingProfitMargin.ForecastPeriodYear1 = Operations.Sales.ForecastPeriodYear1 * ValueDrivers.OperatingProfitMargin;
        Operations.Tax25Percent.ForecastPeriodYear1 = Operations.OperatingProfitMargin.ForecastPeriodYear1 * ValueDrivers.CashTaxRate;
        Operations.NetOperatingProfitAfterTAX_NOPAT.ForecastPeriodYear1 = Operations.OperatingProfitMargin.ForecastPeriodYear1 - Operations.Tax25Percent.ForecastPeriodYear1;

        CapitalInvestments_FixedAssets.Balance.BaseFigures = KeyFigures.FixedAssets;
        CapitalInvestments_FixedAssets.Balance.ForecastPeriodYear1 = Operations.Sales.ForecastPeriodYear1 * ValueDrivers.IncrementalFixedCapitalInvestment;
        CapitalInvestments_FixedAssets.CashFlows.ForecastPeriodYear1 = CapitalInvestments_FixedAssets.Balance.BaseFigures - CapitalInvestments_FixedAssets.Balance.ForecastPeriodYear1;

        NetWorkingCapitalInvestments.Balance.BaseFigures = KeyFigures.NWC;
        NetWorkingCapitalInvestments.Balance.ForecastPeriodYear1 = Operations.Sales.ForecastPeriodYear1 * ValueDrivers.IncrementalWorkingCapitalInvestment;
        NetWorkingCapitalInvestments.CashFlows.ForecastPeriodYear1 = NetWorkingCapitalInvestments.Balance.BaseFigures - NetWorkingCapitalInvestments.Balance.ForecastPeriodYear1;

        NetCashFlows_FreeCashFlows.ForecastPeriodYear1 = Operations.NetOperatingProfitAfterTAX_NOPAT.ForecastPeriodYear1 +
                                                         CapitalInvestments_FixedAssets.CashFlows.ForecastPeriodYear1 +
                                                         NetWorkingCapitalInvestments.CashFlows.ForecastPeriodYear1;
        NetCashFlows_FreeCashFlows.PresentValueFactor.BaseFigures = BoundariesData.WACC;
        NetCashFlows_FreeCashFlows.PresentValueFactor.ForecastPeriodYear1 = 1 / (1 + NetCashFlows_FreeCashFlows.PresentValueFactor.BaseFigures);
        NetCashFlows_FreeCashFlows.PresentValueOfNetCashFlows.ForecastPeriodYear1 = NetCashFlows_FreeCashFlows.ForecastPeriodYear1 * NetCashFlows_FreeCashFlows.PresentValueFactor.ForecastPeriodYear1;
        NetCashFlows_FreeCashFlows.CummulativePresentValueNCF.BaseFigures = NetCashFlows_FreeCashFlows.PresentValueOfNetCashFlows.ForecastPeriodYear1;
        NetCashFlows_FreeCashFlows.ContinuingValue.NetOperatingProfitAfterTax_NOPAT.ForecastPeriodYear1 = Operations.NetOperatingProfitAfterTAX_NOPAT.ForecastPeriodYear1;
        NetCashFlows_FreeCashFlows.ContinuingValue.BaseFigures = BoundariesData.WACC;
        NetCashFlows_FreeCashFlows.ContinuingValue.ForecastPeriodYear1 = NetCashFlows_FreeCashFlows.ContinuingValue.NetOperatingProfitAfterTax_NOPAT.ForecastPeriodYear1 / NetCashFlows_FreeCashFlows.ContinuingValue.BaseFigures;

        AssignBaseText();
        AssignFirstValue();
        AssignPeriodForecast();
        //CountStandard();

    }

    void Update()
    {
        
    }

    private void AssignFirstValue()
    {
        FirstSales = (int)Operations.Sales.ForecastPeriodYear1;
        FirstOperatingProfit = (int)Operations.OperatingProfitMargin.ForecastPeriodYear1;
        FirstTax = (int)Operations.Tax25Percent.ForecastPeriodYear1;
        FirstNOPAT = (int)Operations.NetOperatingProfitAfterTAX_NOPAT.ForecastPeriodYear1;
        FirstCIBalance = (int)CapitalInvestments_FixedAssets.Balance.ForecastPeriodYear1;
        FirstCICashFlow = (int)CapitalInvestments_FixedAssets.CashFlows.ForecastPeriodYear1;
        FirstNWCBalance = (int)NetWorkingCapitalInvestments.Balance.ForecastPeriodYear1;
        FirstNWCCashFlow = (int)NetWorkingCapitalInvestments.CashFlows.ForecastPeriodYear1;
        FirstFreeCashFlow = NetCashFlows_FreeCashFlows.ForecastPeriodYear1;
        FirstPresentValue = NetCashFlows_FreeCashFlows.PresentValueFactor.ForecastPeriodYear1;
        FirstPresentValueCashFlow = NetCashFlows_FreeCashFlows.PresentValueOfNetCashFlows.ForecastPeriodYear1;
        FirstContinueNOPAT = (int)NetCashFlows_FreeCashFlows.ContinuingValue.NetOperatingProfitAfterTax_NOPAT.ForecastPeriodYear1;
        FirstContinuingValue = NetCashFlows_FreeCashFlows.ContinuingValue.ForecastPeriodYear1;
    }

    private void AssignBaseText()
    {
        BaseSalesText.text = Operations.Sales.BaseFigures.ToString("n0").Replace(',', '.') + "";
        BaseOperatingProfitText.text = Operations.OperatingProfitMargin.BaseFigures.ToString("n0").Replace(',', '.') + "";
        BaseCIBalanceText.text = CapitalInvestments_FixedAssets.Balance.BaseFigures.ToString("n0").Replace(',', '.') + "";
        BaseNWCBalanceText.text = NetWorkingCapitalInvestments.Balance.BaseFigures.ToString("n0").Replace(',', '.') + "";
        BasePresentValueText.text = System.Math.Round( NetCashFlows_FreeCashFlows.PresentValueFactor.BaseFigures *100,2) + "%";
        BaseCumulativeNCFText.text = System.Math.Round(NetCashFlows_FreeCashFlows.CummulativePresentValueNCF.BaseFigures , 2).ToString("n2").Replace(',', '.') + "";
        BaseContinuingValueText.text = System.Math.Round(NetCashFlows_FreeCashFlows.ContinuingValue.BaseFigures * 100, 2) + "%";
        BasePVContinuingText.text = NetCashFlows_FreeCashFlows.PVofContinuingValue.BaseFigures.ToString("n0").Replace(',', '.') + "";
    }

    private void AssignPeriodForecast()
    {
        BaseCumulativeNCF = NetCashFlows_FreeCashFlows.CummulativePresentValueNCF.BaseFigures;
        for (int x = 1; x <= ValueDrivers.PlanningPeriod_Years; x++ )
        {
            if (x == ValueDrivers.PlanningPeriod_Years)
            {
                BaseCumulativeNCFText.text = System.Math.Round(BaseCumulativeNCF, 2) + "";
                BasePVContinuingText.text = (int)(FirstPresentValue * FirstContinuingValue) + "";
                NetCashFlows_FreeCashFlows.PVofContinuingValue.BaseFigures = FirstPresentValue * FirstContinuingValue;
                EndPeriodNOPAT = FirstNOPAT;
            }
            GameObject PeriodForecast = Instantiate(ForecastPeriodYear, changeable.transform);
            PeriodForecast.transform.localPosition = new Vector2(120 * x, 0);
            YearsCashFlowData data = PeriodForecast.GetComponent<YearsCashFlowData>();
            data.YearNumText.text = x.ToString();
            data.SalesText.text = (FirstSales).ToString("n0").Replace(',','.') + "";
            data.OperatingProfitText.text = FirstOperatingProfit.ToString("n0").Replace(',', '.') + "";
            data.TaxText.text = FirstTax.ToString("n0").Replace(',', '.') + "";
            data.NOPATText.text = FirstNOPAT.ToString("n0").Replace(',', '.') + "";
            data.CIBalanceText.text = FirstCIBalance.ToString("n0").Replace(',', '.') + "";
            data.CICashFlowText.text = FirstCICashFlow.ToString("n0").Replace(',', '.') + "";
            data.NWCBalanceText.text = FirstNWCBalance.ToString("n0").Replace(',', '.') + "";
            data.NWCCashFlowText.text = FirstNWCCashFlow.ToString("n0").Replace(',', '.') + "";
            data.NCFText.text = FirstFreeCashFlow.ToString("n0").Replace(',', '.') + "";
            data.PresentValueText.text = System.Math.Round(FirstPresentValue,3) + "";
            data.CICashFlowOfNCFText.text = System.Math.Round(FirstPresentValueCashFlow,2) + "";
            data.ContinuingNOPATText.text = FirstContinueNOPAT.ToString("n0").Replace(',', '.') + "";
            data.ContinuingValueText.text = FirstContinuingValue.ToString("n0").Replace(',', '.') + "";

            if (x < ValueDrivers.PlanningPeriod_Years)
            {
                FirstSales = (int)(FirstSales * (1 + (ValueDrivers.SalesGrowthRate)));
                FirstOperatingProfit = (int)(FirstSales * ValueDrivers.OperatingProfitMargin);
                FirstTax = (int)(FirstOperatingProfit * ValueDrivers.CashTaxRate);
                FirstNOPAT = (int)(FirstOperatingProfit - FirstTax);
                int temp1 = FirstCIBalance;
                FirstCIBalance = (int)(FirstSales * ValueDrivers.IncrementalFixedCapitalInvestment);
                FirstCICashFlow = (int)(temp1 - FirstCIBalance);
                temp1 = FirstNWCBalance;
                FirstNWCBalance = (int)(FirstSales * ValueDrivers.IncrementalWorkingCapitalInvestment);
                FirstNWCCashFlow = (int)(temp1 - FirstNWCBalance);
                FirstFreeCashFlow = (FirstNOPAT + FirstCICashFlow + FirstNWCCashFlow);
                FirstPresentValue = (FirstPresentValue / (1 + NetCashFlows_FreeCashFlows.PresentValueFactor.BaseFigures));
                FirstPresentValueCashFlow = (FirstFreeCashFlow * FirstPresentValue);
                BaseCumulativeNCF += FirstPresentValueCashFlow;
                FirstContinueNOPAT = (FirstNOPAT);
                if(x != 4)
                FirstContinuingValue = (FirstContinueNOPAT / NetCashFlows_FreeCashFlows.ContinuingValue.BaseFigures);
                else if(x == 4)
                FirstContinuingValue = ((double)FirstContinueNOPAT *(1 + TemplateData.AverageEconomicGrowth) / (NetCashFlows_FreeCashFlows.ContinuingValue.BaseFigures - TemplateData.AverageEconomicGrowth));
            }
        }
    }

    //private void CountStandard()
    //{
    //    int StdSales, StdOperatingProfit, StdTax, StdNOPAT, StdCIBalance, StdCICashFlow;
    //    int StdNWCBalance, StdNWCCashFlow, StdContinueNOPAT;
    //    double StdPresentValueCashFlow, StdPresentValue, StdFreeCashFlow, StdContinuingValue;
        
    //    StdSales = (int)(LiabilitiesandOwnersEquity.ProfitandLossStatement.Sales * (1 + (TemplateData.ValueDriver_SalesGrowthRate)));
    //    StdOperatingProfit = (int)(StdSales * TemplateData.ValueDriver_OperatingProfitMargin);
    //    StdTax = (int)(StdOperatingProfit * TemplateData.ValueDriver_CashTaxRate);
    //    StdNOPAT = (int)(StdOperatingProfit - StdTax);
    //    StdCIBalance = (int)(StdSales * TemplateData.ValueDriver_IncrementalFixedCapitalInvestment);
    //    StdCICashFlow = (int)(StdCIBalance - KeyFigures.FixedAssets);
    //    StdNWCBalance = (int)(StdSales * TemplateData.ValueDriver_IncrementalWorkingCapitalInvestment);
    //    StdNWCCashFlow = (int)(StdNWCBalance - KeyFigures.NWC);
    //    StdFreeCashFlow = StdNOPAT - StdCICashFlow - StdNWCCashFlow;
    //    StdPresentValue = (1 / (1 + NetCashFlows_FreeCashFlows.PresentValueFactor.BaseFigures));
    //    StdPresentValueCashFlow = (StdFreeCashFlow * StdPresentValue);
    //    StdContinueNOPAT = StdNOPAT;
    //    StdContinuingValue = (StdContinueNOPAT / NetCashFlows_FreeCashFlows.ContinuingValue.BaseFigures);

    //    for (int x = 1; x <= ValueDrivers.PlanningPeriod_Years; x++)
    //    {
    //        //if (x == ValueDrivers.PlanningPeriod_Years)
    //        //{
    //        //    NetCashFlows_FreeCashFlows.PVofContinuingValue.BaseFigures = FirstPresentValue * FirstContinuingValue;
    //        //    EndPeriodNOPAT = FirstNOPAT;
    //        //}
    //        //GameObject PeriodForecast = Instantiate(ForecastPeriodYear, changeable.transform);
    //        //PeriodForecast.transform.localPosition = new Vector2(80 * x, 0);
    //        //YearsCashFlowData data = PeriodForecast.GetComponent<YearsCashFlowData>();

    //        if (x < ValueDrivers.PlanningPeriod_Years)
    //        {
    //            StdSales = (int)(StdSales * (1 + TemplateData.ValueDriver_SalesGrowthRate));
    //            StdOperatingProfit = (int)(StdSales * TemplateData.ValueDriver_OperatingProfitMargin);
    //            StdTax = (int)(StdOperatingProfit * TemplateData.ValueDriver_CashTaxRate);
    //            StdNOPAT = (int)(StdOperatingProfit - StdTax);
    //            int temp1 = StdCIBalance;
    //            StdCIBalance = (int)(StdSales * TemplateData.ValueDriver_IncrementalFixedCapitalInvestment);
    //            StdCICashFlow = (int)(StdCIBalance - temp1);
    //            temp1 = StdNWCBalance;
    //            StdNWCBalance = (int)(StdSales * TemplateData.ValueDriver_IncrementalWorkingCapitalInvestment);
    //            StdNWCCashFlow = (int)(StdNWCBalance - temp1);
    //            StdFreeCashFlow = (StdNOPAT - StdCICashFlow - StdNWCCashFlow);
    //            StdPresentValue = (StdPresentValue / (1 + NetCashFlows_FreeCashFlows.PresentValueFactor.BaseFigures));
    //            StdPresentValueCashFlow = (StdFreeCashFlow * StdPresentValue);
    //            StandardCumulativeNCF += StdPresentValueCashFlow;
    //            StdContinueNOPAT = (StdNOPAT);
    //            if (x != 4)
    //                StdContinuingValue = (StdContinueNOPAT / NetCashFlows_FreeCashFlows.ContinuingValue.BaseFigures);
    //            else if (x == 4)
    //                StdContinuingValue = ((double)StdContinueNOPAT * (1 + TemplateData.AverageEconomicGrowth) / (NetCashFlows_FreeCashFlows.ContinuingValue.BaseFigures - TemplateData.AverageEconomicGrowth));
    //        }
    //    }

    //    StandardCumulativeNCF += StdContinuingValue * StdPresentValue;
    //    StandardCumulativeNCF -= LiabilitiesandOwnersEquity.Borrowing.TotalBorr;
    //    StandardCumulativeNCF -= KeyFigures.OwnersEquity;
    //    StandardCumulativeNCF += 272;
    //}
}
