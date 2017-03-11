using BSOptionPricingModel.Interfaces;
using System;

namespace BSOptionPricingModel.Classes
{
    class BSOptionCalculator : OptionCalculator
    {
        private double d1;
        private double d2;
        private double var;
        private double price;
        public double calculate(Option option)
        {
            if (option.Dividends.Capacity > 0)
            {
                double delta = 0;
                foreach (Dividend dividend in option.Dividends)
                {             
                    delta += dividend.Amount * Math.Exp(-option.RiskFreeRate * dividend.Time);

                }
                option.Asset.AdjustedSpotPrice -= delta;
            }

            d1 = (
                Math.Log(option.Asset.AdjustedSpotPrice / option.StrikePrice) +
                (
                    option.RiskFreeRate + Math.Pow(option.Asset.Volatility, 2) / 2
                )
                * option.Maturity
                )
                / (
                option.Asset.Volatility* Math.Sqrt(option.Maturity)
                );
        d2 = (
               Math.Log(option.Asset.AdjustedSpotPrice / option.StrikePrice) +
               (
                    option.RiskFreeRate - Math.Pow(option.Asset.Volatility, 2) / 2
               )
               * option.Maturity
               )
               / (
               option.Asset.Volatility* Math.Sqrt(option.Maturity)
               );
            var = option.StrikePrice * Math.Exp((-1) * option.RiskFreeRate * option.Maturity);
            
            price = option.Type.Equals(OptionType.CALL) ? (option.Asset.AdjustedSpotPrice * N(d1) - var * N(d2)) : (var * N(-d2) - option.Asset.AdjustedSpotPrice * N(-d1));
            
            return price;
        }
        private static double N(double x)
        {
            return 0.5 * (1 + Erf(x / Math.Sqrt(2)));
        }

        private static double Erf(double x)
        {
            double a1 = 0.254829592;
            double a2 = -0.284496736;
            double a3 = 1.421413741;
            double a4 = -1.453152027;
            double a5 = 1.061405429;
            double p = 0.3275911;

            int sign = 1;
            if (x < 0)
                sign = -1;
            x = Math.Abs(x);

            // A&S formula 7.1.26
            double t = 1.0 / (1.0 + p * x);
            double y = 1.0 - (((((a5 * t + a4) * t) + a3) * t + a2) * t + a1) * t * Math.Exp(-x * x);

            return sign * y;
        }
    }
}