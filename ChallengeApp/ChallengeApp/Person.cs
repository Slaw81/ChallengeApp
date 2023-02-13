namespace ChallengeApp
{
    public abstract class Person
    {
        public Person(string name, string surname, string age, string sex)
        {
            this.Name = name;
            this.Surname = surname;
            this.Age = age;
            this.Sex = sex;
        }

        public string Name { get; private set; }
        public string Surname { get; private set; }
        public string Age { get; private set; }
        public string Sex { get; private set; }

    }
}
