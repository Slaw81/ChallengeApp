using static ChallengeApp.EmployeeBase;

namespace ChallengeApp
{
    //co ma być zaimplementowane (w klasie jak..)
    public interface IEmployee

    {
        string Name { get; }
        string Surname { get; }

        //metoda publiczna dodania danych do listy z zewnątrz
        void AddGrade(float grade);
        void AddGrade(string grade);
        void AddGrade(double grade);
        void AddGrade(long grade);
        void AddGrade(int grade);
        void AddGrade(char grade);

        event GradeAddedDelegate GradeAdded;
        Stats GetStats();
    }
}

