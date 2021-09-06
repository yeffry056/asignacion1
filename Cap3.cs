using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asignacion1
{
    class Cap3
    {
        public static void NumeroPares()
        {
            int numero;
            Console.Write("digite un numero: ");
            numero = Convert.ToInt32(Console.ReadLine());
            if (numero % 2 == 0)
            {
                Console.WriteLine($"el numero {numero} es par");
            }
            else
                Console.WriteLine($"el numero {numero} no es par");
        }

        public static void DiasDeLaSemanas()
        {
            int numero;
            Console.Write("digite un numero del 1 al 7: ");
            numero = Convert.ToInt32(Console.ReadLine());

            switch (numero)
            {
                case 1:
                    Console.WriteLine("\nLunes");
                    break;
                case 2:
                    Console.WriteLine("\nMartes");
                    break;
                case 3:
                    Console.WriteLine("\nMiercoles");
                    break;
                case 4:
                    Console.WriteLine("\nJueves");
                    break;
                case 5:
                    Console.WriteLine("\nViernes");
                    break;
                case 6:
                    Console.WriteLine("\nSabado");
                    break;
                case 7:
                    Console.WriteLine("\nDomingo");
                    break;
                default:
                    Console.WriteLine("\nOpcion invalida.");
                    break;
            }

        }
    }
}
