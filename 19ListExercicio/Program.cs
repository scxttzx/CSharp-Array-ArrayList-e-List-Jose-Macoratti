using System.Text.Json.Serialization;
using _19ListExercicio;

List<Aluno> alunos = FonteDados.GetAlunos();
Console.WriteLine("\n## RELAÇÃO DE ALUNOS ##\n");

FonteDados.ExibirInfos(alunos);

alunos.Add(new() { Nome = "Bia", Nota = 7.75 });
alunos.Add(new() { Nome = "Mario", Nota = 8.95 });

FonteDados.ExibirInfos(alunos);
FonteDados.DeletarAluno(alunos, "Amanda");
FonteDados.ExibirInfos(alunos);

var listaOrdenada = alunos.OrderBy(aluno => aluno.Nome).ToList();
FonteDados.ExibirInfos(listaOrdenada);

FonteDados.ExibirNotasMaiores(alunos, 8);

Console.ReadKey();





