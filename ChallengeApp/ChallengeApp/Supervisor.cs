namespace ChallengeApp
{
    public class Supervisor : IEmployee
    {
        private List<float> grades = new List<float>();

        public Supervisor()
        {
        }

        public Supervisor(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }
        public string Name { get; private set; }

        public string Surname { get; private set; }

        public void AddGrade(float grade)
        {
            if (grade > 0 && grade < 100)
            {
                grades.Add(grade);
            }
            else
            {
                throw new Exception("Failure. Number is not between 0 - 100");
            }
        }

        public void AddGrade(double grade)
        {
            var gradeAsFloat = (float)grade;
            grades.Add(gradeAsFloat);
        }

        public void AddGrade(int grade)
        {
            var gradeAsFloat = (float)grade;
            grades.Add(gradeAsFloat);
        }

        public void AddGrade(decimal grade)
        {
            var gradeAsFloat = (float)grade;
            grades.Add(gradeAsFloat);
        }

        public void AddGrade(string grade)
        {

            switch (grade)
            {
                case "6":
                    AddGrade(100);
                    break;
                case "6-":
                case "-6":
                    AddGrade(95);
                    break;
                case "5+":
                case "+5":
                    AddGrade(85);
                    break;
                case "5":
                    AddGrade(80);
                    break;
                case "5-":
                case "-5":
                    AddGrade(75);
                    break;
                case "4+":
                case "+4":
                    AddGrade(65);
                    break;
                case "4":
                    AddGrade(60);
                    break;
                case "4-":
                case "-4":
                    AddGrade(55);
                    break;
                case "3+":
                case "+3":
                    AddGrade(45);
                    break;
                case "3":
                    AddGrade(40);
                    break;
                case "3-":
                case "-3":
                    AddGrade(35);
                    break;
                case "2+":
                case "+2":
                    AddGrade(25);
                    break;
                case "2":
                    AddGrade(20);
                    break;
                case "2-":
                case "-2":
                    AddGrade(15);
                    break;
                case "1+":
                case "+1":
                    AddGrade(5);
                    break;
                case "1":
                    AddGrade(0);
                    break;
                default:
                    throw new Exception("It is not a grade between 1-6");
            }
        }

        public Statistics GetStatistics()
        {
            var statistics = new Statistics();
            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            foreach (var grade in this.grades)
            {
                statistics.Max = Math.Max(statistics.Max, grade);
                statistics.Min = Math.Min(statistics.Min, grade);
                statistics.Average += grade;
            }

            statistics.Average /= this.grades.Count;


            switch (statistics.Average)
            {
                case var avearge when avearge >= 80:
                    statistics.AverageAsLetter = 'A';
                    break;
                case var avearge when avearge >= 60:
                    statistics.AverageAsLetter = 'B';
                    break;
                case var avearge when avearge >= 40:
                    statistics.AverageAsLetter = 'C';
                    break;
                case var avearge when avearge >= 20:
                    statistics.AverageAsLetter = 'D';
                    break;
                default:
                    statistics.AverageAsLetter = 'E';
                    break;
            }

            return statistics;
        }
    }
}
