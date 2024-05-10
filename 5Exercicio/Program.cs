using System.Net.Http.Headers;

string[] nomes = new string[5];
double[] notas = new double[5];


PopularArrayNomes(nomes);
PopularArrayNotas(notas);
ExibirNotas(nomes, notas);
double mediaNotas = CalcularMedia(notas);
Console.WriteLine($"A média das notas da avaliação de pagode foi {mediaNotas}");

static string[] PopularArrayNomes(string[] nomes)
{
	for (int i = 0; i < nomes.Length; i++)
	{
		Console.Write($"Informe o nome do aluno: ");
		nomes[i] = Console.ReadLine();
	}
	return nomes;
}

static double[] PopularArrayNotas(double[] notas)
{
    Console.WriteLine("");
    for (int i = 0; i < notas.Length; i++)
	{
		Console.Write($"Digite a nota: ");
		notas[i] = Convert.ToDouble(Console.ReadLine());
	}
	return notas;
}

static void ExibirNotas(string[] nomes, double[] notas)
{
	for(int i = 0;i < nomes.Length; i++) 
	{
        Console.WriteLine($"O aluno {nomes[i]} tirou {notas[i]} em pagode na Uerj");   
	}
}

static double CalcularMedia(double[] notas)
{
	double somaNotas = notas.Sum();
	var totalNotas = notas.Count();
	double mediaFinal = somaNotas / totalNotas;
	return mediaFinal;
}