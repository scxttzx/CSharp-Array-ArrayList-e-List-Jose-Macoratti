
string[] nomes = { "Ana", "Maria", "Dinair", "Paulo", "Carlos", "Beatriz" };

Console.WriteLine("\n\nExibindo o array original...");

ExibeArray(nomes);

Console.WriteLine("\n\nInvertendo o array...");
Array.Reverse(nomes);
ExibeArray(nomes);

Console.WriteLine("\n\nOrdenando o array...");
Array.Sort(nomes);
ExibeArray(nomes);

Console.WriteLine("\n\nLocalizando um item no array...");
Console.Write("Informe um nome: ");
string nome = Console.ReadLine(); 

var indice = Array.BinarySearch(nomes, nome);
if (indice >= 0)

	Console.WriteLine($"\n{nome} foi encontrado com índice = {indice}");
else
	Console.WriteLine($"\nSentimos muito...\nO nome \"{nome}\" não foi encontrado em nosso sistema.");

Console.ReadKey();

static void ExibeArray(string[] nomes)
{
	foreach (var name in nomes)
	{
		Console.Write($"{name}, ");
	}
}