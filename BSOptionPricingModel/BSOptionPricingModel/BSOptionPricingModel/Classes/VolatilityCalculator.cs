using System;
using System.Collections.Generic;
using System.Linq;

namespace BSOptionPricingModel.Classes
{
    class VolatilityCalculator
    {
        public const int numberOfOperDays = 252;
        public double calculateVolatility(List<double> prices)
        {
            
            int n = prices.Count() - 1;
            double[] u  = new double[n];
            double[] uSquare = new double[n];
            for (int i = 0; i < n; i++)
            {
                u[i] = Math.Log(prices.ElementAt(i + 1) / prices.ElementAt(i));
                uSquare[i] = Math.Pow(u[i], 2);
            }

            return Math.Sqrt(uSquare.Sum() / (n - 1) - (Math.Pow(u.Sum(), 2) / (n * (n - 1)))) * Math.Sqrt(numberOfOperDays);
        }
    }
}
