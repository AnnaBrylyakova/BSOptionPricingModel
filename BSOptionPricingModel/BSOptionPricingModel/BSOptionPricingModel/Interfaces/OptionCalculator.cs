using BSOptionPricingModel.Classes;

namespace BSOptionPricingModel.Interfaces
{
    interface OptionCalculator
    {
        double calculate(Option option);
    }
}
