namespace ChallengeApp
{
    public class Employee
    {

        private List<int> positiveScore = new List<int>();
        private List<int> negativeScore = new List<int>();

        public Employee()
        {
            this.Name = "-";
            this.Surname = "-";
            this.Age = 0;
        }

        public Employee(string name)
        {
            this.Name = name;
            this.Surname = "-";
            this.Age = 0;

        }

        public Employee(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
            this.Age = 0;

        }

        public Employee(string name, string surname, int age)
        {
            this.Name = name;
            this.Surname = surname;
            this.Age = age;

        }

        public string Name { get; private set; }
        public string Surname { get; private set; }
        public int Age { get; private set; }
        public int Result
        {
            get
            {
                var sumPositiveScore = this.positiveScore.Sum();
                var sumNegativeScore = this.negativeScore.Sum();
                var result = sumPositiveScore + sumNegativeScore;
                return result;
            }
        }

        public void AddScore(int score)
        {
            if (score >= 0)
            {
                this.positiveScore.Add(score);
            }
            else 
            {
                this.negativeScore.Add(score);
            }

        }


    }
}
