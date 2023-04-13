using ChallengeApp;

Console.WriteLine("Hello! You can collect grades of your employees and supervisor in this program and get statistics");
Console.WriteLine("----------------------------------------------------------------------------------");
Console.WriteLine();

var employee = new Employee();
var supervisor = new Supervisor();

while (true)
{
    Console.WriteLine("Write grade of your employee (A-E or 0-100) or q - get statistics, s - go to grading supervisor: ");
    var input = Console.ReadLine();
    if (input == "q")
    {
        break;
    }
    else if (input == "s")
    {
        break;
    }
    try
    {
        employee.AddGrade(input);
    }
    catch (Exception e)
    {
        Console.WriteLine($"Exception is catched: {e}");
    }   
}

while (true)
{
    Console.WriteLine("Write grade of your supervisor (1-6, included + and -) or q - get statistics: ");
    var input = Console.ReadLine();
    if (input == "q")
    {
        break;
    }
    try
    {
        supervisor.AddGrade(input);
    }
    catch (Exception e)
    {
        Console.WriteLine($"Exception is catched: {e}");
    }
}



var statisticsEmployee = employee.GetStatistics();
var statisticsSupervisor = supervisor.GetStatistics();

Console.WriteLine($"Average grade of your employee is:{statisticsEmployee.Average} ({statisticsEmployee.AverageAsLetter})");
Console.WriteLine($"The highest grade of your employee is:{statisticsEmployee.Max}");
Console.WriteLine($"The lowest grade of your employee is:{statisticsEmployee.Min}");

Console.WriteLine("=======================================================");

Console.WriteLine($"Average grade of your employee is:{statisticsSupervisor.Average} ({statisticsSupervisor.AverageAsLetter})");
Console.WriteLine($"The highest grade of your employee is:{statisticsSupervisor.Max}");
Console.WriteLine($"The lowest grade of your employee is:{statisticsSupervisor.Min}");