using BSOptionPricingModel.Interfaces;
using System;
using System.IO;
using System.Text;

namespace BSOptionPricingModel.Classes
{
    class CsvWriter : Writer
    {
        public void writeToFile(object data, string filePath)
        {
            File.WriteAllText(Path.Combine(Directory.GetParent(Directory.GetCurrentDirectory()).Parent.FullName, filePath), data.ToString().Replace(',','.'), Encoding.UTF8);
        }
    }
}
