using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asignacion1
{
    class Menu
    {
        public static void MenuPrincipal()
        {
            int opcion, opc, op, opci;
            do
            {
                Console.Clear();
                Console.Write("1. Capitulo1\n2. Capitulo2\n3. Capitulo3\n4. Salir\nElija una opcion: ");
                opcion = Convert.ToInt32(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        do
                        {
                            Console.Clear();
                            Console.Write("\nProgramas\n\n1. Imprimir nombre\n2. Agregar mas datos\n3. Salir\nElija una opcion: ");
                            opc = Convert.ToInt32(Console.ReadLine());
                            switch (opc)
                            {
                                case 1:
                                    Cap1.Nombre();
                                    Console.ReadKey();
                                    break;
                                case 2:
                                    Cap1.Agregar();
                                    Console.ReadKey();
                                    break;
                                case 3:
                                    break;
                                default:
                                    Console.WriteLine("Opcion invalida");
                                    break;
                            }


                        } while (opc != 3);
                        break;
                    case 2:
                        do
                        {
                            Console.Clear();
                            Console.Write("\nProgramas\n\n1. Calcular perimetro\n2. Convertir de grados a radianes\n3. Cambio de dolor y euro\n4. Salir\nElija una opcion: ");
                            op = Convert.ToInt32(Console.ReadLine());
                            switch (op)
                            {
                                case 1:
                                    Cap2.CalcularPerimetro();
                                    Console.ReadKey();
                                    break;
                                case 2:
                                    Cap2.ConvertirGrados();
                                    Console.ReadKey();
                                    break;
                                case 3:
                                    Cap2.CambioDeMonedas();
                                    Console.ReadKey();
                                    break;
                                case 4:
                                    break;
                                default:
                                    Console.WriteLine("Opcion invalida");
                                    break;
                            }

                        } while (op != 4);
                        break;
                    case 3:
                        do
                        {
                            Console.Clear();
                            Console.Write("Programas\n\n1. Numeros pares\n2. Dias de la semana\n3. Salir\nElija una opcion: ");
                            opci = Convert.ToInt32(Console.ReadLine());
                            switch (opci)
                            {
                                case 1:
                                    Cap3.NumeroPares();
                                    Console.ReadKey();
                                    break;
                                case 2:
                                    Cap3.DiasDeLaSemanas();
                                    Console.ReadKey();
                                    break;
                                case 3:
                                    break;
                                default:
                                    Console.WriteLine("Opcion invalida");
                                    break;
                            }

                        } while (opci != 3);
                        break;
                    case 4:
                        break;
                    default:
                        Console.WriteLine("Opcion invalida");
                        break;
                }

            } while (opcion != 4);
        }
    }
}
