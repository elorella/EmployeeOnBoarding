using EmployeeOnBoarding.Domain;
using NUnit.Framework;

namespace EmployeeOnBoardingApi.Tests.DomainTests
{
    [TestFixture]
    public class AssignmentTests
    {
        private readonly Assignment _assignment;
        private const int Id = 1;
        private const string Description = "Meet at least one new people eveyday.";
        private const int LevelId = 3;
        private const int DurationInSeconds = 2000;
        public AssignmentTests()
        {
            _assignment = new Assignment();
        }

        [Test]
        [Category("DomainTests")]
        public void SetAndGetId()
        {
            _assignment.Id = Id;
            Assert.That(_assignment.Id,Is.EqualTo(Id));
        }

        [Test]
        [Category("DomainTests")]
        public void TestSetAndGetDescription()
        {
            _assignment.Description = Description;
            Assert.That(_assignment.Description, Is.EqualTo(Description));
        }

        [Test]
        [Category("DomainTests")]
        public void TestSetAndGetLevel()
        {
            _assignment.Level = LevelId;
            Assert.That(_assignment.Level, Is.EqualTo(LevelId));
        }

        [Test]
        [Category("DomainTests")]
        public void TestSetAndGetDurationInSeconds()
        {
            _assignment.DurationInSeconds = DurationInSeconds;
            Assert.That(_assignment.DurationInSeconds, Is.EqualTo(DurationInSeconds));
        }
    }
}