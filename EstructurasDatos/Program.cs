using System;
using System.Collections.Generic;

namespace EstructurasDatos
{
    class Program
    {
        static void Main(string[] args)
        {
            int op, opcion;
            bool v;
            do
            {
                Console.WriteLine("\n1. Diccionarios" +
                "\n2. Colecciones");
                Console.Write("\nIngrese el numero de la opcion: ");
                opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        {
                            Console.Clear();
                            Dictionary<string, int> users = new Dictionary<string, int>();

                            users.Add("John Doe", 42);
                            users.Add("Jane Doe", 38);
                            users.Add("Joe Doe", 12);
                            users.Add("Jenna Doe", 12);

                            Console.WriteLine("John Doe is " + users["John Doe"] + " years old");

                            users.Remove("Jane Doe");

                            Console.WriteLine();
                            foreach (KeyValuePair<string, int> user in users)
                            {
                                Console.WriteLine("Key = {0}, Value = {1}",
                                    user.Key, user.Value);
                            }

                            Console.WriteLine();
                            if (!users.ContainsKey("Jane Doe"))
                            {
                                Console.WriteLine("Key \"Jane Doe\" is not found.");
                            }
                            break;
                        }

                    case 2:
                        {
                            Console.Clear();
                            v = true;
                            while (v == true)
                            {

                                Console.WriteLine("\n1. Colecciones ingresando el valor de su tamaño" + "\n2. Colecciones con datos predefinidos.");
                                Console.Write("\nIngrese el numero de la opcion: ");
                                opcion = Convert.ToInt32(Console.ReadLine());

                                if (opcion == 1)
                                {
                                    var numbers = new List<int>();

                                    Console.Write("Ingrese la cantidad de datos que desea ingresar: ");
                                    int cantidad = Convert.ToInt32(Console.ReadLine());
                                    for (var i = 0; i < cantidad; i++)
                                    {
                                        Console.Write("Ingrese un dato: ");
                                        var dato = Console.ReadLine();
                                        numbers.Add(Convert.ToInt32(dato));
                                    }


                                    Console.WriteLine("");
                                    for (var i = 0; i < numbers.Count; i++)
                                    {
                                        Console.Write(numbers[i] + " ");
                                    }
                                }
                                else if (opcion == 2)
                                {
                                    var numbers = new List<int> { 9, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
                                    numbers.Add(1);
                                    numbers.Add(2);
                                    numbers.Add(3);
                                    numbers.Add(4);
                                    numbers.Add(5);
                                    numbers.Add(6);
                                    numbers.Add(7);
                                    numbers.Add(8);
                                    numbers.Add(9);


                                    numbers[0] = 5;
                                    numbers.Remove(9);

                                    foreach (var number in numbers)
                                    {
                                        Console.Write(number + " ");
                                    }

                                }
                            }
                            break;
                        }
                    default:
                        Console.WriteLine("Número de opcion invalido intente de nuevo");
                        break;
                }
                Console.WriteLine("\nPulse 0 para salir del programa. Pulse otro número para continuar");
                op = Convert.ToInt32(Console.ReadLine());

            } while (op != 0);
        }
    }
}
