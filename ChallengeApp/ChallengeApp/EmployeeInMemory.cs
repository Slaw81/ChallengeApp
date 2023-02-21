namespace ChallengeApp
{
    internal class EmployeeInMemory : EmployeeBase
    {
        public override event GradeAddedDelegate GradeAdded;

        private List<float> grades = new List<float>();
        public EmployeeInMemory(string name, string surname) 
            : base(name, surname)
        {
        }

        public override void AddGrade(float grade)
        {
            //walidacja od 0do100
            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);
                if(GradeAdded != null)
                {
                    GradeAdded(this, new EventArgs());
                }

            }
            else
            {
                throw new Exception("Chciałbyś !!");
                //Console.WriteLine("niepoprawna wartość!!!");
            }
        }

        public override void AddGrade(string grade)
        {
            //parsowanie i konwersja na inny typ tu- string na float

                if (float.TryParse(grade, out float result))
                {
                    this.AddGrade(result);
                }
                else if (char.TryParse(grade, out char charcter))
                {
                    this.AddGrade(charcter);

                }
                else
                {
                    throw new Exception("Wpisz wartość od 0 do 100");
                }
        }

        public override void AddGrade(double grade)
        {
            float gradeAsFloat = (float)grade;
            this.AddGrade(gradeAsFloat);
        }

        public override void AddGrade(long grade)
        {
            float gradeAsFloat = (float)grade;
            this.AddGrade(gradeAsFloat);
        }

        public override void AddGrade(int grade)
        {
            float gradeAsFloat = (float)grade;
            this.AddGrade(gradeAsFloat);
        }

        public override void AddGrade(char grade)
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
                    throw new Exception("Zła litera");
                    //Console.WriteLine("Zła Litera");
                    break;
            }
        }

        public override Stats GetStats()
        {
            var stats = new Stats();
            foreach(var grade in this.grades)
            {
                stats.AddGrade(grade);
            }
            return stats;
        }
    }
}

