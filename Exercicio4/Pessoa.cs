using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercicio4;

public class Pessoa
{
    public string Nome { get; set; }
    public int Idade { get; set; }

    public static void Exibir(Pessoa pessoa)
    {
        Console.WriteLine($"Nome: {pessoa.Nome}\nIdade: {pessoa.Idade}");

    }
}
