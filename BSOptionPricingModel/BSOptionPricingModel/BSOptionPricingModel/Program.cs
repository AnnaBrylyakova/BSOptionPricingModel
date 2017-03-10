using BSOptionPricingModel.Classes;
using BSOptionPricingModel.Interfaces;

namespace BSOptionPricingModel
{
    class Program
    {
        public static string initialData = @"Data\InitialData.csv";
        public static string dividends = @"Data\Dividends2.csv";
        public static string historicalPrices = @"Data\Prices.csv";
        public static string outputPath = @"Data\OptionPrice.csv";

        static void Main(string[] args)
        {
            Reader reader = new CsvReader();
            OptionCalculator calculator = new BSOptionCalculator();
            Writer writer = new CsvWriter();
            
            Option option = reader.readInitialData(initialData);
            option.Dividends = reader.readColumns(dividends);
            option.Asset.HistoricalPrices = reader.readColumn(historicalPrices);
            option.Price = calculator.calculate(option);

            writer.writeToFile(option.Price, outputPath); 
        }
    }
}
