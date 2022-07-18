using System;

namespace Tabuada
{
    internal class Program
    {
        static public int Tabu = 0;
        static public int Produto = 0; 
        static void Main(string[] args)
        {
            
            Console.WriteLine("Olá digite o numero que voce deseja saber a tabuada: \n");
            Tabu = int.Parse(Console.ReadLine());

            Console.WriteLine("o resultado deu:");

            for (int i = 0; i <=10; i++)
            {
                Produto = i * Tabu;
                
                Console.WriteLine(Tabu +" X "+ i + "= "+ Produto);

            }

        }
    }
}
