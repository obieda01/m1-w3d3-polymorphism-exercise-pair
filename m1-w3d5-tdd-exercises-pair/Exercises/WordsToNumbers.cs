using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDExercises
{
    public class WordsToNumbers
    {
        Dictionary<string, string> numToStringDictionary = new Dictionary<string, string>() {
           {"one","1" },{ "two","2" },{ "three","3"},{ "four","4"  },{ "five","5" },
            { "six","6" },{"seven","7"  },{ "eight","8"},{"nine","9" },
            { "ten","10" },{"eleven","11" },{ "twelve","12"},{"thirteen","13"},{ "fourteen","14"},
            { "fifteen","15"},{"sixteen","16"},{"seventeen","17"},
            {"eighteen","18" },{"nineteen","19"},{"twenty", "20"},{"thirty", "30"},{ "fourty","40"},
            { "fifty","50"},{ "sixty","60"},{ "seventy","70"},{ "eighty","80"},{ "ninety","90"},

        };
        StringBuilder resultInteger = new StringBuilder();

        public int transformWordToNum(string wordNum)
        {
            if (wordNum == "zero") return 0;
            string[] wordsArray = wordNum.Split(new char[] { ' ' });
            switch (wordsArray.Length - 1)
            {
                case 0:
                    {
                        resultInteger.Append(singleWordCalculation(wordsArray[0]));

                        break;
                    }
                case 1:
                    {
                        resultInteger.Append(hundredThoudadCase(wordsArray[0], wordsArray[1]));

                        break;
                    }
                case 3:
                    {
                        int firstTwoDigitInt = int.Parse(hundredThoudadCase(wordsArray[0], wordsArray[1]));
                        int lastDigitInt = int.Parse(singleWordCalculation(wordsArray[3]));
                        resultInteger.Append((firstTwoDigitInt + lastDigitInt).ToString());

                        break;
                    }

                case 4:
                    {
                        int firstTwoDigitInt = int.Parse(hundredThoudadCase(wordsArray[0], wordsArray[1]));
                        int lastDigitInt = int.Parse(hundredThoudadCase(wordsArray[3], wordsArray[4]));
                        resultInteger.Append((firstTwoDigitInt + lastDigitInt).ToString());


                        break;
                    }
                    
                case 6:
                    {
                        int firstTwoDigitInt = int.Parse(hundredThoudadCase(wordsArray[0], wordsArray[1]));
                        int MiddileDigitInt = int.Parse(hundredThoudadCase(wordsArray[3], wordsArray[4]));
                        int lastDigitInt = int.Parse(singleWordCalculation(wordsArray[6]));

                        resultInteger.Append((firstTwoDigitInt + MiddileDigitInt + lastDigitInt).ToString());

                        break;
                    }
                case 9:
                    {
                        int firstTwoDigitInt = 1000 * int.Parse(hundredThoudadCase(wordsArray[0], wordsArray[1]));

                        int socondTwoDigitInt = int.Parse(hundredThoudadCase(wordsArray[3], wordsArray[4]));
                        int MiddileDigitInt = int.Parse(hundredThoudadCase(wordsArray[6], wordsArray[7]));
                        int lastDigitInt = int.Parse(singleWordCalculation(wordsArray[9]));

                        resultInteger.Append((firstTwoDigitInt + socondTwoDigitInt + MiddileDigitInt + lastDigitInt).ToString());
                        break;
                    }

                default: return 0;

            }
            return int.Parse(resultInteger.ToString());
        }

        public string singleWordCalculation(string str)
        {
            string[] temp = str.Split(new char[] { '-' });
            if (temp.Length == 2)
            {
                int secondDigit = int.Parse(numToStringDictionary[temp[0]])
                    + int.Parse(numToStringDictionary[temp[1]]);
                return secondDigit.ToString();
            }
            else
            {
                return numToStringDictionary[temp[0]];
            }
        }

        public string hundredThoudadCase(string str_0, string str_1)
        {
            if (str_1 == "hundred")
                return numToStringDictionary[str_0] + "00";
            if (str_1 == "thousand")
                return singleWordCalculation(str_0) + "000";
            return "";
        }
    }
}
