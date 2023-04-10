using ChallengeApp;

Console.WriteLine("Hello! You can collect grades of your employees in this program and get statistics");
Console.WriteLine("----------------------------------------------------------------------------------");
Console.WriteLine();

var employee = new Employee();

while (true)
{
    Console.WriteLine("Write grade of your employee: ");
    var input = Console.ReadLine();
    if (input == "q")
    {
        break;
    }
    employee.AddGrade(input);
}



var statistics = employee.GetStatistics();

Console.WriteLine($"Average grade of your employee is:{statistics.Average} ({statistics.AverageAsLetter})");
Console.WriteLine($"The highest grade of your employee is:{statistics.Max}");
Console.WriteLine($"The lowest grade of your employee is:{statistics.Min}");
