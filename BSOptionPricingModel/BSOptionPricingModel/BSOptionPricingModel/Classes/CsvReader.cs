using BSOptionPricingModel.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.RegularExpressions;

namespace BSOptionPricingModel.Classes
{
    class CsvReader : Reader
    {
        public string[] readAllLines(string filePath)
        {
            try
            {
                string path = Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName, filePath);
                return File.ReadAllLines(path);
            } catch (Exception) {
                return new string[0];
            }
        }

        public List<double> readColumn(string filePath)
        {
            string[] stringValues = readAllLines(filePath);
            List<double> result = new List<double>();

            foreach (string value in stringValues)
            {
                try
                {
                    result.Add(Convert.ToDouble(value.Replace('.', ',')));
                }
                catch (FormatException)
                {
                    Console.WriteLine("Unable to convert '{0}' to a Double.", value);
                }
                catch (OverflowException)
                {
                    Console.WriteLine("'{0}' is outside the range of a Double.", value);
                }
            }

            return result;
        }

        public List<Dividend> readColumns(string filePath)
        {
            List<Dividend> dividends = new List<Dividend>();
            string[] stringValues = readAllLines(filePath);
            foreach (string value in stringValues)
            {
                String[] elements = Regex.Split(value, ",");
                Dividend dividend = new Dividend();
                dividend.Amount = Convert.ToDouble(elements[0].Replace('.', ','));
                dividend.Time = Convert.ToDouble(elements[1].Replace('.', ',')) / 12;
                dividends.Add(dividend);
            }
            return dividends;
        }

        public Option readInitialData(string filePath)
        {
            Option option = new Option();
            Asset asset = new Asset();
            string[] stringValues = readAllLines(filePath);
            string expectedHeader = "\"spotPrice\",\"strikePrice\",\"riskFreeRate\",\"timeToMaturity\",\"Style\",\"Type\"";
            char[] charsToTrim = { '*', ' ', '\'' };
            string actualHeader = stringValues[0];
            if (actualHeader.Equals(expectedHeader))
            {
                try
                {
                    string[] data = Regex.Split(stringValues[1], ",");
                    asset.SpotPrice = Convert.ToDouble(data[0].Replace('.', ','));
                    option.StrikePrice = Convert.ToDouble(data[1].Replace('.', ','));
                    option.RiskFreeRate = Convert.ToDouble(data[2].Replace('.', ','));
                    option.Maturity = Convert.ToDouble(data[3].Replace('.', ','));
                    option.Style = (OptionStyle)Enum.Parse(typeof(OptionStyle), data[4]);
                    option.Type = (OptionType)Enum.Parse(typeof(OptionType), data[5]);
                }
                catch (Exception)
                {
                    Console.WriteLine("Incorrect initial data");
                }
                option.Asset = asset;
            } else
            {
                Console.WriteLine("Incorrect initial data");
            }

                return option;
            
        }
    }
}

