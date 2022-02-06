using System;
using System.Collections.Generic;

namespace ConsoleApp2
{
    public interface IDiscount
    {
        decimal CalculateDiscount(decimal price, decimal disc);
    }
    class Program
    {
        static void Main(string[] args)
        {            
            Console.WriteLine("Enter 'decimal_price int_clientType int_years' separated by space");

            string[] userInput = Console.ReadLine().Split();

            Console.WriteLine(DiscountFactory.DiscountCalculator(decimal.Parse(userInput[0]), int.Parse(userInput[1]), int.Parse(userInput[2])));

            Console.ReadKey();

        }
    }

    public static class DiscountFactory
    {
        private static Dictionary<int, IDiscount> _discounts =
           new Dictionary<int, IDiscount>();

        static DiscountFactory()
        {
            _discounts.Add(1, new Type1Discount());
            _discounts.Add(2, new Type2Discount());
            _discounts.Add(3, new Type3Discount());
            _discounts.Add(4, new Type4Discount());;
            _discounts.Add(5, new Type5Discount());
            //Here we'll add new;
        }

        public static decimal DiscountCalculator(decimal price, int clientType, int years)
        {
            decimal result = 0;
            decimal disc = (years > 7) ? (decimal)7 / 100 : (decimal)years / 100; // Following along the example in question

            return _discounts[clientType].CalculateDiscount(price,disc);
        }               
    }

   public class Type1Discount : IDiscount
    {
        public decimal CalculateDiscount(decimal price, decimal disc)
        {
            //implementation
            return price;
        }
    }
    public class Type2Discount : IDiscount
    {
        public decimal CalculateDiscount(decimal price, decimal disc)
        {
            //implementation like as in problem statement
            var result = (price - (0.1m*price)) -disc*(price - (0.1m * price));
            return result;
        }
    }
    public class Type3Discount : IDiscount
    {
        public decimal CalculateDiscount(decimal price, decimal disc)
        {
            //implementation 
            var result = (price - (0.5m*price)) -disc*(price - (0.5m * price));
            return result;
        }
    }
    public class Type4Discount : IDiscount
    {
        public decimal CalculateDiscount(decimal price, decimal disc)
        {
            //implementation like as in problem statement
            var result = (price - (0.6m*price)) -disc*(price - (0.6m * price));
            return result;
        }
    }
    public class Type5Discount : IDiscount
    {
        public decimal CalculateDiscount(decimal price, decimal disc)
        {
            //implementation

            /**
             * var thirdPartyDiscountService = new ThirdPartyDiscountService();
               var thirdPartyDiscount = thirdPartyDiscountService.GetDiscount();
               result = thirdPartyDiscount * price;
             * **/

            return disc;
        }
    }

    public abstract class Discount : IDiscount
    {
        public abstract decimal CalculateDiscount(decimal price, decimal disc);
    }
}
