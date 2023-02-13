﻿namespace ChallengeApp
{
    public class Employee2 : Person
    {
        private List<float> grades = new List<float>();

        public Employee2(string name, string surname, string age, string sex)
        : base(name, surname, age, sex)
        {

        }


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
        public void AddGrade(string grade)
        {
            //parsowanie i konwersja na inny typ tu- string na float
            if (float.TryParse(grade, out float result))
            {
                this.AddGrade(result);
            }
            else
            {
                throw new Exception("Wpisz wartość od 0 do 100");
                //Console.WriteLine("String nie jest Float");
            }


        }

        public void AddGrade(double grade)
        {
            var gradeOfDuble = (float)grade;
            this.grades.Add(gradeOfDuble);

        }
        public void AddGrade(long grade)
        {
            var gradeOfLong = (float)grade;
            this.grades.Add(gradeOfLong);

        }
        public void AddGrade(int grade)
        {
            var gradeOfInt = (int)grade;
            this.grades.Add(gradeOfInt);

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
                    throw new Exception("Zła litera");
                    //Console.WriteLine("Zła Litera");
                    break;
            }
        }


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