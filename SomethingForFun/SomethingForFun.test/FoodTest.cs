namespace SomethingForFun.test
{
    public class Tests
    {

        [Test]
        public void FoodTest()
        {
            IFoodStuff pizza = new Pizza("Margharita","200");

            Assert.Equals(pizza.Order(), "Margharita costs 200");
        }
    }
}
