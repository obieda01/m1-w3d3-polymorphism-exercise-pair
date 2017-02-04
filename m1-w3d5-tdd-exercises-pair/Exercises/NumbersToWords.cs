using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace TDDExercises
{
    public class NumbersToWords
    {


        Dictionary<string, string> numToStringDictionary = new Dictionary<string, string>() {
           {"1","one" },{ "2","two" },{ "3","three"},{ "4", "four" },{ "5","five" },{ "6", "six" },{"7", "seven" },{ "8","eight"},{"9","nine" },
            { "10","ten" },{"11", "eleven"},{ "12", "twelve" },{"13", "thirteen"},{ "14", "fourteen"},{"15", "fifteen"},{"16", "sixteen"},{"17", "seventeen"},
            {"18", "eighteen"},{"19", "nineteen"},{ "20", "twenty" },{ "30", "thirty" },{ "40", "fourty" },{ "50", "fifty" },
            { "60", "sixty" },{ "70", "seventy" },{ "80", "eighty" },{ "90", "ninety" },
        };
        StringBuilder resultString = new StringBuilder();

        public string numberInWords(int inputValue)
        {

            string str = inputValue.ToString();
            if (intToString(str) == 0) return "zero";
            int i = str.Length;
            switch (i)
            {
                case 1:
                    {

                        resultString.Append(numToStringDictionary[str[0].ToString()]);
                        break;
                    }
                case 2:
                    {
                        resultString.Append(twoDigitsCalculation(str));


                        break;
                    }
                case 3:
                    {
                        resultString.Append(threeDigitsCalculation(str));

                        break;
                    }

                case 4:
                    {
                        resultString.Append(fourDigitsCalculation(str));
                        break;
                    }

                case 5:
                    {
                        resultString.Append(fiveDigitsCalculation(str));
                        break;
                    }
                case 6:
                    {
                        if (intToString(str) % 100000 == 0)
                        {
                            resultString.Append(threeDigitsCalculation(str.Substring(0, 3)) + " thousand");
                        }

                        else
                        {

                            int val = (intToString(str.Substring(0, 3)) / 100) * 100;
                            resultString.Append(numToStringDictionary[str[0].ToString()] + " hundred and "
                                + fiveDigitsCalculation(str.Substring(1)));

                        }

                        break;
                    }

                default: return "";
            }
            return resultString.ToString();
        }





        public int intToString(string valueInString)
        {
            return int.Parse(valueInString);

        }
        public string twoDigitsCalculation(string twoDigitString)
        {
            if (intToString(twoDigitString) >= 10 && intToString(twoDigitString) < 20)
            {
                return numToStringDictionary[twoDigitString];

            }
            else
            {
                if (intToString(twoDigitString) % 10 == 0)
                {
                    return numToStringDictionary[twoDigitString];
                }
                else
                {
                    if(intToString( twoDigitString[0].ToString())==0) return numToStringDictionary[twoDigitString[1].ToString()];
                    return numToStringDictionary[twoDigitString[0] + "0"] 
                        + "-" + numToStringDictionary[twoDigitString[1].ToString()];
                }
            }
        }


        public string threeDigitsCalculation(string threeDigitString)
        {
            if (intToString(threeDigitString) == 0) return "";
            if (intToString(threeDigitString) % 100 == 0) return numToStringDictionary[threeDigitString[0].ToString()] + " hundred";
            return numToStringDictionary[threeDigitString[0].ToString()] 
                + " hundred and " + twoDigitsCalculation(threeDigitString.Substring(1));

        }
        public string fourDigitsCalculation(string fourDigitString)
        {

            if (intToString(fourDigitString) % 1000 == 0) return numToStringDictionary[fourDigitString[0].ToString()] + " thousand";
            return numToStringDictionary[fourDigitString[0].ToString()] 
                + " thousand and " + threeDigitsCalculation(fourDigitString.Substring(1));

        }
        public string fiveDigitsCalculation(string fiveDigitString)
        {

            if (intToString(fiveDigitString) % 10000 == 0)
            {
                return twoDigitsCalculation(fiveDigitString.Substring(0, 2)) + " thousand";
            }

            else
            {
                if (fiveDigitString.Substring(2) != "000")
                    return (twoDigitsCalculation(fiveDigitString.Substring(0, 2)) + " thousand and "
                          + threeDigitsCalculation(fiveDigitString.Substring(2)));
                else return twoDigitsCalculation(fiveDigitString.Substring(0, 2)) + " thousand";

            }

        }


    }
}