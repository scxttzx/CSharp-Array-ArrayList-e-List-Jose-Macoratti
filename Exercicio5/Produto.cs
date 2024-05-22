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

}

