using NUnit.Framework;

namespace MoneyTest
{
    public class Tests
    {
        [Test]
        public void testMultiplication()
        {
            Dollar five = new Dollar(5);
            Dollar product = five.times(2);
            Assert.AreEqual(10, product.amount);
            product = five.times(3);
            Assert.AreEqual(15, product.amount);
        }

        [Test]
        public void testEquality()
        {
            Assert.IsTrue(new Dollar(5).Equals(new Dollar(5)));
            Assert.IsFalse(new Dollar(5).Equals(new Dollar(6)));
        }
    }

    public class Dollar
    {
        public int amount;

        public Dollar(int amount)
        {
            this.amount = amount;
        }

        public Dollar times(int multiplier)
        {
            return new Dollar(amount * multiplier);
        }

        public override bool Equals(object obj)
        {
            Dollar dollar = (Dollar) obj;
            return amount == dollar.amount;
        }
    }
}