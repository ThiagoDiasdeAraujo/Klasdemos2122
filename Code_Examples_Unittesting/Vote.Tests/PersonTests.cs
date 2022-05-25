using NUnit.Framework;

namespace Vote.Tests
{
    [TestFixture]
    internal class PersonTests
    {
        [Test]
        public void CanVote_WithAgeAbove18_ReturnsTrue()
        {
            // ARRANGE
            Person sut = new Person();
            sut.Age = 30;

            // ACT
            bool result = sut.CanVote;

            // ASSERT
            Assert.That(result, Is.True);
        }

        [Test]
        public void CanVote_WithAgeBelow18_ReturnsFalse()
        {
            // ARRANGE
            Person sut = new Person();
            sut.Age = 16;

            // ACT
            bool result = sut.CanVote;

            // ASSERT
            Assert.That(result, Is.False);
        }

        [Test]
        public void CanVote_WithAgeEqualTo18_ReturnsTrue()
        {
            // ARRANGE
            Person sut = new Person();
            sut.Age = 18;

            // ACT
            bool result = sut.CanVote;

            // ASSERT
            Assert.That(result, Is.True);
        }

        [TestCase(16, ExpectedResult = false)]
        [TestCase(18, ExpectedResult = true)]
        [TestCase(22, ExpectedResult = true)]
        public bool CanVote_WithAge_ReturnsExpectedResult(int age)
        {
            Person sut = new Person();
            sut.Age = age;

            return sut.CanVote;
        }
    }
}
