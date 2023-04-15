namespace ChallengeApp
{
    public class Statistics
    {
        public float Min { get; private set; }

        public float Max { get; private set; }

        public float Sum { get; private set; }

        public int Count { get; private set; }

        public float Average
        {
            get
            {
                return this.Sum / this.Count;
            }
        }

        public char AverageAsLetter
        {
            get
            {
                switch (this.Average)
                {
                    case var avearge when avearge >= 80:
                        return 'A';
                    case var avearge when avearge >= 60:
                        return 'B';
                    case var avearge when avearge >= 40:
                        return 'C';
                    case var avearge when avearge >= 20:
                        return 'D';
                    default:
                        return 'E';
                }
            }
        }

        public Statistics()
        {
            this.Count = 0;
            this.Sum = 0;
            this.Max = float.MinValue;
            this.Min = float.MaxValue;
        }

        public void AddGrade(float grade)
        {
            this.Count++;
            this.Sum += grade;
            this.Min = Math.Min(grade, this.Min);
            this.Max = Math.Max(grade, this.Max);
        }
    }
}
