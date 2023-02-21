using ChallengeApp;

Console.WriteLine("Witamy w Programie Ocena Pracownika");
Console.WriteLine("===================================");
Console.WriteLine("Skala ocen:");
Console.WriteLine("A - Dostaniesz premię !!!");
Console.WriteLine("B - Jest OK!");
Console.WriteLine("C - Mogłoby być lepiej");
Console.WriteLine("D - Weź się za robotę !!");
Console.WriteLine("E - Ty tu jeszcze pracujesz ??? ");
Console.WriteLine();
Console.WriteLine("Podaj Imię");
string name = Console.ReadLine();
Console.WriteLine("Podaj Nazwisko");
string surname = Console.ReadLine();


//var employee = new Employee(name, surname);
//var supervisor = new Supervisor(name, surname);
var employee = new EmployeeInFile(name, surname);






while (true)
{
    //Console.WriteLine("Aby zakończyć wpisz: wyjdz");
    Console.WriteLine("Podaj kolejną ocenę:_ lub wpisz wyjdz by zakonczyc");

    var input = Console.ReadLine();
    if (input == "wyjdz")
    {
        break;
    }
    try
    {
        employee.AddGrade(input);
        //supervisor.AddGrade(input);
    }
    catch (Exception e)
    {
        Console.WriteLine($"Coś poszło nie tak :)........{e.Message}");
    }
}


var stats = employee.GetStats();
//var stats = supervisor.GetStats();
Console.WriteLine();
Console.WriteLine();
Console.WriteLine($"..{employee.Name} {employee.Surname}");
//Console.WriteLine($"Kierownik:{supervisor.Name} {supervisor.Surname}");
Console.WriteLine($"Average: {stats.Average:N2}");
Console.WriteLine($"Min: {stats.Min}");
Console.WriteLine($"Max: {stats.Max}");
Console.WriteLine($"Final: {stats.AverageLetter}");