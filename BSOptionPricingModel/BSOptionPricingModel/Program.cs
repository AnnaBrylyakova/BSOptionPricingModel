using BSOptionPricingModel.Classes;
using BSOptionPricingModel.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSOptionPricingModel
{
    class Program
    {
        static void Main(string[] args)
        {
            Asset asset = new Asset();
            asset.SpotPrice = 42;
            asset.StrikePrice = 40;
            asset.Volatility = 0.2;

            Option option = new Option();
            option.Maturity = 0.5;
            option.RiskFreeRate = 0.1;
            option.Asset = asset;
            option.Type = OptionType.PUT;
            option.Style = OptionStyle.EUROPEAN;
            List<Dividend> dividends = new List<Dividend>();
            Dividend dividend1 = new Dividend();
            dividend1.Amount = 0.5;
            dividend1.Time = 2.00/12;
            Dividend dividend2 = new Dividend();
            dividend2.Amount = 0.5;
            dividend2.Time = 5.00 / 12;

           // dividends.Add(dividend1);
            //dividends.Add(dividend2);
            option.Dividends = dividends;

            OptionCalculator calculator = new BSOptionCalculator();

            double price = calculator.calculate(option);
            option.Price = price;
            Console.Write(option.Price.ToString());
            Console.ReadLine();
        }
    }
}
