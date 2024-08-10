using WitchSaga.Core;

namespace WitchSaga.Tests
{
    [TestFixture]
    public class PersonTests
    {
        [Test]
        public void Constructor_ValidInput_CreatesPerson()
        {
            var person = new Person(10, 12);
            Assert.That(person.AgeOfDeath, Is.EqualTo(10));
            Assert.That(person.YearOfDeath, Is.EqualTo(12));
        }

        [Test]
        public void Constructor_InvalidInput_ThrowsException()
        {
            Assert.Throws<ArgumentException>(() => new Person(-1, 12));
            Assert.Throws<ArgumentException>(() => new Person(10, 0));
        }

        [Test]
        public void BirthYear_CalculatesCorrectly()
        {
            var person = new Person(10, 12);
            Assert.That(person.BirthYear, Is.EqualTo(2));
        }
    }
}