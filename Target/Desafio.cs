using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;

class Program
{
    static void Main(string[] args)
    {
        FibonacciCheck(21);
        CountLetterA("A abacaxi é amarelo.");
        CalculateSoma();
    }

    static void FibonacciCheck(int num)
    {
        List<int> fib = new List<int> { 0, 1 };
        while (fib[^1] + fib[^2] <= num)
        {
            fib.Add(fib[^1] + fib[^2]);
        }

        if (fib.Contains(num))
        {
            Console.WriteLine($"{num} pertence à sequência de Fibonacci.");
        }
        else
        {
            Console.WriteLine($"{num} não pertence à sequência de Fibonacci.");
        }
    }

    static void CountLetterA(string str)
    {
        var regex = new Regex("a", RegexOptions.IgnoreCase);
        var matches = regex.Matches(str);
        int count = matches.Count;

        Console.WriteLine($"A letra 'a' aparece {count} vezes na string.");
    }

    static void CalculateSoma()
    {
        int INDICE = 12, SOMA = 0, K = 1;

        while (K < INDICE)
        {
            K++;
            SOMA += K;
        }

        Console.WriteLine($"O valor de SOMA será {SOMA}.");
        // O valor de SOMA será 77
    }
}
