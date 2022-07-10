using Exercicio01;

Pessoa primeiraPessoa = new Pessoa();
Pessoa segundaPessoa = new Pessoa();

Console.WriteLine("Dados da primeira pessoa:");
primeiraPessoa.Nome = Console.ReadLine();
primeiraPessoa.Idade = int.Parse(Console.ReadLine());

Console.WriteLine($"Nome: {primeiraPessoa.Nome}");
Console.WriteLine($"Idade: {primeiraPessoa.Idade}");

Console.WriteLine("Dados da segunda pessoa:");
segundaPessoa.Nome = Console.ReadLine();
segundaPessoa.Idade = int.Parse(Console.ReadLine());

Console.WriteLine($"Nome: {segundaPessoa.Nome}");
Console.WriteLine($"Idade: {segundaPessoa.Idade}");

if(primeiraPessoa.Idade > segundaPessoa.Idade)
{
    Console.WriteLine($"Pessoa mais velha: {primeiraPessoa.Nome}");
}else
{
    Console.WriteLine($"Pessoa mais velha: {segundaPessoa.Nome}");
}