using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using Tallertechnologies.InterviewExam.Lib.Src.Utils.Helpers;
using Tallertechnologies.InterviewExam.Lib.Src.Exceptions;
using Tallertechnologies.InterviewExam.Lib.Src.Validators;

namespace Tallertechnologies.InterviewExam.Lib.Src.Utils
{
    public class Calculator
    {
        public int SumWithReverse(int number, int numberToBeReversed)
        {
            string result = this.SumWithReverse(number.ToString(), numberToBeReversed.ToString());
            return Convert.ToInt32(result);
        }
        public string SumWithReverse(string number, string numberToBeReversed)
        {
            new NumberValidator(number, "First Number").Validate();
            new NumberValidator(numberToBeReversed, "Second Number").Validate();
       
            int maxSixe = (number.Length > numberToBeReversed.Length ? number.Length : numberToBeReversed.Length) + 1;
            int[] result = new int[maxSixe];
            int[] numberArray = NumberHelper.ConvertNumberToArray(number);
            int[] numberArrayReversed = NumberHelper.ConvertNumberToArray(numberToBeReversed);
            Array.Reverse(numberArrayReversed);
            int temp = 0;

            for (int i = maxSixe - 1, j = numberArray.Length - 1, k = numberArrayReversed.Length - 1; i >= 0; i--, j--, k--)
            {
                int num1 = j >= 0 ? numberArray[j] : 0;
                int num2 = k >= 0 ? numberArrayReversed[k] : 0;
                int sum = num1 + num2 + temp;
                if (sum > 9)
                {
                    int[] sumArray = NumberHelper.ConvertNumberToArray(sum.ToString());
                    result[i] = sumArray.Last();
                    temp = sumArray.First();
                    continue;
                }
                else
                {
                    result[i] = sum;
                    temp = 0;
                }
            }

            string resultFormatted = String.Join("", result).TrimStart('0');
            return resultFormatted.Length > 0 ? resultFormatted : "0";
        }
    }
}
