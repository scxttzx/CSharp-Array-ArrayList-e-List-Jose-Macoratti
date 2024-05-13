string[,] alunos;
alunos = new string[2,5];

ReceberAlunos(alunos);
ExibirAlunos(alunos);
static void ReceberAlunos(string[,] alunos)
{
    for (int i = 0; i < alunos.GetLength(0); i++)
    {
        for (int j = 0; j < alunos.GetLength(1); j++)
        {
            Console.WriteLine($"Linha {i} e Coluna {j}\nInforme o nome do aluno: ");
            alunos[i,j] = Console.ReadLine();
        }
    }
    Console.WriteLine("\nNomes recebidos com sucesso!!!");
}


static void ExibirAlunos(string[,] alunos)
{
    for (int i = 0; i < alunos.GetLength(0); i++)
    {
        for (int j = 0; j < alunos.GetLength(1); j++)
        {
            Console.Write($"Linha {i} e Coluna {j}, aluno ----> {alunos[i,j]}");
        }
        Console.WriteLine();
    }
    Console.WriteLine("\nNomes exibidos com sucesso!!!");
}