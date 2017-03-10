using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSOptionPricingModel.Interfaces
{
    interface Writer
    {
        void writeToFile(object data, string pathToFile);
    }
}
