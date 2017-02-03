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
                if (i == 10)
                {                if (inputValue >= 10 && inputValue <= 19) return tensDigit(inputValue);
                   
                }


            }

            if (inputValue / 10 == 0) return singleDigit(inputValue);
            if (inputValue / 100 == 0)
            {
                if (inputValue % 20 == 0)
                    return singleDigit(inputValue);
            }
            return "";
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
                default: return "Error";
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
                default: return "Error";
            }
        }
        //public string tensDigit(int number)
        //{
        //    switch (number)
        //    {
        //        case 10: return "ten";
        //        case 11: return "eleven";
        //        case 12: return "twelve";
        //        case 13: return "thirteen";
        //        case 14: return "fourteen";
        //        case 15: return "fifteen";
        //        case 16: return "sixteen";
        //        case 17: return "seventeen";
        //        case 18: return "eighteen";
        //        case 19: return "nineteen";
        //        case 2: return "twenty";
        //        case 3: return "thirty";
        //        case 4: return "fourty";
        //        case 5: return "fifty";
        //        case 6: return "sixty";
        //        case 7: return "seventy";
        //        case 8: return "eighty";
        //        case 9: return "ninety";
        //        default: return "Error";
        //    }
        //}

    }
}
