using ChallengeApp;

var employee1 = new Employee("Marcin", "Borowik", 54);
var employee2 = new Employee("Tomasz", "Rolnik", 24);
var employee3 = new Employee("Maciej", "Kasztan", 34);


employee1.AddScore(0);
employee1.AddScore(0);
employee1.AddScore(0);
employee1.AddScore(0);
employee1.AddScore(-100);

employee2.AddScore(2);
employee2.AddScore(2);
employee2.AddScore(0);
employee2.AddScore(0);
employee2.AddScore(0);

employee3.AddScore(1);
employee3.AddScore(0);
employee3.AddScore(0);
employee3.AddScore(0);
employee3.AddScore(0);

List<Employee> employees = new List<Employee>()
{
    employee1, employee2, employee3
};

int maxResult = -101;
Employee theBestEmployee = null;

foreach (var employee in employees)
{
    if (employee.Result > maxResult)
    {
        maxResult = employee.Result;
        theBestEmployee = employee;
    }
}

Console.WriteLine("Najlepszym pracownikiem w firmie jest " + theBestEmployee.Name + " " + theBestEmployee.Surname
                            + " z wynikiem " + theBestEmployee.Result);

