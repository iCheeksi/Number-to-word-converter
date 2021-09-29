using System;

namespace CurrencyConverter
{
    class Ones
    {
        /* Reads in the amount put in by the user, goes through the switch case to return "figure" string
         * Only deals from 1 - 9 */
        public String ConvertOnes(String amount)
        {
            int input = Convert.ToInt32(amount);
            String figure = "";
            switch (input)
            {
                case 1:
                    figure = "One";
                    break;
                case 2:
                    figure = "Two";
                    break;
                case 3:
                    figure = "Three";
                    break;
                case 4:
                    figure = "Four";
                    break;
                case 5:
                    figure = "Five";
                    break;
                case 6:
                    figure = "Six";
                    break;
                case 7:
                    figure = "Seven";
                    break;
                case 8:
                    figure = "Eight";
                    break;
                case 9:
                    figure = "Nine";
                    break;
            }
            return figure;
        }
    }
}
