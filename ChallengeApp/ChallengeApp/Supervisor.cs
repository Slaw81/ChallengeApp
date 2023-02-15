namespace ChallengeApp
{
    public class Supervisor : IEmployee

    {
        private List<float> grades = new List<float>();

        public Supervisor(string name, string surname)

        {
            this.Name = name;
            this.Surname = surname;
        }

        public string Name { get; private set; }
        public string Surname { get; private set; }

        //metoda publiczna dodania danych do listy z zewnątrz
        public void AddGrade(float grade)
        {

            //walidacja od 0do100
            if (grade >= 0 && grade <= 100)
            {
                this.grades.Add(grade);

            }
            else
            {
                throw new Exception("Chciałbyś !!");
                //Console.WriteLine("niepoprawna wartość!!!");
            }

        }


        public void AddGrade(double grade)
        {
            float gradeAsFloat = (float)grade;
            this.AddGrade(gradeAsFloat);

        }
        public void AddGrade(long grade)
        {
            float gradeAsFloat = (float)grade;
            this.AddGrade(gradeAsFloat);

        }
        public void AddGrade(int grade)
        {
            float gradeAsFloat = (float)grade;
            this.AddGrade(gradeAsFloat);

        }
        public void AddGrade(char grade)
        {
            float gradeAsFloat = (float)grade;
            this.AddGrade(gradeAsFloat);

        }

        public void AddGrade(string grade)
        {

            switch (grade)
            {
                case "6":
                    this.grades.Add(99);
                    break;
                case "5":
                    this.grades.Add(80);
                    break;
                case "4":
                    this.grades.Add(60);
                    break;
                case "3":
                    this.grades.Add(40);
                    break;
                case "-3":
                    this.grades.Add(35);
                    break;
                case "2":
                    this.grades.Add(20);
                    break;
                case "+2":
                    this.grades.Add(25);
                    break;
                case "1":
                    this.grades.Add(0);
                    break;
                default:
                    //parsowanie i konwersja na inny typ tu- string na float
                    if (float.TryParse(grade, out float result))
                    {
                        this.AddGrade(result);
                    }
                    throw new Exception("Zła litera");
                    //Console.WriteLine("Zła Litera");
                    break;

                    throw new Exception("Wpisz wartość od 0 do 100");
                    //Console.WriteLine("String nie jest Float");

            }





        }


        //jak...
        public Stats GetStats()
        {
            var stats = new Stats();
            stats.Average = 0;
            stats.Max = float.MinValue;
            stats.Min = float.MaxValue;

            foreach (var grade in this.grades)
            {
                // continue;
                //Math.Max(stats.Max - obecny max, grade - nowy max)
                stats.Max = Math.Max(stats.Max, grade);
                stats.Min = Math.Min(stats.Min, grade);
                //stats.Avrage = stats.Avrage + grade;
                stats.Average += grade;

            }

            // stats.Avrage = stats.Avrag / this.grades.Count;
            stats.Average /= this.grades.Count;
            switch (stats.Average)
            {
                //srednią ocene zamieniamy na literę "A"
                case var average when average >= 80:
                    stats.AverageLetter = 'A';
                    break;
                case var average when average >= 60:
                    stats.AverageLetter = 'B';
                    break;
                case var average when average >= 40:
                    stats.AverageLetter = 'C';
                    break;
                case var average when average >= 20:
                    stats.AverageLetter = 'D';
                    break;
                default:
                    stats.AverageLetter = 'E';
                    break;
            }
            return stats;
        }
    }
}
