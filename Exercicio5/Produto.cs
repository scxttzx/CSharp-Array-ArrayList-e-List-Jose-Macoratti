using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio5;

public class Produto
{
	public string Nome { get; set; }
	public decimal Preco { get; set; }

	public static void Exibir(List<Produto> produtos)
	{
		foreach (var produto in produtos)
		{
			Console.WriteLine($"Produto: {produto.Nome} - Preço: {produto.Preco.ToString("C", CultureInfo.CurrentCulture)}");
		}
		Console.WriteLine($"\nO preço total do carrinho é: {Soma(produtos).ToString("C", CultureInfo.CurrentCulture)}");
		Console.WriteLine($"\nA média de preço dos produtos somados é: {Media(produtos).ToString("C", CultureInfo.CurrentCulture)}");
	}
	public static decimal Soma(List<Produto> produtos)
	{
		decimal total = 0;
		foreach (var produto in produtos)
		{
			total += produto.Preco;
		}
		return total;
	}
	public static decimal Media(List<Produto> produtos)
	{
		decimal totalItens = produtos.Count();
		decimal media = Soma(produtos) / totalItens;
		return media;
	}
	public static void Adicionar(List<Produto> produtos)
	{
		Console.WriteLine("## Adicionando produtos ##\n");
		string continuar;
		do
		{
			Console.Write("Informe o nome do produto: ");
			string nome = Console.ReadLine();

			Console.Write("Informe o preço do produto: R$ ");
			decimal preco = Convert.ToDecimal(Console.ReadLine());

			produtos.Add(new Produto { Nome = nome, Preco = preco });

			Console.WriteLine($"\nAdicionando o item ao carrinho... \n");

			Console.Write("\nDeseja adicionar mais produtos ?(S/N)");
			continuar = Console.ReadLine();

			Console.WriteLine();

		} while (continuar == "s" || continuar == "S");
	}
	public static void ExibirMenorQue(List<Produto> produtos, decimal valor)
	{
		List<Produto> produtosMenorQue = new();
		foreach (var produto in produtos)
		{
			if (produto.Preco < valor)
			{
				produtosMenorQue.Add(produto);
			}
		}
		foreach (var p in produtosMenorQue)
		{
			Console.WriteLine($"Produto: {p.Nome} - Preço: {p.Preco.ToString("C", CultureInfo.CurrentCulture)}");
		}
	}
	public static void Buscar(List<Produto> produtos)
	{
		Console.WriteLine("Informe o nome do produto que deseja buscar: ");
		string item = Console.ReadLine();
		var exclusaoAlunos = produtos.Find(i => i.Nome == item);
		foreach (var produto in produtos)
		{
			if (exclusaoAlunos != null && item == produto.Nome)
			{
				Console.WriteLine($"O produto {produto.Nome} - {produto.Preco.ToString("C", CultureInfo.CurrentCulture)}, foi encontrado!!!!!\n MAIS NOVO tuts");
			}
		}

	}

}

