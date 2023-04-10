using System.Diagnostics;

namespace ChallengeApp
{
    public class Employee
    {

        private List<float> grades = new List<float>();

        public Employee()
        {
        }
        public Employee(string name, string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }

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
                Console.WriteLine("Failure. Write number between 0 - 100");
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

        public void AddGrade(char grade)
        {
            switch (grade)
            {
                case 'A':
                case 'a':
                    this.grades.Add(100);
                    break;

                case 'B':
                case 'b':
                    this.grades.Add(80);
                    break;

                case 'C':
                case 'c':
                    this.grades.Add(60);
                    break;

                case 'D':
                case 'd':
                    this.grades.Add(40);
                    break;

                case 'E':
                case 'e':
                    this.grades.Add(20);
                    break;

                default:
                    Console.WriteLine("Failure. Write letter between A - E");
                    break;
            }
        }

        public void AddGrade(string grade)
        {
            if (float.TryParse(grade, out float result))
            {
                this.AddGrade(result);
            }
            else if (grade.Length ==1)
            {
                AddGrade(Convert.ToChar(grade));
            }
            else
            {
                Console.WriteLine("Failure. Write number or letter between A - E");
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
