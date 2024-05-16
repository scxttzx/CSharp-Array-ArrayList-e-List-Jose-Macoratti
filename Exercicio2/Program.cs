int[] arrayNums = CriarArrayAleatorio();

PesquisarNum(arrayNums);

static void PesquisarNum(int[] arrayExercicio)
{
	bool pesquisa;
	do
	{
		Console.Write("\nInforme o número para verificarmos se existe em nosso sistema: ");
		int numPesquisa = Convert.ToInt32(Console.ReadLine());
		pesquisa = arrayExercicio.Contains(numPesquisa);
		if (pesquisa == true)
		{
			Console.WriteLine($"O número {numPesquisa} está em nosso sistema");
		}
		else
			Console.WriteLine("O número não existe em nosso sistema");
	} while (pesquisa == false);
}
static int[] CriarArrayAleatorio()
{
	Random random = new Random();
	int[] arrayExercicio = new int[6];

	for (int i = 0; i < arrayExercicio.Length; i++)
	{
		int numSorteado;
		do
		{
			numSorteado = random.Next(0, 101);
			arrayExercicio[i] = numSorteado;
		} while (numSorteado != arrayExercicio[i]);
	}

	return arrayExercicio;
}

static void ExibirArray(int[] arrayNums)
{
	foreach (int num in arrayNums)
	{
		Console.WriteLine(num);
	}
}