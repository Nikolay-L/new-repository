using ConsoleApp1les0.CurrencyConverter;
using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;
using System.Text;

namespace ConsoleApp1les0
{
    class Currency
    {
        private CurrencyRates _rates;

        public Currency(CurrencyRates rates)
        {
            _rates = rates;
        }

        public void GetExchangeRate()
        {
            Console.WriteLine($"Rate for now: 1 USD costs {_rates.Usd} UAH");
            Console.WriteLine("              --------------------");
            Console.WriteLine($"              1 Euro costs {_rates.Euro} UAH");
        }

        public void UsdToUA(double value)
        {
            Console.WriteLine($"Smuga >>>> Hochy pominyatu {value} USD na GRN");
            if (value != 0)
            {
                value = _rates.Usd * value;
                Console.WriteLine("Baruga lustae babylesu........");
                Console.WriteLine("====================================");
                Console.WriteLine("Poluchi pacuk stiki GRN: " + value);
            }
            else
            { 
                Console.WriteLine("Pishov nah!"); 
            }
        }

        public void EuroToUA(double value)
        {
            Console.WriteLine($"Smuga >>>> Hochy pominyatu {value} EURO na GRN");
            if (value != 0)
            {
                value = _rates.Euro * value;
                Console.WriteLine("Baruga lustae babylesu........");
                Console.WriteLine("====================================");
                Console.WriteLine("Poluchi pacuk stiki GRN: " + value);
            }
            else
            {
                Console.WriteLine("Pishov nah!");
            }
        }

        public void UaToUsd(double value)
        {
            Console.WriteLine($"Smuga >>>> Hochy pominyatu {value} GRN na USD");
            if (value != 0)
            {
                value = value / _rates.Usd;
                Console.WriteLine("Baruga lustae babylesu........");
                Console.WriteLine("====================================");
                Console.WriteLine("Poluchi pacuk stiki USD: " + value);
            }
            else
            {
                Console.WriteLine("Pishov nah!");
            }
        }

        public void UaToEuro(double value)
        {
            Console.WriteLine($"Smuga >>>> Hochy pominyatu {value} GRN na EURO");
            if (value != 0)
            {
                value = value / _rates.Euro;
                Console.WriteLine("Baruga lustae babylesu........");
                Console.WriteLine("====================================");
                Console.WriteLine("Poluchi pacuk stiki EURO': " + value);
            }
            else
            {
                Console.WriteLine("Pishov nah!");
            }
        }

        public void UsdToEuro(double value)
        {
            Console.WriteLine($"Smuga >>>> Hochy pominyatu {value} USD na EURO");
            value = _rates.Usd / _rates.Euro * value;
            Console.WriteLine("Baruga lustae babylesu........");
            Console.WriteLine("====================================");
            Console.WriteLine("Poluchi pacuk stiki EURO': " + value);
        }

        public void EuroToUsd(double value)
        {
            Console.WriteLine($"Smuga >>>> Hochy pominyatu {value} EURO na USD");
            value = _rates.Euro / _rates.Usd * value;
            Console.WriteLine("Baruga lustae babylesu........");
            Console.WriteLine("====================================");
            Console.WriteLine("Poluchi pacuk stiki USD': " + value);
        }
    }
}
