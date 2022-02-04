using System;
using System.Collections.Generic;
using System.Text;

namespace Tallertechnologies.InterviewExam.Lib.Src.Exceptions
{
    public class CalculatorException : Exception
    {
        public CalculatorException(string msg) : base(msg)
        {
        }
    }
}
