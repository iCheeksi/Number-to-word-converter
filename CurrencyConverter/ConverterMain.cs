using System;

namespace CurrencyConverter
{
    class ConverterMain
    {
        /* Main class to run currency converter program
         * runs until the user answers continue question no */

        static void Main(string[] args)
        {
            Console.Title = "Currency Converter";
            Console.ForegroundColor = ConsoleColor.Cyan;
            NumberToWords NTW = new NumberToWords();
            String y;

            do
            {
                Console.WriteLine("Please enter in some amount in numbers!");
                String amount = Console.ReadLine();

                amount = Convert.ToDouble(amount).ToString();

                if (amount == "0" || amount == "0.00")
                {
                    Console.WriteLine("Please enter an amount bigger than 0");
                }
                else
                Console.WriteLine("Thanks, you have entered " + NTW.Words(amount));
                Console.WriteLine();
                Console.WriteLine("Would you like to continue? Y/N");
                y = Console.ReadLine();
                Console.WriteLine();

            } while (y == "y" || y == "Y");

            Console.WriteLine("Thanks for using Currency converter service :) Made by Shelby");
        }
    }
}
