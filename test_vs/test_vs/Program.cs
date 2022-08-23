using System;
using System.Net;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using System.Diagnostics;
//using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;

namespace get_local_ip_address
{
    class Hello
    {

        enum Color { Yellow = 1, Blue, Green };
        static DateTime thisDate = DateTime.Now;

        static void Main(string[] args)
        {

            int sum = 0; int numero1 = 0; int numero2 = 0; int numero3 = 0; int numero4 = 0; int numero5 = 0; int promedio = 0;

            Console.WriteLine("Primer Numero");
            numero1 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Segundo Numero");
            numero2 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Tercer Numero");
            numero3 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Cuarto Numero");
            numero4 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("Quinto Numero");
            numero5 = Int32.Parse(Console.ReadLine());

            sum = numero1 + numero2 + numero3 + numero4 + numero5;
            promedio = sum / 5;

            Console.WriteLine("El Promedio es  {0}", promedio);
            Console.ReadKey();



        }
    }
}
