using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _20Indexadores;

public class Time
{
	// Definir os limites do array
	string[] valor = new string[10];

	public string this[int i]
	{
		get 
		{ 
			if(i >= 0 && i < valor.Length) 
			{ 
				// Retornar o valor
				return valor[i];
			}
			return "Erro...";
		}
		set
		{
			if(i >= 0 && i <= valor.Length) 
			{
				// Atribuir o valor
				valor[i] = value;
			}
		}
	}
}
