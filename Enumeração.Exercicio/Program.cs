using System.Globalization;
using Enumeração.Exercicio.Entities;
using Enumeração.Exercicio.Entities.Enums;

/*
 Ler os dados de um trabalhador com N contratos (N fornecido pelo usuário). Depois, solicitar 
do usuário um mês e mostrar qual foi o salário do funcionário nesse mês, conforme exemplo 
(próxima página).

Exemplos a seguir: 

Enter department's name: Design
Enter worker data:
Name: Alex
Level (Junior/MidLevel/Senior): MidLevel
Base salary: 1200.00
How many contracts to this worker? 3
Enter #1 contract data:
Date (DD/MM/YYYY): 20/08/2018
Value per hour: 50.00
Duration (hours): 20
Enter #2 contract data:
Date (DD/MM/YYYY): 13/06/2018
Value per hour: 30.00
Duration (hours): 18
Enter #3 contract data:
Date (DD/MM/YYYY): 25/08/2018
Value per hour: 80.00
Duration (hours): 10
Enter month and year to calculate income (MM/YYYY): 08/2018
Name: Alex
Department: Design
Income for 08/2018: 3000.00

 */

Console.Write("Enter department's name: ");
string depName = Console.ReadLine();
Console.WriteLine("Enter worker data: ");
Console.Write("Name: ");
string name = Console.ReadLine();
Console.Write("Level (Junior/MidLevel/Senior): ");
WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());
Console.Write("Base salary: ");
double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Department dept = new Department(depName);
Worker worker = new Worker(name, level, baseSalary, dept);

Console.WriteLine("How many contracts to this worker? ");
int n = int.Parse(Console.ReadLine());
for (int i = 1; i <= n; i++)
{
    Console.WriteLine($"Enter #{i} contract data:");
    Console.Write("Date (DD/MM/YYYY): ");
    DateTime date = DateTime.Parse(Console.ReadLine());
    Console.Write("Value per hour: ");
    double valurPerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
    Console.Write("Duration (hours): ");
    int hours = int.Parse(Console.ReadLine());
    HourContract contract = new HourContract(date, valurPerHour, hours);
    worker.AddContract(contract);
}

Console.WriteLine();
Console.Write("Enter month and year o calculate income (MM/YYYY): ");
string monthAndYear = Console.ReadLine();
int month = int.Parse(monthAndYear.Substring(0, 2));
int year = int.Parse(monthAndYear.Substring(3));
Console.WriteLine("Name: " + worker.Name);
Console.WriteLine("Department: " + worker.Department.Name);
Console.WriteLine("Income: " + monthAndYear + ": " + worker.Income(year, month).ToString("F2", CultureInfo.InvariantCulture));
