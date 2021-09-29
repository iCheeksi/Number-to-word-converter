using System;

namespace CurrencyConverter
{
    class wholeNumber
    {
        /* This class converts the whole number into String value. 
         * Can go up to a thousand */
        public String ConvertWholeNumber(String Number)
        {
            Ones ones = new Ones();
            Conversion conv = new Conversion();
            string word = "";
            try
            {
                bool beginsZero = false;
                bool complete = false;   
                double doubleAmount = (Convert.ToDouble(Number)); 
                
                    beginsZero = Number.StartsWith("0");

                    int numDigits = Number.Length;
                    int pos = 0;//store digit grouping    
                    String valueName = "";   
                    switch (numDigits)
                    {
                        case 1://ones case    
                            word = ones.ConvertOnes(Number);
                            complete = true;
                            break;

                        case 2://tens case    
                            word = conv.Currency(Number);
                            complete = true;
                            break;

                        case 3://hundreds case, +1 to change the outputs to positive, not negative for String.Format   
                            pos = (numDigits % 3) + 1;
                            valueName = " Hundred ";
                            break;

                        case 4://thousands case  
                        case 5:

                        case 6:
                            pos = (numDigits % 4) + 1;
                            valueName = " Thousand ";
                            break;  
                        default:
                            complete = true;
                            break;
                    }
                    if (!complete)
                    {
                        /*Iterate through the given number
                         * eg 356 <- 300 done, 56 not done, go again
                         * 56 <- 50 done, 6 not done, go again
                         * 6 <- done. Code complete */
                        if (Number.Substring(0, pos) != "0" && Number.Substring(pos) != "0")
                        {
                            try
                            {
                                word = ConvertWholeNumber(Number.Substring(0, pos)) + valueName + ConvertWholeNumber(Number.Substring(pos));
                            }
                            catch { }
                        }
                        else
                        {
                            word = ConvertWholeNumber(Number.Substring(0, pos)) + ConvertWholeNumber(Number.Substring(pos));
                        }
                    }
            }
            catch (FormatException e){ Console.WriteLine("Sorry try again "+e); }
            return word;
        }
    }
}
