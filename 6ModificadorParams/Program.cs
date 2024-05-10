Console.WriteLine("\nSoma de números inteiros\n");

int[] nums = { 1, 3, 65, 7 };

var soma = Calcular.Soma(nums);
Console.WriteLine(soma);

var soma2 = Calcular.Soma(new int[] { 1, 3, 2 });
Console.WriteLine(soma2);

var soma3 = Calcular.Soma2(1, 2, 3);
Console.WriteLine(soma3);

var soma4 = Calcular.Soma2(10, 20, 30, 40, 50);
Console.WriteLine(soma4);

Console.ReadKey();

public class Calcular
{
	public static int Soma(int[] numeros)
	{
		int totalSoma = 0;
		foreach (int numero in numeros) 
		{ 
		totalSoma += numero;
		}
		return totalSoma;
	}

	public static int Soma2(params int[] numeros)
	{
		int totalSoma = 0;
		foreach (int numero in numeros)
		{
			totalSoma += numero;
		}
		return totalSoma;
	}
}