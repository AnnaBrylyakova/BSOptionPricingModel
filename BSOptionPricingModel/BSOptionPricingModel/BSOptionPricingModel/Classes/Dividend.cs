using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSOptionPricingModel.Classes
{
    class Dividend
    {
        private double amount;
        private double time;

        public double Amount
        {
            get
            {
                return amount;
            }

            set
            {
                amount = value;
            }
        }

        public double Time
        {
            get
            {
                return time;
            }

            set
            {
                time = value;
            }
        }
    }
}
