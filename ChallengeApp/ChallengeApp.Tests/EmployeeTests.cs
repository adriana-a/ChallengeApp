namespace ChallengeApp.Tests
{
    public class EmployeeTests
    {
        [Test]
        public void AddCharGradeShouldBeEqualToCorrectValue()
        {
            var employee = new Employee();

            employee.AddGrade('A');

            var statistics = employee.GetStatistics();

            Assert.AreEqual(100, statistics.Max);
        }
        [Test]
        public void GetStatisticsShouldReturnCorrectMax()
        {
            var employee = new Employee();

            employee.AddGrade(3);
            employee.AddGrade(2);

            var statistics = employee.GetStatistics();

            Assert.AreEqual(3, statistics.Max);
        }

        [Test]
        public void GetStatisticsShouldReturnCorrectMin()
        {
            var employee = new Employee();

            employee.AddGrade(3);
            employee.AddGrade(2);

            var statistics = employee.GetStatistics();

            Assert.AreEqual(2, statistics.Min);
        }

        [Test]
        public void GetStatisticsShouldReturnCorrectAverageValue()
        {
            var employee = new Employee();

            employee.AddGrade(3);
            employee.AddGrade(2);

            var statistics = employee.GetStatistics();

            Assert.AreEqual(Math.Round(2.5, 2), Math.Round(statistics.Average, 2));
        }

        [Test]
        public void GetStatisticsShouldReturnCorrectAverageAsLetter()
        {
            var employee = new Employee();

            employee.AddGrade(100);
            employee.AddGrade('a'); ;

            var statistics = employee.GetStatistics();

            Assert.AreEqual('A', statistics.AverageAsLetter);
        }
    }
}
