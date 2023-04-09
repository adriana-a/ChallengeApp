
namespace ChallengeApp.Tests
{
    public class TypeTests
    {
        [Test]
        public void CompareOfTwoIntsWithTheSameValue()
        {
            int number1 = 1;
            int number2 = 1;

            Assert.AreEqual(number1, number2);
        }

        [Test]
        public void CompareOfTwoFloatsWithTheSameValue()
        {
            float number1 = 1.5f;
            float number2 = 1.5f;

            Assert.AreEqual(number1, number2);
        }

        [Test]
        public void CompareOfTwoDoublesWithTheSameValue()
        {
            double number1 = 1.54d;
            double number2 = 1.54d;

            Assert.AreEqual(number1, number2);
        }

        [Test]
        public void CompareOfTwoStringsWithTheSameValue()
        {
            string word1 = "robaczek";
            string word2 = "robaczek";

            Assert.AreEqual(word1, word2);
        }



        [Test]
        public void GetEmployeeShouldReturnDifferentObjects()
        {
            var employee1 = GetEmployee("Adrian");
            var employee2 = GetEmployee("Robert");

            Assert.AreNotEqual(employee1, employee2);
        }

        private Employee GetEmployee(string name)
        {
            return new Employee(name);
        }
    }
}
