using BSOptionPricingModel.Classes;
using System.Collections.Generic;

namespace BSOptionPricingModel.Interfaces
{
    interface Reader
    {
        List<double> readColumn(string filePath);
        List<Dividend> readColumns(string filePath);
        Option readInitialData(string filePath);
        string[] readAllLines(string filePath); 
    }
}
