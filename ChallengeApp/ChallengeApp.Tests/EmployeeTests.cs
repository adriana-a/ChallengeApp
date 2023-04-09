namespace ChallengeApp.Tests
{
    public class EmployeeTests
    {
        [Test]
        public void GetStatisticsShouldReturnCorrectMax()
        {
            var employee = new Employee("Kinga", "Rak");

            employee.AddGrade(3);
            employee.AddGrade(2);

            var statistics = employee.GetStatistics();

            Assert.AreEqual(3, statistics.Max);
        }

        [Test]
        public void GetStatisticsShouldReturnCorrectMin()
        {
            var employee = new Employee("Kinga", "Rak");

            employee.AddGrade(3);
            employee.AddGrade(2);

            var statistics = employee.GetStatistics();

            Assert.AreEqual(2, statistics.Min);
        }

        [Test]
        public void GetStatisticsShouldReturnCorrectAverageValue()
        {
            var employee = new Employee("Kinga", "Rak");

            employee.AddGrade(3);
            employee.AddGrade(2);

            var statistics = employee.GetStatistics();

            Assert.AreEqual(Math.Round(2.5, 2), Math.Round(statistics.Average, 2));
        }
    }
}
