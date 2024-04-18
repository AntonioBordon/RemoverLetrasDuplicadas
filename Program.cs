using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Insira as palavras separadas por vírgula:");
        string input = Console.ReadLine();
        string[] palavras = input.Split(',');

        Console.WriteLine(string.Join(", ", RemoverDuplicados(palavras)));
    }

    static string[] RemoverDuplicados(string[] palavras)
    {
        List<string> resultado = new List<string>();

        foreach (string palavra in palavras)
        {
            resultado.Add(RemoverDuplicadosSequenciais(palavra));
        }

        return resultado.ToArray();
    }

    static string RemoverDuplicadosSequenciais(string palavra)
    {
        if (string.IsNullOrEmpty(palavra))
            return palavra;

        char[] caracteres = palavra.ToCharArray();
        char caracterAnterior = caracteres[0];
        string novaPalavra = caracterAnterior.ToString();

        for (int i = 1; i < caracteres.Length; i++)
        {
            if (caracteres[i] != caracterAnterior)
            {
                novaPalavra += caracteres[i];
                caracterAnterior = caracteres[i];
            }
        }

        return novaPalavra;
    }
}
