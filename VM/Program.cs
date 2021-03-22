using System;
using System.Linq;
using System.Collections;
using System.Collections.Generic;

namespace VM
{
    public class Program
    {
        static double[] ValidCoins =  { 0.05, 0.10, 0.25 };
        static double totalAmount = 0;
        static Dictionary<string, double> product = new Dictionary<string, double>();
        
        static void Main(string[] args)
        {
            product.Add("C",1.00);
            product.Add("D", 0.5);
            product.Add("E", 0.65);

            AddCoins();
        }

        public static void GoToStore()
        {
            Console.WriteLine("Welcome to store");
            Console.WriteLine("Press C for cola ($1.0)");
            Console.WriteLine("Press D for chips ($0.50)");
            Console.WriteLine("Press E for candy ($0.65)");
            string item = Console.ReadLine();

            if (product.ContainsKey(item))
            {
                if(product[item] <= totalAmount)
                {
                    Console.WriteLine("Thank you. Remaining Balance : " + (totalAmount - product[item]));
                }
                else
                {
                    Console.WriteLine("You dont have enough balance in your bank. Press A to Add more coin or any other key to exit.");
                    string action = Console.ReadLine();
                    if (action.ToUpper() == "A")
                    {
                        AddCoins();
                    }
                }

            }
            else
            {
                Console.WriteLine("Please Enter Valid Keyword");
                GoToStore();
            }
        }

        public static void AddCoins()
        {
            double coin = GetCoin();
            totalAmount += coin;
            Console.WriteLine("Coin Added Successfully!. Total Amount : " + totalAmount + ".  Press A to Add more coin or any other key to go to store");
            string action = Console.ReadLine();
            if(action.ToUpper() == "A")
            {
                AddCoins();
            }
            else
            {
                GoToStore();
            }
        }
        public static double GetCoin()
        {
            Console.WriteLine("Please enter coin : ");
            var coin = Console.ReadLine();
            double f;
            if (!double.TryParse(coin, out f) || !ValidCoins.Contains(f))
            {
                Console.WriteLine("Please enter valid coin.");
                f = GetCoin();
            }
            return f;
        }
    }
}
