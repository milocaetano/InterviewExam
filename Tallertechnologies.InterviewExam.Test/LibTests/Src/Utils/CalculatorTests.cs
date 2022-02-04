using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using Tallertechnologies.InterviewExam.Lib.Src.Utils;

namespace Tallertechnologies.InterviewExam.Test.LibTests.Src.Utils
{
    public class CalculatorTests
    {
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
            Calculator calculator = new Calculator();
            string result = calculator.SumWithReverse(number1, number2);

            Assert.AreEqual(expected, result);
        }
    }
}
