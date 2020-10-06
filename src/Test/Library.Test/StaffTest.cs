using NUnit.Framework;
using RoleplayGame;

namespace Library.Test
{
    public class StaffTest
    {
        private Staff staff;

         [SetUp]
        public void SetUp()
        {
            staff = new Staff();
        }

        [Test]
        public void TestAttackValue()
        {
            Assert.AreEqual(staff.AttackValue,100);
        }
        [Test]
        public void TestDefenseValue()
        {
            Assert.AreEqual(staff.DefenseValue,100);
        }
    }
}