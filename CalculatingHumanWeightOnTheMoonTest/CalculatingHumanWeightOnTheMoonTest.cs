namespace CalculatingHumanWeightOnTheMoonTest
{
    public class CalculatingHumanWeightOnTheMoonTest
    {
        [Theory]
        [InlineData(70.3,11.9)]
        [InlineData(49.2, 8.4)]
        public void HumanWeightOnTheMoon_WithCalculatingTheWeightOnTheMoon_ShouldReturnCorrectWeight(double input, double expectedWeight)
        {
            double result = CalculatingHumanWeightOnTheMoon.HumanWeightOnTheMoon(input);
            Assert.Equal(expectedWeight, result, 1);
        }
    }
}