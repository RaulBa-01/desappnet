using System;
using System.Globalization;
using Redes.Clases;
using System.Collections.Generic;

namespace Redes
{
    class Program
    {
        static void Main(string[] args)
        {
            CultureInfo InfoCultural = new CultureInfo("en-US");
            Red miRed = new Red("Red Patito","Mr Pato Macdonald","Av.Priceton 123, Orlando Florida");
            Console.WriteLine("Datos generales de la Red:");
            
            miRed.AgregarNodo(new Nodo("192.160.0.100","servidor","3","10","Linux"));
            miRed.AgregarNodo(new Nodo("192.168.0.101","computadora","2","12","IOS"));
            miRed.AgregarNodo(new Nodo("192.168.0.102","Computadora","8","5","Windows"));
            

            Vulnerabilidad vlnd1 = new Vulnerabilidad("CVE-2015-1635","microsoft","HTTP.sys permite a atacantes remotos ejecutar codigo arbitrario","remota", DateTime.Parse("04/14/2015",InfoCultural));
            Vulnerabilidad vlnd2 = new Vulnerabilidad("CVE-2017-0004","microsoft","El servidor LSASS permite causar una denegacion de servicio","local", DateTime.Parse("01/10/2001",InfoCultural));
            Vulnerabilidad vlnd3 = new Vulnerabilidad("CVE-2017-3847","cisco","Cisco Firepower Management Center XSS","remota", DateTime.Parse("02/21/2017",InfoCultural));
            Vulnerabilidad vlnd4 = new Vulnerabilidad("CVE-2009-2504","microsoft","Múltiples desbordamientos de enteros en APIs Microsoft .NET 1.1","local", DateTime.Parse("11/13/2009",InfoCultural));
            

            miRed.Nodos[0].AgregarVlnd(vlnd1);
            miRed.Nodos[0].AgregarVlnd(vlnd2);
            miRed.Nodos[1].AgregarVlnd(vlnd3);
            miRed.Nodos[2].AgregarVlnd(vlnd4);
           
           // miRed.Vulnerabilidad[0].AgregarVlnd(vlnd1);


            //imprimir reporte
            Console.WriteLine($"Empresa: {miRed.Empresa}");
            Console.WriteLine($"Propietario: {miRed.Propietario}");
            Console.WriteLine($"Domicilio: {miRed.Domicilio}");
            
            Console.WriteLine("\n Datos generales de los nodos");
            Console.WriteLine($"IP: {miRed.Nodos[0].Ip}, Tipo: {miRed.Nodos[0].Tipo}, Puertos: {miRed.Nodos[0].Puertos}, Saltos: {miRed.Nodos[0].Saltos}, SO: {miRed.Nodos[0].So}");

            Console.WriteLine("\n Vulneravilidades por nodo"); 
            Console.WriteLine($"IP: {miRed.Nodos[0].Ip}, Tipo: {miRed.Nodos[0].Tipo}");    
                      
           // Console.WriteLine("\n Vulneravilidades"); 
           // Console.WriteLine($"Clave: {miRed.Nodos[0].Clave}, Tipo: {miRed.Nodos[0].Tipo}");
        }
    }
}
