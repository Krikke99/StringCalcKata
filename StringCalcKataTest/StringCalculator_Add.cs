namespace StringCalcKataTest
{
    public class StringCalculator_Add
    {
        private StringCalculator _calculator = new();
        [Fact]
        public void Return0EmptyString()
        {
            var result = _calculator.Add("");

            Assert.Equal(0, result);
        }

        [Theory]
        [InlineData("1",1)]
        [InlineData("2",2)]
        public void ReturnNumberGivenStringWithOneNumber(string numbers, int expectedResult)
        {
            var result = _calculator.Add(numbers);

            Assert.Equal(expectedResult, result);
        }

        [Theory]
        [InlineData("1,2", 3)]
        [InlineData("2,3", 5)]
        public void ReturnSumGivenStringWithTwoCommaSepperatorNumbers(string numbers, int expectedResult)
        {
            var result = _calculator.Add(numbers);

            Assert.Equal(expectedResult, result);
        }

        [Theory]
        [InlineData("1,2,3", 6)]
        [InlineData("2,3,4", 9)]
        public void ReturnSumGivenStringWithThreeCommaSepperatorNumbers(string numbers, int expectedResult)
        {
            var result = _calculator.Add(numbers);

            Assert.Equal(expectedResult, result);
        }

        [Theory]
        [InlineData("1\n2,3", 6)]
        [InlineData("1\n2\n3", 6)]
        [InlineData("1,2\n3", 6)]
        public void ReturnSumGivenStringWithThreeCommaOrNewLineSepperatorNumbers(string numbers, int expectedResult)
        {
            var result = _calculator.Add(numbers);

            Assert.Equal(expectedResult, result);
        }

        [Theory]
        [InlineData("//;\n1;2;3", 6)]
        public void ReturnSumGivenStringWithCustomDelimiter(string numbers, int expectedResult)
        {
            var result = _calculator.Add(numbers);

            Assert.Equal(expectedResult, result);
        }

        [Theory]
        [InlineData("-1,2", "Negatives not allowed: -1")]
        [InlineData("-1,-2", "Negatives not allowed: -1,-2")]
        public void ThrowGivenNegativeInputs(string numbers, string expectedMessage)
        {
            Action action = () => _calculator.Add(numbers);

            var ex = Assert.Throws<Exception>(action);

            Assert.Equal(expectedMessage, ex.Message);
        }

        [Theory]
        [InlineData("1,2,3000", 3)]
        [InlineData("1001,2", 2)]
        [InlineData("1000,2", 1002)]
        public void ReturnSumGivenStringIgnoreingValuesOver1000(string numbers, int expectedResult)
        {
            var result = _calculator.Add(numbers);

            Assert.Equal(expectedResult, result);
        }
    }
}