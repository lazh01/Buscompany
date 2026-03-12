using BusCompany;

namespace ReqnrollProject1.StepDefinitions
{
    [Binding]
    public sealed class PriceCalculatorStepDefinitions
    {
        private PriceCalculator _calculator = new PriceCalculator();
        private int _distance;
        private decimal _price;
        private System.Exception? _caught;

        [Given("a distance of {int}")]
        public void GivenADistanceOf(int distance)
        {
            _distance = distance;
        }

        [When("the price is calculated")]
        public void WhenThePriceIsCalculated()
        {
            try
            {
                _price = _calculator.CalculatePrice(_distance);
            }
            catch (System.Exception ex)
            {
                _caught = ex;
            }
        }

        [Then("the price should be {int}")]
        public void ThenThePriceShouldBe(int expected)
        {
            Assert.Null(_caught);
            Assert.Equal(expected, _price);
        }

        [Then("an argument exception should be thrown")]
        public void ThenAnArgumentExceptionShouldBeThrown()
        {
            Assert.NotNull(_caught);
            Assert.IsType<System.ArgumentException>(_caught);
        }
    }
}
