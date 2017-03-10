using BSOptionPricingModel.Classes;
using System.Collections.Generic;

namespace BSOptionPricingModel
{
    internal class Asset
    {
        private double spotPrice;
        private double volatility;
        private double adjustedSpotPrice;
        private List<double> historicalPrices;
        private VolatilityCalculator calculator = new VolatilityCalculator();

        public double SpotPrice
        {
            get
            {
                return spotPrice;
            }

            set
            {
                spotPrice = value;
                adjustedSpotPrice = value;
            }
        }
               
        public double Volatility
        {
            get
            {
                return volatility;
            }

            set
            {
                volatility = value;
            }
        }

        public double AdjustedSpotPrice
        {
            get
            {
                return adjustedSpotPrice;
            }

            set
            {
                adjustedSpotPrice = value;
            }
        }

        public List<double> HistoricalPrices
        {
            get
            {
                return historicalPrices;
            }

            set
            {
                historicalPrices = value;
                volatility = calculator.calculateVolatility(historicalPrices);
            }
        }
    }
}