using ChallengeApp;

var employee = new Employee("Adam", "Małysz");

employee.AddGrade(4);
employee.AddGrade(4);
employee.AddGrade(10);
employee.AddGrade(5);

var statistics = employee.GetStatistics();

Console.WriteLine($"Adam Małysz ma najwyższą ocenę taką {statistics.Max},a najniższą taką {statistics.Min}" +
                    $" ,a jego średnia ocen to {statistics.Average:N1}");
