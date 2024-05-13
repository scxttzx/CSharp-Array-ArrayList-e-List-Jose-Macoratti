
var lista = new List<string>() { "Maria", "Ana", "Pedro", "Carlos", "Zé" };

lista.Add("Marta");

lista.Insert(2, "Bia");

Console.WriteLine(lista.Count + "itens");

var lista2 = new List<string>() { "Maria", "Pedro", "Ana" };

string[] array1 = { "Diná", "Carlos", "Pedro" };

lista.AddRange(array1);

lista.InsertRange(1, array1);

Console.WriteLine(lista2.Count + "itens");


// Removendo os elementos...
var lista3 = new List<int>() { 9, 5, 4, 1, 7, 8, 3, 6, 9, 0 };

lista3.Remove(7);
lista3.RemoveAt(4);
lista3.RemoveRange(0,2);

// Acessando os elementos...

var lista4 = new List<string>() { "Maria", "Ana", "Marcos", "Pedro" };

var primeiro = lista[0];
var quarto = lista[3];

Console.WriteLine(primeiro);
Console.WriteLine(quarto);

lista[0] = "Zé";
lista[3] = "Silvia";

Console.WriteLine(lista[0]);
Console.WriteLine(lista[3]);

Console.WriteLine(lista[9]);

// Iterando usando laço for...

for(int i = 0; i < lista4.Count; i++)
{
    Console.WriteLine(lista[i]);
}

// Iterando usando laço foreach...

foreach(var item in lista4)
{
    Console.WriteLine(item);
}

// Verificando se um elemento existe na coleção
var lista5 = new List<string>() { "Maria", "Ana", "Pedro", "Carlos", "Zé" };

var res1 = lista.Contains("Ana");
var res2 = lista.Contains("Zé");

var res3 = lista.Contains("Ze");
var res4 = lista.Contains("Mari");

Console.WriteLine(lista.Contains("Pedro"));

// Ordenando e removendo todos os elementos 

foreach(var item in lista5)
{
    Console.WriteLine(item);
}

lista.Sort();
foreach (var item in lista5)
{
	Console.WriteLine(item);
}

lista.Clear();
foreach (var item in lista5)
{
	Console.WriteLine(item);
}
Console.WriteLine("Fim");

Console.ReadKey();