using System;
using System.Collections.Generic;
using System.Text;

namespace Tallertechnologies.InterviewExam.Lib.Src.Utils.Helpers
{
    public class NumberHelper
    {
        public static int[] ConvertNumberToArray(string number)
        {
            char[] charArray = number.ToCharArray();
            int[] numberArray = Array.ConvertAll(charArray, c => (int)Char.GetNumericValue(c));
            return numberArray;
        }
    }
}
