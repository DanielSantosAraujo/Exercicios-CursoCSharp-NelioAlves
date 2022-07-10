using Exercicio07.ClasseEstaticas;
using System.Globalization;

Console.WriteLine("Qual a cotação do dólar? ");
double cotacao = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

Console.WriteLine("Quantos dólares você vai comprar? ");
double quantia = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

double result = ConversorDeMoeda.DolarParaReal(quantia, cotacao);

Console.WriteLine("Valor a ser pago em reais = " + result.ToString("F2", CultureInfo.InvariantCulture));