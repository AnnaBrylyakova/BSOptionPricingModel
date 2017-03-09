using BSOptionPricingModel.Classes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSOptionPricingModel.Interfaces
{
    interface OptionCalculator
    {
        double calculate(Option option);
    }
}
