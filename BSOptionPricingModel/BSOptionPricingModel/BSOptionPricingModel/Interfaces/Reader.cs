using BSOptionPricingModel.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
