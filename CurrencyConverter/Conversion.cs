using System;

namespace CurrencyConverter
{
    /* Switch class to convert number 10-90. 
     * From 10-20 the numbers are listed as they have different way of saying */

    class Conversion
    {
        private String figure;

        public String Currency(String amount)
        {
            Ones one = new Ones();
            int input = Convert.ToInt32(amount);

            switch (input)
            {
                case 10:
                    figure = "Ten";
                    break;
                case 11:
                    figure = "Eleven";
                    break;
                case 12:
                    figure = "Twelve";
                    break;
                case 13:
                    figure = "Thirteen";
                    break;
                case 14:
                    figure = "Fourteen";
                    break;
                case 15:
                    figure = "Fifteen";
                    break;
                case 16:
                    figure = "Sixteen";
                    break;
                case 17:
                    figure = "Seventeen";
                    break;
                case 18:
                    figure = "Eighteen";
                    break;
                case 19:
                    figure = "Nineteen";
                    break;
                case 20:
                    figure = "Twenty";
                    break;
                case 30:
                    figure = "Thirty";
                    break;
                case 40:
                    figure = "Fourty";
                    break;
                case 50:
                    figure = "Fifty";
                    break;
                case 60:
                    figure = "Sixty";
                    break;
                case 70:
                    figure = "Seventy";
                    break;
                case 80:
                    figure = "Eighty";
                    break;
                case 90:
                    figure = "Ninty";
                    break;
                default:
                    /* Split the amount put in by the user in to two if the input is bigger than 10
                     * first digit will have a 0 added to recognize the number as tenth number
                     * and the second number will be recognized as the ones number. Then it puts the words together
                     * to give the figure value
                     * eg. 76 = Instead of it being Seven Six, will be read as Seventy Six
                     * */
                    if (input > 10)
                    {
                        figure = Currency(amount.Substring(0, 1) + "0") + " " + one.ConvertOnes(amount.Substring(1));
                    }
                    break;
            }
            return figure;
        }
    }
}
