using System.Globalization;
using ExerciseComposition1_CSharp.Entities;
using ExerciseComposition1_CSharp.Entities.Enums;

Console.WriteLine("Enter department's name: ");
string depName = Console.ReadLine();
Console.WriteLine("Enter worker data: ");
Console.WriteLine("Name: ");
string workerName = Console.ReadLine();
Console.WriteLine("Level (Junior/MidLevel/Senior): ");
WorkerLevel workerLevel = Enum.Parse<WorkerLevel>(Console.ReadLine());
Console.WriteLine("Base salary: ");
double workerSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Department department = new Department(depName);
Worker worker = new Worker(workerName, workerLevel, workerSalary, department);

Console.WriteLine("How many contracts to this worker?");
int n = int.Parse(Console.ReadLine());

for (int i = 1; i <= n; i++)
{
    Console.WriteLine($"Enter #{i} contract data");
    Console.WriteLine("Date: (DD/MM/YYYY): ");
    DateTime date = DateTime.Parse(Console.ReadLine());
    Console.WriteLine("Value per hour: ");
    double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    Console.WriteLine("Duration (hours): ");
    int hours = int.Parse(Console.ReadLine());

    HourContract contract = new HourContract(date, valuePerHour, hours);

    worker.AddContract(contract);
}

Console.WriteLine();
Console.WriteLine("Enter month and year to calculate income (MM/YY): ");
string monthAndYear = Console.ReadLine();
int month = int.Parse(monthAndYear.Substring(0, 2));
int year = int.Parse(monthAndYear.Substring(3));

Console.WriteLine("Name: " + worker.Name);
Console.WriteLine("Department: " + worker.Department.Name);
Console.WriteLine("Income for " + monthAndYear + " : " + worker.Income(year, month).ToString("F2", CultureInfo.InvariantCulture));




