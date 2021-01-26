using System;
using System.Collections.Generic;
using StockMarket;

namespace ConAssignment20Jan
{
    public class Program
    {
        static void Main(string[] args)
        {
            var br = new Broker();
            var stk = new List<Stock>()
            {
                new Stock("ZENSARTECH", 237.10, 50, StockType.Equity),
                new Stock("TATAMOTORS", 274.40, 70, StockType.MutualFund),
                new Stock("BURGERKING", 145.05),
                new Stock("IRCTC", 1451.70, 10, StockType.MutualFund),
                new Stock("ONGC", 98.50),
            };

            var ie = stk.GetEnumerator();
            while(ie.MoveNext())
            {
                br.BuyStock(ie.Current);
            }
        
            br.ShowPortfolio();

            Console.ReadLine();
        }
    }
}
