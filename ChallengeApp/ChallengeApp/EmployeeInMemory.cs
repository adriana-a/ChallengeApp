namespace ChallengeApp
{
    public class EmployeeInMemory : EmployeeBase
    {

        public override event GradeAddedDelegate GradeAdded;

        private List<float> grades = new List<float>();

        public EmployeeInMemory()
           : this("no name", "no surname")
        {
        }

        public EmployeeInMemory(string name, string surname)
            : base(name, surname)
        {
        }

        public override void AddGrade(float grade)
        {
            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);

                if (GradeAdded != null)
                {
                    GradeAdded(this, new EventArgs());
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
            var statistics = new Statistics();
           
            foreach (var grade in this.grades)
            {
                statistics.AddGrade(grade);
            }

            return statistics;
        }
    }
}
