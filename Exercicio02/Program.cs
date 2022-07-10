using Exercicio02;
using System.Globalization;

Funcionario primeiroFuncionario = new Funcionario();
Funcionario segundoFuncionario = new Funcionario();

Console.WriteLine("Dados do primeiro funcionário:");

Console.Write($"Nome: ");
primeiroFuncionario.Nome = Console.ReadLine();
Console.Write($"Salário: ");
primeiroFuncionario.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.WriteLine("Dados do segundo funcionário:");
Console.Write($"Nome: ");
segundoFuncionario.Nome = Console.ReadLine();
Console.Write($"Salário: ");
segundoFuncionario.Salario = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


double mediaSalarial = (primeiroFuncionario.Salario + segundoFuncionario.Salario) / 2.0;
Console.WriteLine("Salário médio = " + mediaSalarial.ToString("F2", CultureInfo.InvariantCulture));