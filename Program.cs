using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRY2Programacion
//Jarrison Ballesteros Manso
//Grupo:146
//Estructuras repetitivas-3
{
    using System;

    class Program
    {
        static void Main()
        {
            int Datopr;
            int[] limites_N  = { 2000, 4000 }; // Límites de los rangos medio y alto

            do
            {
                Console.Write("Ingrese un número entero mayor que 0 y menor que 5000: ");
                if (int.TryParse(Console.ReadLine(), out Datopr))
                {
                    if (Datopr <= 0 || Datopr >= 5000)
                    {
                        Console.WriteLine("El número debe estar en el rango especificado.");
                    }
                    else
                    {
                        if (Datopr > limites_N[1])
                        {
                            Console.WriteLine("El número está en el rango alto (mayor que 4000).");
                        }
                        else if (Datopr >= limites_N[0] && Datopr <= limites_N[1])
                        {
                            Console.WriteLine("El número está en el rango medio (entre 2000 y 4000).");
                        }
                        else
                        {
                            Console.WriteLine("El número está en el rango bajo (menor que 2000).");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Debe ingresar un número entero válido.");
                }
            } while (Datopr  <= 0 || Datopr >= 5000); // Se repite mientras el número no esté en el rango especificado

            Console.ReadKey();
        }
    }
   
}
