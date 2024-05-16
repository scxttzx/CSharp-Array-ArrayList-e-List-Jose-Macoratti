using System.Resources;

string[] frutas = new string[10];
frutas = new string[]{"Maçã", "Banana", "Laranja", "Uva", "Manga", "Pêra", "Acabate", "Mamão", "Pêssego", "Amora"};

for (int i = 0; i < frutas.Count(); i++)
{
    Console.WriteLine(frutas[i]);
}

ExibirDados(frutas);

Console.WriteLine("\n" + frutas[1]);
Console.WriteLine(frutas[8]);

Console.WriteLine("\n" +frutas[2] + " ---> Kiwi");
frutas[2] = "Kiwi";
var ultimaFruta = frutas.Last();
ultimaFruta = "Caqui";

ExibirDados(frutas);

var frutasOrdenadas = frutas.Order().ToList();
Console.WriteLine();

foreach (string fOrdenada in frutasOrdenadas)
{
    Console.WriteLine(fOrdenada);
}

 var frutasInvertidas = frutas.OrderDescending().ToList();
Console.WriteLine();
foreach (string fInversa in frutasInvertidas)
{
    Console.WriteLine(fInversa);
}

static void ExibirDados(string[] frutas)
{
    Console.WriteLine();
    foreach (string fruta in frutas)
	{
		Console.WriteLine(fruta);
	}
}


