using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDExercises
{
    public class NumbersToWords
    {

        public int calculateLength(int inputValue)
        {
            return (int)Math.Pow(10, inputValue.ToString().Length - 1);
        }


        public string numberInWords(int inputValue)
        {
            List<string> result = new List<string>();

            for (int i = calculateLength(inputValue); i > 0; i = i / 10)
            {

                if (inputValue / 10 == 0) return singleDigit(inputValue);
             

                if (i == 10)
                {
                    if (inputValue >= 10 && inputValue <= 19)
                    {
                        result.Add(tensDigit(inputValue));
                       
                    }
                    else
                    {
                        if (inputValue % 10 == 0)
                        {
                            result.Add(secondDigit(inputValue));
                            
                        }
                        else
                        {
                            result.Add(secondDigit((inputValue / 10) * 10));
                            result.Add("-");
                            result.Add(singleDigit(inputValue % 10));
                            
                        }
                    }

                }

                if (i == 100)
                {
                    result.Add(singleDigit(inputValue / 100));
                    result.Add(" hundred");
                   

                }
                inputValue /= 10;
               
            }
            return listToString(result);
          
            return "";
        }

        public string listToString(List<string> resultList)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var item in resultList)
            {
                sb.Append(item);
            }
            return sb.ToString();
        }
        public string singleDigit(int number)
        {
            switch (number)
            {
                case 0: return "zero";
                case 1: return "one";
                case 2: return "two";
                case 3: return "three";
                case 4: return "four";
                case 5: return "five";
                case 6: return "six";
                case 7: return "seven";
                case 8: return "eight";
                case 9: return "nine";
                default: return "";
            }
        }
        public string tensDigit(int number)
        {
            switch (number)
            {
                case 10: return "ten";
                case 11: return "eleven";
                case 12: return "twelve";
                case 13: return "thirteen";
                case 14: return "fourteen";
                case 15: return "fifteen";
                case 16: return "sixteen";
                case 17: return "seventeen";
                case 18: return "eighteen";
                case 19: return "nineteen";
                default: return "";
            }
        }
        public string secondDigit(int number)
        {
            switch (number)
            {

                case 20: return "twenty";
                case 30: return "thirty";
                case 40: return "fourty";
                case 50: return "fifty";
                case 60: return "sixty";
                case 70: return "seventy";
                case 80: return "eighty";
                case 90: return "ninety";
                default: return "";
            }
        }


    }
}
