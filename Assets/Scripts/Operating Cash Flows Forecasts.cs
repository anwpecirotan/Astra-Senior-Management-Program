using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OperatingCashFlowsForecasts : MonoBehaviour
{
    public class Operations
    {
        public class Sales
        {
            public static double BaseFigures = LiabilitiesandOwnersEquity.ProfitandLossStatement.Sales;
            public static double ForecastPeriodYear1 = BaseFigures * (1 + (ValueDrivers.SalesGrowthRate * 100));
            public static double ForecastPeriodYear2 = ForecastPeriodYear1 * (1 + (ValueDrivers.SalesGrowthRate * 100));
            public static double ForecastPeriodYear3 = ForecastPeriodYear2 * (1 + (ValueDrivers.SalesGrowthRate * 100));
            public static double ForecastPeriodYear4 = ForecastPeriodYear3 * (1 + (ValueDrivers.SalesGrowthRate * 100));
            public static double ForecastPeriodYear5 = ForecastPeriodYear4 * (1 + (ValueDrivers.SalesGrowthRate * 100));
        }

        public class OperatingProfitMargin
        {
            public static double BaseFigures = Sales.BaseFigures * ValueDrivers.OperatingProfitMargin;
            public static double ForecastPeriodYear1 = Sales.ForecastPeriodYear1 * ValueDrivers.OperatingProfitMargin;
            public static double ForecastPeriodYear2 = Sales.ForecastPeriodYear2 * ValueDrivers.OperatingProfitMargin;
            public static double ForecastPeriodYear3 = Sales.ForecastPeriodYear3 * ValueDrivers.OperatingProfitMargin;
            public static double ForecastPeriodYear4 = Sales.ForecastPeriodYear4 * ValueDrivers.OperatingProfitMargin;
            public static double ForecastPeriodYear5 = Sales.ForecastPeriodYear5 * ValueDrivers.OperatingProfitMargin;
        }

        public class Tax25Percent
        {
            public static double ForecastPeriodYear1 = OperatingProfitMargin.ForecastPeriodYear1 * ValueDrivers.CashTaxRate;
            public static double ForecastPeriodYear2 = OperatingProfitMargin.ForecastPeriodYear2 * ValueDrivers.CashTaxRate;
            public static double ForecastPeriodYear3 = OperatingProfitMargin.ForecastPeriodYear3 * ValueDrivers.CashTaxRate;
            public static double ForecastPeriodYear4 = OperatingProfitMargin.ForecastPeriodYear4 * ValueDrivers.CashTaxRate;
            public static double ForecastPeriodYear5 = OperatingProfitMargin.ForecastPeriodYear5 * ValueDrivers.CashTaxRate;
        }

        public class NetOperatingProfitAfterTAX_NOPAT
        {
            public static double ForecastPeriodYear1 = OperatingProfitMargin.ForecastPeriodYear1 - Tax25Percent.ForecastPeriodYear1;
            public static double ForecastPeriodYear2 = OperatingProfitMargin.ForecastPeriodYear2 - Tax25Percent.ForecastPeriodYear2;
            public static double ForecastPeriodYear3 = OperatingProfitMargin.ForecastPeriodYear3 - Tax25Percent.ForecastPeriodYear3;
            public static double ForecastPeriodYear4 = OperatingProfitMargin.ForecastPeriodYear4 - Tax25Percent.ForecastPeriodYear4;
            public static double ForecastPeriodYear5 = OperatingProfitMargin.ForecastPeriodYear5 - Tax25Percent.ForecastPeriodYear5;
        }
    }

    public class CapitalInvestments_FixedAssets
    {
        public class Balance
        {
            public static double BaseFigures = KeyFigures.FixedAssets;
            public static double ForecastPeriodYear1 = Operations.Sales.ForecastPeriodYear1 * ValueDrivers.IncrementalFixedCapitalInvestment;
            public static double ForecastPeriodYear2 = Operations.Sales.ForecastPeriodYear2 * ValueDrivers.IncrementalFixedCapitalInvestment;
            public static double ForecastPeriodYear3 = Operations.Sales.ForecastPeriodYear3 * ValueDrivers.IncrementalFixedCapitalInvestment;
            public static double ForecastPeriodYear4 = Operations.Sales.ForecastPeriodYear4 * ValueDrivers.IncrementalFixedCapitalInvestment;
            public static double ForecastPeriodYear5 = Operations.Sales.ForecastPeriodYear5 * ValueDrivers.IncrementalFixedCapitalInvestment;
        }

        public class CashFlows
        {
            public static double ForecastPeriodYear1 = Balance.BaseFigures - Balance.ForecastPeriodYear1;
            public static double ForecastPeriodYear2 = Balance.ForecastPeriodYear1 - Balance.ForecastPeriodYear2;
            public static double ForecastPeriodYear3 = Balance.ForecastPeriodYear2 - Balance.ForecastPeriodYear3;
            public static double ForecastPeriodYear4 = Balance.ForecastPeriodYear3 - Balance.ForecastPeriodYear4;
            public static double ForecastPeriodYear5 = Balance.ForecastPeriodYear4 - Balance.ForecastPeriodYear5;
        }
    }

    public class NetWorkingCapitalInvestments
    {
        public class Balance
        {
            public static double BaseFigures = KeyFigures.NWC;
            public static double ForecastPeriodYear1 = Operations.Sales.ForecastPeriodYear1 * ValueDrivers.IncrementalWorkingCapitalInvestment;
            public static double ForecastPeriodYear2 = Operations.Sales.ForecastPeriodYear2 * ValueDrivers.IncrementalWorkingCapitalInvestment;
            public static double ForecastPeriodYear3 = Operations.Sales.ForecastPeriodYear3 * ValueDrivers.IncrementalWorkingCapitalInvestment;
            public static double ForecastPeriodYear4 = Operations.Sales.ForecastPeriodYear4 * ValueDrivers.IncrementalWorkingCapitalInvestment;
            public static double ForecastPeriodYear5 = Operations.Sales.ForecastPeriodYear5 * ValueDrivers.IncrementalWorkingCapitalInvestment;
        }

        public class CashFlows
        {
            public static double ForecastPeriodYear1 = Balance.BaseFigures - Balance.ForecastPeriodYear1;
            public static double ForecastPeriodYear2 = Balance.ForecastPeriodYear1 - Balance.ForecastPeriodYear2;
            public static double ForecastPeriodYear3 = Balance.ForecastPeriodYear2 - Balance.ForecastPeriodYear3;
            public static double ForecastPeriodYear4 = Balance.ForecastPeriodYear3 - Balance.ForecastPeriodYear4;
            public static double ForecastPeriodYear5 = Balance.ForecastPeriodYear4 - Balance.ForecastPeriodYear5;
        }
    }

    public class NetCashFlows_FreeCashFlows
    {
        public static double ForecastPeriodYear1 = Operations.NetOperatingProfitAfterTAX_NOPAT.ForecastPeriodYear1 + 
                                                   CapitalInvestments_FixedAssets.CashFlows.ForecastPeriodYear1 +
                                                   NetWorkingCapitalInvestments.CashFlows.ForecastPeriodYear1;
        public static double ForecastPeriodYear2 = Operations.NetOperatingProfitAfterTAX_NOPAT.ForecastPeriodYear2 +
                                                   CapitalInvestments_FixedAssets.CashFlows.ForecastPeriodYear2 +
                                                   NetWorkingCapitalInvestments.CashFlows.ForecastPeriodYear2;
        public static double ForecastPeriodYear3 = Operations.NetOperatingProfitAfterTAX_NOPAT.ForecastPeriodYear3 +
                                                   CapitalInvestments_FixedAssets.CashFlows.ForecastPeriodYear3 +
                                                   NetWorkingCapitalInvestments.CashFlows.ForecastPeriodYear3;
        public static double ForecastPeriodYear4 = Operations.NetOperatingProfitAfterTAX_NOPAT.ForecastPeriodYear4 +
                                                   CapitalInvestments_FixedAssets.CashFlows.ForecastPeriodYear4 +
                                                   NetWorkingCapitalInvestments.CashFlows.ForecastPeriodYear4;
        public static double ForecastPeriodYear5 = Operations.NetOperatingProfitAfterTAX_NOPAT.ForecastPeriodYear5 +
                                                   CapitalInvestments_FixedAssets.CashFlows.ForecastPeriodYear5 +
                                                   NetWorkingCapitalInvestments.CashFlows.ForecastPeriodYear5;

        public class PresentValueFactor
        {
            public static double BaseFigures = WACC.Funds.WACCTotal.TotalWeightedCost;
            public static double ForecastPeriodYear1 = 1 / (1 + BaseFigures);
            public static double ForecastPeriodYear2 = ForecastPeriodYear1 / (1 + BaseFigures);
            public static double ForecastPeriodYear3 = ForecastPeriodYear2 / (1 + BaseFigures);
            public static double ForecastPeriodYear4 = ForecastPeriodYear3 / (1 + BaseFigures);
            public static double ForecastPeriodYear5 = ForecastPeriodYear4 / (1 + BaseFigures);
        }

        public class PresentValueOfNetCashFlows
        {
            public static double ForecastPeriodYear1 = NetCashFlows_FreeCashFlows.ForecastPeriodYear1 * NetCashFlows_FreeCashFlows.PresentValueFactor.ForecastPeriodYear1;
            public static double ForecastPeriodYear2 = NetCashFlows_FreeCashFlows.ForecastPeriodYear2 * NetCashFlows_FreeCashFlows.PresentValueFactor.ForecastPeriodYear2;
            public static double ForecastPeriodYear3 = NetCashFlows_FreeCashFlows.ForecastPeriodYear3 * NetCashFlows_FreeCashFlows.PresentValueFactor.ForecastPeriodYear3;
            public static double ForecastPeriodYear4 = NetCashFlows_FreeCashFlows.ForecastPeriodYear4 * NetCashFlows_FreeCashFlows.PresentValueFactor.ForecastPeriodYear4;
            public static double ForecastPeriodYear5 = NetCashFlows_FreeCashFlows.ForecastPeriodYear5 * NetCashFlows_FreeCashFlows.PresentValueFactor.ForecastPeriodYear5;
        }

        public class CummulativePresentValueNCF
        {
            public static double BaseFigures = PresentValueOfNetCashFlows.ForecastPeriodYear1 + PresentValueOfNetCashFlows.ForecastPeriodYear2 +
                                               PresentValueOfNetCashFlows.ForecastPeriodYear3 + PresentValueOfNetCashFlows.ForecastPeriodYear4 +
                                               PresentValueOfNetCashFlows.ForecastPeriodYear5;
        }

        public class ContinuingValue
        {
            public class NetOperatingProfitAfterTax_NOPAT
            {
                public static double ForecastPeriodYear1 = Operations.NetOperatingProfitAfterTAX_NOPAT.ForecastPeriodYear1;
                public static double ForecastPeriodYear2 = Operations.NetOperatingProfitAfterTAX_NOPAT.ForecastPeriodYear2;
                public static double ForecastPeriodYear3 = Operations.NetOperatingProfitAfterTAX_NOPAT.ForecastPeriodYear3;
                public static double ForecastPeriodYear4 = Operations.NetOperatingProfitAfterTAX_NOPAT.ForecastPeriodYear4;
                public static double ForecastPeriodYear5 = Operations.NetOperatingProfitAfterTAX_NOPAT.ForecastPeriodYear5;
            }

            public static double BaseFigures = ValueDrivers.CostofCapital;
            public static double ForecastPeriodYear1 = NetOperatingProfitAfterTax_NOPAT.ForecastPeriodYear1 / BaseFigures;
            public static double ForecastPeriodYear2 = NetOperatingProfitAfterTax_NOPAT.ForecastPeriodYear2 / BaseFigures;
            public static double ForecastPeriodYear3 = NetOperatingProfitAfterTax_NOPAT.ForecastPeriodYear3 / BaseFigures;
            public static double ForecastPeriodYear4 = NetOperatingProfitAfterTax_NOPAT.ForecastPeriodYear4 / BaseFigures;
            public static double ForecastPeriodYear5 = NetOperatingProfitAfterTax_NOPAT.ForecastPeriodYear5 / BaseFigures;
        }

        public class PVofContinuingValue
        {
            public static double BaseFigures = ContinuingValue.ForecastPeriodYear5 * PresentValueFactor.ForecastPeriodYear5;
        }
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
