using System;

class Program
{
    static void Main(string[] args)
    {
        int num;// número que será verificado na sequência de Fibonacci
        Console.WriteLine("Digite um número para verificação de Fibonacci: \n");
        num = Int32.Parse(Console.ReadLine());
        bool pertence = false; // variável que indica se o número pertence ou não à sequência
        int a = 0, b = 1, c = 0; // variáveis para calcular a sequência de Fibonacci

        while (c < num)
        {
            c = a + b;
            a = b;
            b = c;
        }

        if (c == num)
        {
            pertence = true;
        }

        if (pertence)
        {
            Console.WriteLine("O número " + num + " pertence à sequência de Fibonacci.");
        }
        else
        {
            Console.WriteLine("O número " + num + " não pertence à sequência de Fibonacci.");
        }
        
    }
}
