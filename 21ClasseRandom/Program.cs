

//byte[] randBytes = new byte[5];
//Random random = new Random(2023);
//random.NextBytes(randBytes);

//foreach (byte b in randBytes)
//{
//    Console.WriteLine($"{b}\n");
//}

//// Para gerar apenas um número aleatório
//Console.WriteLine(random.Next());
//Console.WriteLine(random.Next(20));
//Console.WriteLine(random.Next(10, 20));
//Console.WriteLine(random.NextDouble());

//// Para gerar mais de um número aleatório
//for (int i = 0; i < 5; i++)
//{
//	Console.WriteLine(random.Next());
//	Console.WriteLine(random.Next(100));
//	Console.WriteLine(random.NextDouble());
//}
//Console.ReadKey();

// Exercício

Console.WriteLine("\nSorteio da Mega Sena\n");

Random random = new();

int[] numerosSorteados = new int[6];
for (int i = 0; i < 6;i++)
{
	int numeroAleatorio;
	do
	{
		numeroAleatorio = random.Next(1, 61);
	} 
	while (numerosSorteados.Contains(numeroAleatorio));

	numerosSorteados[i] = numeroAleatorio;
}

Array.Sort(numerosSorteados);

Console.WriteLine("Números Sorteados\n");
Console.WriteLine(string.Join(" ", numerosSorteados));