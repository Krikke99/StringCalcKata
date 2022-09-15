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
    }
}