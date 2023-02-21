namespace ChallengeApp
{
    public class EmployeeInFile : EmployeeBase
    {
        private const string fileName = "grades.txt";

        public override event GradeAddedDelegate GradeAdded;

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
                if (GradeAdded != null)
                {
                    GradeAdded(this, new EventArgs());
                }
            }
            else
            {
                throw new Exception("Chciałbyś !!");
            }
        }
        public override void AddGrade(string grade)
        {
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
            float result = (float)grade;
            this.AddGrade(result);
        }

        public override void AddGrade(long grade)
        {
            float result = grade;
            this.AddGrade(result);
        }

        public override void AddGrade(int grade)
        {
            float result = grade;
            this.AddGrade(result);
        }

        public override void AddGrade(char grade)
        {

            switch (grade)
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
                    throw new Exception("Zła litera");
                    //Console.WriteLine("Zła Litera");  
            }
        }
        public override Stats GetStats()
        {
            var stats = new Stats();


           if(File.Exists(fileName))
            {
                using (var reader = File.OpenText(fileName))
                {
                    var line = reader.ReadLine();
                    while(line !=null)
                    {
                        var number = float.Parse(line);
                        stats.AddGrade(number);
                        line = reader.ReadLine();                   
                    }
                }
            }
            return stats;
        }
    }
}
