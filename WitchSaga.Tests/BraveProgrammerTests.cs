using WitchSaga.Core;

namespace WitchSaga.Tests
{
    [TestFixture]
    public class BraveProgrammerTests
    {
        [Test]
        public void CalculateAverage_ValidInput_ReturnsCorrectAverage()
        {
            var calculator = new BraveProgrammer();
            var personA = new Person(10, 12);
            var personB = new Person(13, 17);
            Assert.That(calculator.WitchSolver(personA, personB), Is.EqualTo(4.5));
        }

        [Test]
        public void CalculateAverage_PersonBornBeforeWitchReign_ReturnsNegativeOne()
        {
            var calculator = new BraveProgrammer();
            var personA = new Person(12, 12);
            var personB = new Person(13, 17);
            Assert.That(calculator.WitchSolver(personA, personB), Is.EqualTo(-1));
        }
    }
}