# BSOptionPricingModel
BSOptionPricingModel
//for me - instead of tests
            Option option2 = new Option();
            Asset asset = new Asset();
            asset.Volatility = 0.2;
            asset.SpotPrice = 42;
            option2.Asset = asset;
            option2.Maturity = 0.5;
            option2.StrikePrice = 40;
            option2.RiskFreeRate = 0.1;
            option2.Style = OptionStyle.EUROPEAN;
            option2.Type = OptionType.CALL;
            option2.Dividends = new List<Dividend>();

            option2.Price = calculator.calculate(option2); //4.75 - as in Hull

            option2.Type = OptionType.PUT;
            option2.Price = calculator.calculate(option2);//0.8085 - as in Hull


            Option option3 = new Option();
            
            asset.Volatility = 0.3;
            asset.SpotPrice = 40.00;
            option2.Asset = asset;
            option2.Maturity = 0.5;
            option2.StrikePrice = 40;
            option2.RiskFreeRate = 0.09;
            option2.Style = OptionStyle.EUROPEAN;
            option2.Type = OptionType.CALL;
            List<Dividend> dividends2 = new List<Dividend>();
            Dividend dividend1 = new Dividend();
            dividend1.Amount = 0.5;
            dividend1.Time = 2.00 / 12;

            Dividend dividend2 = new Dividend();
            dividend2.Amount = 0.5;
            dividend2.Time = 5.00 / 12;

            dividends2.Add(dividend1);
            dividends2.Add(dividend2);
            option2.Dividends = dividends2;

            option2.Price = calculator.calculate(option2);//3.67 - as in Hull
            Console.WriteLine(option2.Price);
            Console.ReadLine();    