using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using Tallertechnologies.InterviewExam.Lib.Src.Exceptions;
using Tallertechnologies.InterviewExam.Lib.Src.Interfaces;

namespace Tallertechnologies.InterviewExam.Lib.Src.Validators
{
    class NumberValidator : IValidator
    {
        string value;
        string paramterName;

        public NumberValidator(string value, string parameterName)
        {
            this.value = value;
            this.paramterName = parameterName;
        }

        public NumberValidator(string value) : this(value, "Parameter")
        {
        }

        public void Validate()
        {
            if (String.IsNullOrEmpty(this.value))
            {
                string msg = $"{this.paramterName} cannot be Null of Empty";

                throw new CalculatorException(msg);
            }

            this.validateIsNumeric();
        }

        private void validateIsNumeric()
        {
            if (!Regex.IsMatch(this.value, @"^\d+$"))
            {
                string msg = $"{this.paramterName} must be Numeric";

                throw new CalculatorException(msg);
            }
        }
    }
}
