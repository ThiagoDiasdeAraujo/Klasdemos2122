using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vote.Tests
{
    [TestFixture]

    public class VoteTests
    {
        [Test]
        
        public void CanVote_WithAgeAbove18_ReturnsTrue()
        {
            // Arange
            Person sut = new Person();
            sut.Age = 30;

            // Act
            bool result = sut.CanVote;

            // Assert
            //Assert.That(result, Is.True);
            Assert.IsTrue(result);
        }

        [Test]

        public void CanVote_WithAgeBellow18_ReturnsFalse()
        {
            // Arange
            Person sut = new Person();
            sut.Age = 30;

            // Act
            bool result = sut.CanVote;

            // Assert
            //Assert.That(result, Is.True);
            Assert.IsTrue(result);
        }

        [Test]
        public void CanVote_WithAgeIS18_ReturnsTrue()
        {
            // Arange
            Person sut = new Person();
            sut.Age = 18;

            // Act
            bool result = sut.CanVote;

            // Assert
            //Assert.That(result, Is.True);
            Assert.IsTrue(result);
        }
    }
}
