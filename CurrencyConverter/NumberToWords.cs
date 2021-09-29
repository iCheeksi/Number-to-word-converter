using System;

namespace CurrencyConverter
{
    class NumberToWords
    {
        /*This class converts the numeric input to words
         * referenced from microsoft docs C# String.format */

        wholeNumber wh = new wholeNumber();
        Ones ones = new Ones();
        public String Words(String amount)
        {
            String value = "", dec = "", and = "", centsValue = "", cents = "" ;
            String number = amount;
            String dollars = "dollars";

            //Where there's . decimal
                int decimalPoint = amount.IndexOf(".");
                if (decimalPoint > 0)
                {
                    number = amount.Substring(0, decimalPoint);
                    dec = amount.Substring(decimalPoint +1);

                    if (Convert.ToInt32(dec) > 0)
                    {
                        and = "dollars and ";
                        cents = "cents";
                        centsValue = wh.ConvertWholeNumber(dec);
                    }
                    //Return dollar value, then cents value
                    return value = String.Format("{0} {1}{2} {3}", wh.ConvertWholeNumber(number), and, centsValue, cents);
            }
                else
                //return dollar value with the word dollar at the end
            return value = String.Format("{0} {1}{2}{3}", wh.ConvertWholeNumber(number), and, centsValue, dollars); 
        }
    }
}
