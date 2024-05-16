using Exercicio4;
using System.Collections;

ArrayList arrayList = new ArrayList();

for (int i = 0; i < 3; i++)
{
    Console.Write($"\nInforme o nome e idade da pessoa nº{i}");
    Console.Write("\nNome: ");
    string nome = Console.ReadLine();
	Console.Write("Idade: ");
	int idade = int.Parse(Console.ReadLine());

    Pessoa pessoa = new Pessoa();
    pessoa.Nome = nome;
    pessoa.Idade = idade;

    arrayList.Add(pessoa);
}

foreach(Pessoa p in arrayList)
{
	Pessoa.Exibir(p);
}