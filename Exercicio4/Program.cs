using Exercicio4;
using System.Collections;

ArrayList arrayList = new ArrayList();

for (int i = 1; i <= 3 ; i++)
{
    Console.Write($"\nInforme o nome e idade da pessoa nº{i}");
    Console.Write("\nNome: ");
    string nome = Console.ReadLine();
	Console.Write("Idade: ");
	int idade = int.Parse(Console.ReadLine());

    Pessoa pessoa = new Pessoa();
    pessoa.Nome = nome;
    pessoa.Idade = idade;

    Console.WriteLine($"Adicionando \"{pessoa.Nome}\", {pessoa.Idade} anos...");
    arrayList.Add(pessoa);

}

Console.WriteLine("\n## ArrayList com as três pessoas iniciais ##\n");


foreach (Pessoa p in arrayList)
{
	Pessoa.Exibir(p);
}

Pessoa pessoa1 = new Pessoa();
pessoa1.Nome = "Jaime";
pessoa1.Idade = 20;
arrayList.Add(pessoa1);

Pessoa pessoa2 = new Pessoa();
pessoa2.Nome = "Tânia";
pessoa2.Idade = 18;
arrayList.Add(pessoa2);

Console.WriteLine("\n## ArrayList após adicionar dois novos objetos ##\n");

foreach (Pessoa p in arrayList)
{
	Pessoa.Exibir(p);
    Console.WriteLine();
}

Console.WriteLine("\n## ArrayList após remover o último elemento ##\n");
arrayList.RemoveAt(4);

foreach (Pessoa p in arrayList)
{
    Pessoa.Exibir(p);
    Console.WriteLine();
}