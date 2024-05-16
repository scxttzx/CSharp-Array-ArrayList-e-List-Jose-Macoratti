float nota;
float[,] arrayNotas = new float[5,2];

Console.WriteLine("## CADASTRO DE NOTAS ##");
for(int i = 0; i < 5; i++)
{
	for(int j = 0; j < 2; j++)
	{
		Console.WriteLine($"Linha: {i}\nColuna: {j} ");
        Console.Write("Informe a nota desejada: ");
		nota = float.Parse(Console.ReadLine());
		arrayNotas[i,j] = nota;
    }
}


for (int i = 0; i < 5; i++)
{
	for (int j = 0; j < 2; j++)
	{
		Console.WriteLine("\n\t\tNota");
		Console.WriteLine($"Aluno [{i},{j}] \t {arrayNotas[i,j]}");

	}
}