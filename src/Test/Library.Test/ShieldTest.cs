using NUnit.Framework;
using RoleplayGame;

namespace Library.Test
{
    public class ShieldTest
    {
        private Shield shield;

         [SetUp]
        public void SetUp()
        {
            shield = new Shield();
        }

        [Test]
        public void TestDefenseValue()
        {
            Assert.AreEqual(shield.DefenseValue,14);
        }
    }
}