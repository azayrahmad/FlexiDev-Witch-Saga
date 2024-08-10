using WitchSaga.Core;

namespace WitchSaga.Tests
{
    [TestFixture]
    public class WitchTests
    {
        [Test]
        [TestCase(1, 1)]
        [TestCase(2, 2)]
        [TestCase(3, 4)]
        [TestCase(4, 7)]
        [TestCase(5, 12)]
        public void GetKilledInYear_ReturnsCorrectValue(int year, int expected)
        {
            var witch = new Witch();
            Assert.That(witch.GetKilledInYear(year), Is.EqualTo(expected));
        }

        [Test]
        public void GetKilledInYear_ThrowsForNegativeYear()
        {
            var witch = new Witch();
            Assert.Throws<ArgumentException>(() => witch.GetKilledInYear(-1));
        }
    }
}