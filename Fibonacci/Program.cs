using System;




namespace Fibonacci
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Digite um número: ");

            int numero = int.Parse(Console.ReadLine());

            
            
                int n1 = 0, n2 = 1, n3 = 0;
                while (numero > n3)
                {
                    n3 = n1 + n2;
                    n1 = n2;
                    n2 = n3;
                }
                if (numero == 0)
                {
                    Console.WriteLine("Este número pertence ao Fibonacci");
                }

                else if (numero == n3)
                {
                    Console.WriteLine("Este número pertence ao Fibonacci");
                }
                else
                {
                    Console.WriteLine("Este número não pertence ao Fibonacci");
                }
            
           
            
        }
    }
}
