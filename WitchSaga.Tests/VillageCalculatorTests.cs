using WitchSaga.Core;

namespace WitchSaga.Tests
{
    [TestFixture]
    public class VillageCalculatorTests
    {
        [Test]
        public void CalculateAverage_ValidInput_ReturnsCorrectAverage()
        {
            var calculator = new VillageCalculator();
            var personA = new Person(10, 12);
            var personB = new Person(13, 17);
            Assert.That(calculator.CalculateAverage(personA, personB), Is.EqualTo(4.5));
        }

        [Test]
        public void CalculateAverage_PersonBornBeforeWitchReign_ReturnsNegativeOne()
        {
            var calculator = new VillageCalculator();
            var personA = new Person(12, 12);
            var personB = new Person(13, 17);
            Assert.That(calculator.CalculateAverage(personA, personB), Is.EqualTo(-1));
        }
    }
}