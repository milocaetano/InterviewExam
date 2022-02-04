using System;
using System.Collections.Generic;
using System.Text;

namespace Tallertechnologies.InterviewExam.Test.LibTests.Src.Utils
{
    public class Tests
    {
        public static int[] convertNumberToArray(string number)
        {
            char[] charArray = number.ToCharArray();
            int[] numberArray = Array.ConvertAll(charArray, c => (int)Char.GetNumericValue(c));
            return numberArray;
        }

        public static string sumWithReverse(string number, string numberToBeReversed)
        {
            if (String.IsNullOrEmpty(number) || String.IsNullOrEmpty(numberToBeReversed))
            {
                throw new Exception("Number can't be null or Empty");
            }

            int maxSixe = (number.Length > numberToBeReversed.Length ? number.Length : numberToBeReversed.Length) + 1;
            int[] result = new int[maxSixe];
            int[] numberArray = convertNumberToArray(number);
            int[] numberArrayReversed = convertNumberToArray(numberToBeReversed);
            Array.Reverse(numberArrayReversed);
            int temp = 0;

            for (int i = maxSixe - 1, j = numberArray.Length - 1, k = numberArrayReversed.Length - 1; i >= 0; i--, j--, k--)
            {
                int num1 = j >= 0 ? numberArray[j] : 0;
                int num2 = k >= 0 ? numberArrayReversed[k] : 0;
                int sum = num1 + num2 + temp;
                if (sum > 9)
                {
                    int[] sumArray = convertNumberToArray(sum.ToString());
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


        [SetUp]
        public void Setup()
        {
        }

        [Test]
        [TestCase("123456", "123456", "777777")]
        [TestCase("999", "999", "1998")]
        [TestCase("2", "111111", "111113")]
        [TestCase("999999", "123456", "1654320")]
        [TestCase("999999", "9123459", "10543218")]
        [TestCase("12", "199999", "1000003")]
        [TestCase("1", "0", "1")]
        [TestCase("0", "0", "0")]
        public void Should_Result_of_Sum_Number1_With_Number2Reversed_BeEqualTo_Expected(string number1, string number2, string expected)
        {
            string result = sumWithReverse(number1, number2);

            Assert.AreEqual(expected, result);
        }
    }


}
