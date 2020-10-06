using NUnit.Framework;
using RoleplayGame;

namespace Library.Test
{
    public class BowTest
    {
        private Bow bow;

         [SetUp]
        public void SetUp()
        {
            bow = new Bow();
        }

        [Test]
        public void TestAttackValue()
        {
            Assert.AreEqual(bow.AttackValue,15);
        }
    }
}