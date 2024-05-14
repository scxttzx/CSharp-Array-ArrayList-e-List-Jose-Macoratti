using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _19ListExercicio;

public class FonteDados
{
	public static List<Aluno> GetAlunos()
	{
		List<Aluno> alunos = new()
		{
			new() { Nome = "Maria", Nota = 8.75 },
			new() { Nome = "Manoel", Nota = 6.95 },
			new() { Nome = "Amanda", Nota = 7.25 },
			new() { Nome = "Carlos", Nota = 6.55 },
			new() { Nome = "Jaime", Nota = 8.50 },
			new() { Nome = "Debora", Nota = 5.95 },
			new() { Nome = "Sueli", Nota = 9.15 },
			new() { Nome = "Alicia", Nota = 9.25 },
			new() { Nome = "Sandra", Nota = 5.55 },
			new() { Nome = "Marta", Nota = 7.85 },
		};
		return alunos;
	}

	public static void ExibirInfos(List<Aluno> alunos)
	{
		double totalNotas = 0.0;
		double mediaNotas = 0.0;

		foreach (var aluno in alunos)
		{
			Console.WriteLine($"\n{aluno.Nome} tirou {aluno.Nota}.");
			totalNotas += aluno.Nota;
		}

		Console.WriteLine($"\nA turma possui {alunos.Count()} alunos matriculados.");
		mediaNotas = totalNotas / alunos.Count();
		Console.WriteLine($"A média aritmética das notas da prova foi de {Math.Round(mediaNotas, 2)}");
	}
	public static void DeletarAluno(List<Aluno> alunos, string nome)
	{
		var exclusaoAlunos = alunos.Find(a => a.Nome == nome);
		if (exclusaoAlunos != null)
		{
			alunos.Remove(exclusaoAlunos);
		}
	}
	public static void ExibirNotasMaiores(List<Aluno> alunos, double nota)
	{
		Console.WriteLine($"\n## Notas maiores ou iguais à {nota} ##");
		foreach (var aluno in alunos)
		{
			if (aluno.Nota >= nota)
			{
				Console.WriteLine($"Aluno: {aluno.Nome}\nNota: {aluno.Nota}");
			}
		}
	}
}
