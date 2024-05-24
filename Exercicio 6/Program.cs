using Exercicio6;

List<object> objetos = new ();

void ProcessaObjetos(object objs)
{
	objetos.Add(objs);
}

ProcessaObjetos(1);
ProcessaObjetos("Maria");
ProcessaObjetos(new Teste());
ProcessaObjetos(null a);

foreach (var obj in objetos)
{
	Console.WriteLine($"\nObjeto: {obj} - Tipo: {obj.GetType()}");
}
