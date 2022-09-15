namespace StringCalcKataTest
{
    public class StringCalculator_Add
    {
        [Fact]
        public void Return0EmptyString()
        {
            var Calculator = new StringCalculator();

            var result = Calculator.Add("");

            Assert.Equal(0, result);
        }

        [Theory]
        [InlineData("1",1)]
        [InlineData("2",2)]
        public void ReturnNumberGivenStringWithOneNumber(string numbers, int expectedResult)
        {
            var Calculator = new StringCalculator();

            var result = Calculator.Add(numbers);

            Assert.Equal(expectedResult, result);
        }

        [Theory]
        [InlineData("1,2", 3)]
        [InlineData("2,3", 5)]
        public void ReturnSumGivenStringWithTwoCommaSepperatorNumbers(string numbers, int expectedResult)
        {
            var Calculator = new StringCalculator();

            var result = Calculator.Add(numbers);

            Assert.Equal(expectedResult, result);
        }
    }
}