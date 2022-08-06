using System;

namespace Dado
{
    class Program
    {
        static void Main()
        {
            Random rnd = new Random();
            for (int number = 0; number < 1; number++) ;
            {
                int x = rnd.Next(10);
                Console.WriteLine("Chute um numero: ");
                string Resposta = Console.ReadLine();

                var y = Convert.ToInt16(Resposta);

                if (y == x)
                {
                    Console.WriteLine("Parabéns Você acertou:", y);
                }
                else
                {
                    Console.WriteLine("Você Errou!!!");
                }
            }
        }
    }
}
