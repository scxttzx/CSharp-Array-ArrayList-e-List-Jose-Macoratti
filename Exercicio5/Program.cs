using Exercicio5;

List<Produto> produtos = new();

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


Produto.Exibir(produtos);

Console.WriteLine("## Adicionando uma Mochila ##");
produtos.Add(new Produto { Nome = "Mochila", Preco = 22.44m });
