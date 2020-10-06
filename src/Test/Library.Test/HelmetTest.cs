using NUnit.Framework;
using RoleplayGame;

namespace Library.Test
{
    public class HelmetTest
    {
        private Helmet helmet;

         [SetUp]
        public void SetUp()
        {
            helmet = new Helmet();
        }

        [Test]
        public void TestDefenseValue()
        {
            Assert.AreEqual(helmet.DefenseValue,18);
        }
    }
}
