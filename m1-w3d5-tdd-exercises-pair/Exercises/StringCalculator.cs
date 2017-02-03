using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TDDExercises
{
    public class StringCalculator
    {
        public int add(string inputValue)
        {
            if (inputValue.Length == 0)
            {
                return 0;
            }
            if (inputValue.Length == 1)
            {
                return int.Parse(inputValue);
            }
            int sum = 0;
            if (inputValue.Substring(0, 2) != "//")
            {
               
                string[] inputValueArray = inputValue.Split(new char[] { ',', '\n' });
                foreach (var item in inputValueArray)
                {
                    sum += int.Parse(item);
                }
                return sum;
            }
            else
            {
                char[] inputStringSeparator = inputValue.Substring(2, 1).ToCharArray();
                string[] inputValueArray = inputValue.Substring(3).Split(new char[] { ',', '\n',inputStringSeparator[0] });
                foreach (var item in inputValueArray)
                {
                    sum += int.Parse(item);
                }
                return sum;
            }
        }
    }
}
