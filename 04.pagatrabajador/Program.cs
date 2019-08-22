using System;

namespace _04.pagatrabajador
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            int horas, horasextra;
            float paga, tasa=0.3f;
            float bruta=0, extra=0, impuesto=0, neta=0;

            Console.Clear();
            Console.WriteLine("programa que calcula la paga de un trabajador");

            Console.WriteLine("nombre "); nombre=Console.ReadLine();
            Console.WriteLine("horas  "); horas=int.Parse(Console.ReadLine());
            Console.WriteLine("paga   "); paga=int.Parse(Console.ReadLine());

            horasextra = (horas>40 ? horas-40 : 0);

            
            extra = horasextra * (paga * 2);
            bruta = (horas-horasextra) * paga + extra;
            impuesto = bruta * tasa;
            neta = bruta - impuesto;

            Console.WriteLine($"{nombre} trabajo {horas} a una paga de {paga}");
            Console.WriteLine($"paga bruta {bruta}");
            Console.WriteLine($"impuesto {impuesto}");
            Console.WriteLine($"paga neta {neta}");

            
        }
    }
}
