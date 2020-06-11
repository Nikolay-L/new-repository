using System;
using ConsoleApp1les0.CurrencyConverter;

namespace ConsoleApp1les0
{
    class Program
    {
        static void Main(string[] args)
        {
            var Exchange = new CurrencyRates();
            Exchange.Usd = 28.7;
            Exchange.Euro = 35.3;
            var Baruga = new Currency(Exchange);

            Baruga.GetExchangeRate();
            Console.WriteLine("_______________________________________________");

            Baruga.UsdToUA(7);
            Console.WriteLine("_______________________________________________");

            Baruga.UaToUsd(750);
            Console.WriteLine("_______________________________________________");

            Baruga.EuroToUA(0);
            Console.WriteLine("_______________________________________________");

            Baruga.UaToEuro(2000);
            Console.WriteLine("_______________________________________________");

            Baruga.UsdToEuro(100);
            Console.WriteLine("_______________________________________________");

            Baruga.EuroToUsd(100);
            Console.WriteLine("_______________________________________________");

            Exchange.Usd = 40;
            Exchange.Euro = 45;
            Baruga.GetExchangeRate();
        }
    }
}
