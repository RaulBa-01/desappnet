using System;

namespace _09.vectoresaleatorios
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] A = new int[15];
            int [] B = new int[15];
            int [] C = new int[15];
            Random rnd = new Random();

            for(int i=0; i<A.Length; i++) {
                A[i]= rnd.Next(1,30);
                B[i]= rnd.Next(1,30);
                C[i]=  A[i]+B[i];
            }

            Console.WriteLine("\n el vector A" ); imprime(A);
            Console.WriteLine("\n el vector B" ); imprime(B);
            Console.WriteLine("\n el vector C" ); imprime(C);

            
        }
        static void imprime(int [] v) {
            for(int i=1; i<v.Length; i++)
            Console.Write($"{v[i]}");
        }
    }
}
