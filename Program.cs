using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clasepersonal
{
    class Program
    {
        static void Main(string[] args)
        {
            calculadora miCalculadora = new calculadora();
            string vini="";
            string vfin = "";
            Console.WriteLine("Introduzca valor inicial");
            vini = Console.ReadLine();
            Console.WriteLine("Introduzca valor final");
            vfin = Console.ReadLine();


            
            miCalculadora = new calculadora();
            miCalculadora.valorInicial = Convert.ToInt32(vini);

            miCalculadora.valorFinal = Convert.ToInt32(vfin);
            Console.WriteLine("suma de " + vini + " + " + vfin);
            Console.WriteLine(miCalculadora.opera());
            Console.WriteLine("Resta de " + vini + " - " + vfin);
            Console.WriteLine(miCalculadora.opera('-'));
            Console.WriteLine("Multiplicacion de " + vini + " * " + vfin);
            Console.WriteLine(miCalculadora.opera("multiplica"));
            Console.WriteLine("Division de " + vini + " / " + vfin);
            Console.WriteLine(miCalculadora.opera("dividir"));
            Console.ReadLine();
            /*Console.WriteLine(miPersona.CalcularPago());
          
            Console.ReadLine();
            //Con sobrecarga de operador.
            Console.WriteLine(miPersona.CalcularPago(3,400));
            */
            Console.ReadLine();

        }

    }
}
