using BSOptionPricingModel.Interfaces;
using System.IO;

namespace BSOptionPricingModel.Classes
{
    class CsvWriter : Writer
    {
        public void writeToFile(object data, string pathToFile)
        {
            File.WriteAllText(data.ToString(), pathToFile);
        }
    }
}
