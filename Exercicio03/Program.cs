using Exercicio03;
using System.Globalization;
/* Escrever um programa que entre com os dados do produtos e 
mostre na tela os dados do produto e as atualições sobre ele*/

Produto p = new Produto();

Console.WriteLine("Entre os dados do produto:");
Console.Write("Nome: ");
p.Nome = Console.ReadLine();
Console.Write("Preço: ");
p.Preco = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
Console.Write("Quantidade no estoque: ");
p.Quantidade = int.Parse(Console.ReadLine());

Console.WriteLine();
Console.WriteLine("Dados do produto: " + p);

Console.WriteLine();
Console.Write("Digite a quantidade de produtos a ser adicionados ao estoque: ");
int qte = int.Parse(Console.ReadLine());
p.AdicionarProdutos(qte);

Console.WriteLine();
Console.WriteLine("Dados atualizados: " + p);

Console.WriteLine();
Console.Write("Digite a quantidade de produtos a ser removido do estoque: ");
qte = int.Parse(Console.ReadLine());
p.RemoverProdutos(qte);

Console.WriteLine();
Console.WriteLine("Dados atualizados: " + p);

