using System;

namespace _02.areacirculo
{
    class Program
    {
        static void Main(string[] args)
        {
            double radio=0, area=0;
        
            Console.WriteLine("Programa que calcula el area de un circulo!");
            Console.WriteLine("dame el radio ");
            radio = float.Parse(Console.ReadLine());

            area = Math.PI * Math.Pow(radio,2);

            Console.WriteLine($" es area es {area}");
        }
    }
}
