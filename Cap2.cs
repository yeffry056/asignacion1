using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace asignacion1
{
    class Cap2
    {
        public static void CalcularPerimetro()
        {
            int lado, opcion;


            do
            {
                Console.Clear();
                Console.Write("1. Triangulo\n2. Cuadrado\n3. Pentagono\n4. Hexagono\n5. Heptagono\n6. Octogono\n7. Eneagono\n8. Decagono\n9. Undecagono\n10. Dodecagogono\n11. Salir\nElija un poligono: ");
                opcion = Convert.ToInt32(Console.ReadLine());

                Console.Write("\nDigite la longitud de un lado de su poligono: ");
                lado = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine($"Perimetro del triangulo = {lado * 3}");
                        Console.ReadKey();
                        break;
                    case 2:
                        Console.WriteLine($"Perimetro del cuadrado = {lado * 4}");
                        Console.ReadKey();
                        break;
                    case 3:
                        Console.WriteLine($"Perimetro del pentagono = {lado * 5}");
                        Console.ReadKey();
                        break;
                    case 4:
                        Console.WriteLine($"Perimetro del hexagono = {lado * 6}");
                        Console.ReadKey();
                        break;
                    case 5:
                        Console.WriteLine($"Perimetro del heptagono = {lado * 7}");
                        Console.ReadKey();
                        break;
                    case 6:
                        Console.WriteLine($"Perimetro del octagono = {lado * 8}");
                        Console.ReadKey();
                        break;
                    case 7:
                        Console.WriteLine($"Perimetro del eneagono = {lado * 9}");
                        Console.ReadKey();
                        break;
                    case 8:
                        Console.WriteLine($"Perimetro del decagono = {lado * 10}");
                        Console.ReadKey();
                        break;
                    case 9:
                        Console.WriteLine($"Perimetro del undecagono = {lado * 11}");
                        Console.ReadKey();
                        break;
                    case 10:
                        Console.WriteLine($"Perimetro del dodecagogono = {lado * 12}");
                        Console.ReadKey();
                        break;
                    case 11:
                        break;
                    default:
                        Console.WriteLine("Opcion invalida.");

                        break;


                }

            } while (opcion != 11);


        }
        public static void ConvertirGrados()
        {
            double res;
            Console.WriteLine("Convertir grados a radianes");
            Console.Write("ingrese la cantidad de grados: ");
            int grados = Convert.ToInt32(Console.ReadLine());
            res = (grados * 3.1416) / 180;
            Console.WriteLine($"Radianes: {res}");
        }
        public static void CambioDeMonedas()
        {
            float monedas, Cambio;
            int opc;
            Console.WriteLine("Convertir monedas $.");
            Console.Write("para cambiar de dolar a euro ingrese 1, para cambiar de euro a dolar ingrese 2: ");
            opc = Convert.ToInt32(Console.ReadLine());
            if (opc == 1)
            {
                Console.Write("\ningrese la cantidad de dolares: ");

            }
            else if (opc == 2)
            {
                Console.Write("\ningrese la cantidad de euros: ");

            }
            if (opc == 1 || opc == 2)
            {
                monedas = Convert.ToSingle(Console.ReadLine());
                Console.Write("\ningrese tipo de cambio del dia: ");
                Cambio = Convert.ToSingle(Console.ReadLine());
                Console.WriteLine($"\nCambio realizado: {monedas * Cambio}");
            }
            else
            {
                Console.WriteLine("Opcion invalida");
            }



        }
    }
}
