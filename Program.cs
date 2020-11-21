using System;

namespace Tabuada
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero;
            int finish;
            bool valorvalido; // vl = valor

            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("      *TABUADA*      \n");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("Digite um número e tecle Enter: ");
            valorvalido = Int32.TryParse (Console.ReadLine(), out numero);
            Console.ResetColor();

            if (!valorvalido || numero < 1)

            {
            Console.ForegroundColor = ConsoleColor.DarkRed;    
            Console.WriteLine("Número digitado inválido! ");
            Console.WriteLine("\n");
            Console.WriteLine("Digite um númaro válido! ");
            Console.WriteLine("\n");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Pressione enter para sair, e execute o programa novamente!");
            Console.ResetColor();
            Console.ReadKey();
            Environment.Exit(-1);

            }
            
            for (int x = 0; x <= 10; x++)
            
            {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.DarkMagenta;    
            finish = numero * x;
            Console.WriteLine($"{numero} x {x} = {finish}");
            Console.ResetColor();
            }

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("\nTecle enter para finalizar! ");
            Console.ResetColor();
            Console.ReadKey();
        }
    }
}
