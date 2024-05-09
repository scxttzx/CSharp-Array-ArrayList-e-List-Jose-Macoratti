int[] numeros;

numeros = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

string[] nomes = { "Ana", "Maria", "Marta", "Paulo", "Carlos" };

foreach (int numero in numeros)
{
	Console.WriteLine($"Número = {numero}\n");
}

foreach (string nome in nomes)
{
	Console.WriteLine($"Nome = {nome}\n");
}