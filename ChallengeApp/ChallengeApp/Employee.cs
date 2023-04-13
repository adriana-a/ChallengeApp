namespace ChallengeApp
{
    public class Employee : IEmployee
    {

        private List<float> grades = new List<float>();

        public Employee()
            : this("no name", "no surname")
        {
        }


        public Employee(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }

        //public Employee(string name, string surname, char sex)
        //    : base(name, surname, sex)
        //{
        //}

        public string Name { get; private set; }

        public string Surname { get; private set; }


        public void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);
            }
            else
            {
                throw new Exception("Failure. Number is not between 0 - 100");
            }
        }

        public void AddGrade(double grade)
        {
            float gradeAsFloat = (float)grade;
            this.AddGrade(gradeAsFloat);
        }

        public void AddGrade(int grade)
        {
            float gradeAsFloat = (float)grade;
            this.AddGrade(gradeAsFloat);
        }

        public void AddGrade(decimal grade)
        {
            float gradeAsFloat = (float)grade;
            this.AddGrade(gradeAsFloat);
        }

        public void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float result))
            {
                this.AddGrade(result);
            }
            else if (char.TryParse(grade, out char gradeAsChar))
            {
                switch (gradeAsChar)
                {
                    case 'A':
                    case 'a':
                        this.AddGrade(100);
                        break;

                    case 'B':
                    case 'b':
                        this.AddGrade(80);
                        break;

                    case 'C':
                    case 'c':
                        this.AddGrade(60);
                        break;

                    case 'D':
                    case 'd':
                        this.AddGrade(40);
                        break;

                    case 'E':
                    case 'e':
                        this.AddGrade(20);
                        break;

                    default:
                        throw new Exception("Failure. Letter is not between A - E");
                }
            }
            else
            {
                throw new Exception("Failure. Its is not a number or letter between A - E");
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
