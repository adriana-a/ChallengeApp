using ChallengeApp;

Console.WriteLine("Hello! You can collect grades of your employees and supervisor in this program and get statistics");
Console.WriteLine("----------------------------------------------------------------------------------");
Console.WriteLine();

var employee = new EmployeeInFile("Adriana", "Kopeć");
var employee2 = new EmployeeInMemory();

employee.GradeAdded += EmployeeGradeAdded;
employee2.GradeAdded += EmployeeGradeAdded;

void EmployeeGradeAdded(object sender, EventArgs args)
{
    Console.WriteLine("New grade is added");
}
Console.WriteLine("First grade from EmployeeInMemory without ReadLine:");
employee2.AddGrade(7);

Console.WriteLine();

while (true)
{
    Console.WriteLine("Write grade of your employee (A-E or 0-100) or q - get statistics ");
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



var statisticsEmployee = employee.GetStatistics();

Console.WriteLine($"Average grade of your employee is:{statisticsEmployee.Average} ({statisticsEmployee.AverageAsLetter})");
Console.WriteLine($"The highest grade of your employee is:{statisticsEmployee.Max}");
Console.WriteLine($"The lowest grade of your employee is:{statisticsEmployee.Min}");