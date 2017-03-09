namespace BSOptionPricingModel
{
    internal class Asset
    {
        private string name;
        private double spotPrice;
        private double strikePrice;
        private double volatility;
        private double adjustedSpotPrice;

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public double SpotPrice
        {
            get
            {
                return spotPrice;
            }

            set
            {
                spotPrice = value;
                adjustedSpotPrice = value;
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

        public double Volatility
        {
            get
            {
                return volatility;
            }

            set
            {
                volatility = value;
            }
        }

        public double AdjustedSpotPrice
        {
            get
            {
                return adjustedSpotPrice;
            }

            set
            {
                adjustedSpotPrice = value;
            }
        }
    }
}