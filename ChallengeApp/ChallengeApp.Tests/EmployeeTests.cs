namespace ChallengeApp.Tests
{
    public class Tests
    {
        [Test]
        public void WhenEmployeeCollectTwoPositiveScores_ShouldReturnCorrectResult()
        {
            var employee = new Employee("Karol", "Ma³ysz", 33);
            employee.AddScore(1);
            employee.AddScore(12);

            var result = employee.Result;

            Assert.AreEqual(13, result);
        }

        [Test]
        public void WhenEmployeeCollectTwoNegativeScores_ShouldReturnCorrectResult()
        {
            var employee = new Employee("Karol", "Ma³ysz", 33);
            employee.AddScore(-5);
            employee.AddScore(-5);

            var result = employee.Result;

            Assert.AreEqual(-10, result);
        }

        [Test]
        public void WhenEmployeeCollectNegativeAndPositiveScores_ShouldReturnCorrectResult()
        {
            var employee = new Employee("Karol", "Ma³ysz", 33);
            employee.AddScore(-5);
            employee.AddScore(10);

            var result = employee.Result;

            Assert.AreEqual(5, result);
        }
    }
}