namespace ChallengeApp
{
    public class EmployeeInFile : EmployeeBase
    {
        private const string fileName = "grades.txt";
        public EmployeeInFile(string name, string surname)
            : base(name, surname)
        {
        }

        public override void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                using (var writer = File.AppendText(fileName))
                {
                    writer.WriteLine(grade);
                }
            }
            else
            {
                throw new Exception("Failure. Number is not between 0 - 100");
            }
        }

        public override void AddGrade(double grade)
        {
            float gradeAsFloat = (float)grade;
            this.AddGrade(gradeAsFloat);
        }

        public override void AddGrade(int grade)
        {
            float gradeAsFloat = (float)grade;
            this.AddGrade(gradeAsFloat);
        }

        public override void AddGrade(decimal grade)
        {
            float gradeAsFloat = (float)grade;
            this.AddGrade(gradeAsFloat);
        }

        public override void AddGrade(string grade)
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

        public override Statistics GetStatistics()
        {
            var gradesFromFile = this.ReadGradesFromFile();
            var result = this.CountStatistics(gradesFromFile);
            return result;
        }

        private List<float> ReadGradesFromFile()
        {
            var grades = new List<float>();
            if (File.Exists($"{fileName}"))
            {
                using (var reader = File.OpenText($"{fileName}"))
                {
                    var line = reader.ReadLine();
                    while (line != null)
                    {
                        var number = float.Parse(line);
                        grades.Add(number);
                        line = reader.ReadLine();
                    }
                }
            }
            return grades;
        }

        private Statistics CountStatistics(List<float> grades)
        {
            var statistics = new Statistics();

            statistics.Average = 0;
            statistics.Max = float.MinValue;
            statistics.Min = float.MaxValue;

            foreach (var grade in grades)
            {
                if (grade >= 0 && grade <= 100)
                {
                    statistics.Max = Math.Max(statistics.Max, grade);
                    statistics.Min = Math.Min(statistics.Min, grade);
                    statistics.Average += grade;
                }
            }

            statistics.Average /= grades.Count;

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
