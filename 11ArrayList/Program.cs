

using System.Collections;
using System.Linq.Expressions;

var lista = new ArrayList() { "Maria", 5, true, " ", null };

lista.Add(3.5);

lista.Insert(2, "Paulo");

var lista2 = new ArrayList() { "Maria", 5, true };

int[] array1 = { 1, 2, 3 };

lista2.AddRange(array1);
lista2.InsertRange(2, array1);

Console.ReadKey();