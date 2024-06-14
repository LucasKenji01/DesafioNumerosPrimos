using System;

namespace Exericio
{
    class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());

            bool ehPrimo = true;

            if(num <= 1)
            {
                ehPrimo = false;
            }
            else
            {
                for(int i = 2; i <= num / 2; i ++)
                {
                    int divisao = num / i;
                    int resto = num - divisao * i;
                    if(resto == 0)
                    {
                        ehPrimo = false;
                    }
                }
            }

            if(ehPrimo)
            {
            Console.WriteLine("É primo");
            }
            else
            {
                Console.WriteLine("Não é primo");
            }
        }
    }
}