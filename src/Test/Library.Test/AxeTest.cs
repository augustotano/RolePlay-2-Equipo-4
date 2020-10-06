using NUnit.Framework;
using RoleplayGame;

namespace Library.Test
{
    public class AxeTest
    {
        private Axe axe;
        
         [SetUp]
        public void SetUp()
        {
            axe = new Axe();
        }

        [Test]
        public void TestAttackValue()
        {
            Assert.AreEqual(axe.AttackValue,25);
        }
    }
}