using NUnit.Framework;
using RoleplayGame;

namespace Library.Test
{
    public class WizardTest
    {
        Wizard wizard = new Wizard("Wizard");

        [SetUp]
        public void Setup()
        {
            Spell[] spells = new Spell[]{new Spell()};
            SpellsBook spellsBook = new SpellsBook();
            spellsBook.Spells = spells;
            wizard.SpellsBook = spellsBook;
            Staff staff = new Staff();
            wizard.Staff = staff;
        }

        [Test]
        public void TestWizardAttackStaffAndSpell()
        {
            Assert.AreEqual(170, wizard.AttackValue);
        }

        [Test]
        public void TestWizardDefenseStaffAndSpell()
        {
            Assert.AreEqual(170, wizard.AttackValue);
        }

        

        [Test]
        public void TestReceiveAttack()
        {
            wizard.ReceiveAttack(200);
            Assert.AreEqual(70, wizard.Health);
        }

        [Test]
        public void TestReceiveAttackAndCure()
        {
            wizard.ReceiveAttack(200);
            wizard.Cure();
            Assert.AreEqual(100, wizard.Health);
        }
    }
}