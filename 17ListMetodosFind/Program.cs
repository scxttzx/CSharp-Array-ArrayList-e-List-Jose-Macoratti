
List<string> frutas = new() { "Uva", "Banana", "Pera", "Maça", "Abacate", "Laranja", "Morango" };

var fruta1 = frutas.Find(i=> i.StartsWith('L'));
var fruta2 = frutas.Find(Procura);
Console.WriteLine(fruta1);
Console.WriteLine(fruta2);

Console.ReadKey();

static bool Procura(string item)
{
	return item.StartsWith('L');
}