using SomethingForFun;
using NUnit.Framework;

namespace FoodProject.Test
{
    public class Tests
    {

        [Test]
        public void PizzaTest()
        {
            IFoodStuff pizza = new Pizza("Margharita", 100);
            Assert.That(pizza.Order(),Is.EqualTo("Margharita costs 100"));
        }

        [Test]
        public void BurgerTest()
        {
            IFoodStuff burger = new Burger("3", true, 120);
            Assert.That(burger.Order(), Is.EqualTo("burger with 3 patties and with tomatoes costs 120"));
        }

        [Test]
        public void BurgerTomatoeTestTrue()
        {
            Burger burger = new Burger("3", true, 120);
            Assert.That(burger.HasTomatoes, Is.True);
        }
        [Test]
        public void BurgerTomatoeTestFalse()
        {
            Burger burger = new Burger("3", false, 120);
            Assert.That(burger.HasTomatoes, Is.False);
        }

        [TestCase(100)]
        [TestCase(120)]
        [TestCase(-120)]
        public void PriceTest(int price)
        {
            Burger burger = new Burger("3",false, price);
            Assert.That(burger.GetPrice(), Is.EqualTo(price));
        }

        [TestCase(5,10)]
        [TestCase(25,2)]
        public void MultiplicationTest(int num1,int num2)
        {
            int result = num1 * num2;
            Assert.That(result,Is.EqualTo(50));
        }

        [TestCase(10)]
        [TestCase(30)]
        public void ModuloTest(int num)
        {
            int result = num % 2;
            Assert.That(result, Is.EqualTo(0));
        }
        [TestCase(11)]
        [TestCase(13)]
        public void NoModuloTest(int num)
        {
            int result = num % 5;
            Assert.That(result,Is.Not.EqualTo(0));
        }

        [TestCase("Hello")]
        public void CaseSensitiveTest(string text)
        {
            string upperCase = "QWERTYUIOPASDFGHJKLZXCVBNM";
            int numberOfUpperCase = 0;
            for(int i = 0; i < text.Length; i++)
            {
                if (upperCase.Contains(text[i]))
                {
                    numberOfUpperCase++;
                }
            }
            Assert.That(numberOfUpperCase, Is.EqualTo(1));
        }

        [TestCase("Hello","olleH")]
        [TestCase("Yo","oY")]
        [TestCase("Dude","eduD")]
        public void TestReversedWord(string word,string expectaton)
        {
            string result = "";
            for(int i = word.Length-1; i >= 0; i--)
            {
                result += word[i];
            }
            Assert.That(result, Is.EqualTo(expectaton));
        }

        [TestCase("iTAlIa","italia")]
        public void TestMakeLowercase(string word,string expectation)
        {
            string result = word.ToLower();
            Assert.That(result, Is.EqualTo(expectation));
        }
    }
}
