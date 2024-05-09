string[] nomes = new string[5];
double[] notas = new double[5];

PopularArrayNomes("Gabriel", "Maria", "Lucas", "Iana", "sla");

 void PopularArrayNomes(string[] nome)
{
	foreach (string name in nome)
	{
		string n = Console.ReadLine();
		nomes.Append(n);
	}
}


double nota = Convert.ToDouble(Console.ReadLine());