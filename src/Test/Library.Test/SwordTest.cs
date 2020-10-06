using NUnit.Framework;
using RoleplayGame;

namespace Library.Test
{
    public class SwordTest
    {
        private Sword sword;

        [SetUp]
        public void SetUp()
        {
            sword = new Sword();
        }

        [Test]
        public void TestAttackValue()
        {
            Assert.AreEqual(sword.AttackValue,20);
        }

    }
}