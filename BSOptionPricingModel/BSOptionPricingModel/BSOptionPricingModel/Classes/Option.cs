using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSOptionPricingModel.Classes
{
    class Option
    {
        private double maturity;
        private double riskFreeRate;
        private Asset asset;
        private double strikePrice;
        private OptionType type;
        private OptionStyle style;
        private double price;
        private List<Dividend> dividends;

        public double Maturity
        {
            get
            {
                return maturity;
            }

            set
            {
                maturity = value;
            }
        }

        public double RiskFreeRate
        {
            get
            {
                return riskFreeRate;
            }

            set
            {
                riskFreeRate = value;
            }
        }

        internal Asset Asset
        {
            get
            {
                return asset;
            }

            set
            {
                asset = value;
            }
        }

        public OptionType Type
        {
            get
            {
                return type;
            }

            set
            {
                type = value;
            }
        }

        public double Price
        {
            get
            {
                return price;
            }

            set
            {
                price = value;
            }
        }

        internal List<Dividend> Dividends
        {
            get
            {
                return dividends;
            }

            set
            {
                dividends = value;
            }
        }

        internal OptionStyle Style
        {
            get
            {
                return style;
            }

            set
            {
                style = value;
            }
        }

        public double StrikePrice
        {
            get
            {
                return strikePrice;
            }

            set
            {
                strikePrice = value;
            }
        }
    }
}
