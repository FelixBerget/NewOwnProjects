using SomethingForFun;
using NUnit.Framework;

namespace FoodProject.Test
{
    public class Tests
    {

        [Test]
        public void Test1()
        {
            IFoodStuff pizza = new Pizza("Margharita", 100);
            Assert.That(pizza.Order(),Is.EqualTo("Margharita costs 100"));
        }

        [Test]
        public void Test2()
        {
            IFoodStuff burger = new Burger("3", true, 120);
            Assert.That(burger.Order(), Is.EqualTo("burger with 3 patties and with tomatoes costs 120"));
        }
    }
}
