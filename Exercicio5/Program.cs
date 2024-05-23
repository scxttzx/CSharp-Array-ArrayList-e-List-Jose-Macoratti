using Exercicio5;

List<Produto> produtos = new();


Produto.Adicionar(produtos);


Produto.Exibir(produtos);

Console.WriteLine("## Adicionando uma Mochila ##");
produtos.Add(new Produto { Nome = "Mochila", Preco = 22.44m });


Console.WriteLine("\nInforme um valor para exibirmos todos os produtos com valores menores\n");
decimal valorMenorQue = Convert.ToDecimal(Console.ReadLine());

Produto.ExibirMenorQue(produtos, valorMenorQue);

Produto.Buscar(produtos);
