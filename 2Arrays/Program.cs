int[] numeros;

numeros = new int[10] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

string[] nomes = { "Ana", "Maria", "Marta", "Paulo", "Carlos" };




for(int i = 0; i < numeros.Length; i++)
{
    Console.WriteLine($"Índice {i}\nvalor = {numeros[i]}\n");
}

for (int i = 0; i < nomes.Length; i++)
{
	Console.WriteLine($"Índice {i}\nvalor = {nomes[i]}\n");
}

Console.ReadKey();