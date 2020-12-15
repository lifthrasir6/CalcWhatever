using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using FluentAssertions;
using static CalcWhatever.Validator;

namespace CalcUnitTestIdontCare
{
    [TestClass]
    public class ValidatorTests
    {
        [TestMethod]
        public void IsNumber()
        {
            // Write this using the format you see in the other tests (just copy/paste the tests)
            var input = "2";
            var expected = 2;

            var result = ValidIsNumber(input);
            var testString = $"{input} should be equal to {expected} but is not because {result} is not a valid integer";

            //testString = @$"'{input}' should be equal to '{expected}' because '{input}' is a valid integer";

            testString = $"the string '{input}' is a valid integer and should return the number '{expected}'";

            result.Should().Be(expected, because: testString);

        }

        [TestMethod]
        public void IsNotNumber()
        {
            var input = "F";

            var result = ValidIsNumber(input);

            var testString = $"{input} is NOT a valid integer";

            //result.Should().Be(expected, because: testString);
            result.Should().BeNull(because: testString);

        }
    }
}
