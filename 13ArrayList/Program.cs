
using System.Collections;
using System.Net.WebSockets;

var lista = new ArrayList() { "Maria", 5, true, 4.5 ,null, DateTime.Now };

// Verificar se um elemento existe na coleção

var res1 = lista.Contains(5);
bool res2 = lista.Contains("Mari");

Console.WriteLine(res1);
Console.WriteLine(res2);
Console.WriteLine(lista.Contains(null)); // true

var lista2 = new ArrayList() { "Maria", "Ana", "Zilda", "Carlos", "Diná" };

Console.WriteLine("ArrayList original!!!");
foreach (var item in lista2)
{
    Console.Write($"{item} ");
}

lista2.Sort();

Console.WriteLine("ArrayList ordenado!!!");
foreach (var item in lista2)
{
    Console.Write($"{item} ");
}

Console.WriteLine("Números de elementos e capacidade no array antes do Clear " + lista2.Count + lista2.Capacity);
lista2.Clear();
Console.WriteLine("Números de elementos e capacidade no array depois do Clear " + lista2.Count + lista2.Capacity);


Console.ReadKey();