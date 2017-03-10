using BSOptionPricingModel.Interfaces;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
