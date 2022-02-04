using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Text;
using Tallertechnologies.InterviewExam.Lib.Src.Exceptions;
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
            //ARRANGE
            Calculator calculator = new Calculator();            
            //ACT
            string result = calculator.SumWithReverse(number1, number2);
            //ASSERT
            Assert.AreEqual(expected, result);
        }

        [Test]
        [TestCase("134", "")]
        [TestCase("", "1234")]
        [TestCase("", "")]
        [TestCase(null, "1234")]
        [TestCase("1234", null)]
        public void Should_Throw_Calculator_Exception_When_Paramter_is_Null_or_Empty(string num1, string num2)
        {
            //ARRANGE
            Calculator calculator = new Calculator();
            
            //ASSERT
            Assert.Throws<CalculatorException>(() => calculator.SumWithReverse(num1, num2));
        }
    }
}
